using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;

namespace Inventory
{
    /// <summary>Isang user record.</summary>
    public class UserInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
    }

    /// <summary>Isang product / item sa inventory.</summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    /// <summary>
    /// Backend / data layer. Gumagamit ng SQL Server LocalDB (kasama sa Visual Studio,
    /// walang kailangang i-install na NuGet package). Awtomatikong ginagawa ang database
    /// at mga table sa unang takbo ng app.
    /// Lokasyon ng database file: %LocalAppData%\InventoryApp\InventoryDb.mdf
    /// </summary>
    internal static class Database
    {
        private const string DbName = "InventoryDb";
        private const string Server = @"(LocalDB)\MSSQLLocalDB";
        private const int Iterations = 100000;

        private static readonly string DataDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "InventoryApp");
        private static readonly string MdfPath = Path.Combine(DataDir, DbName + ".mdf");

        private static readonly string MasterConn =
            "Server=" + Server + ";Integrated Security=true;Initial Catalog=master;Connect Timeout=30";
        private static readonly string AppConn =
            "Server=" + Server + ";Integrated Security=true;Initial Catalog=" + DbName + ";Connect Timeout=30";

        private static bool _initialized;

        // ---------------------------------------------------------------- setup

        /// <summary>Gumawa ng database + tables kung wala pa. Tawagin sa simula ng app.</summary>
        public static void Initialize()
        {
            if (_initialized) return;
            Directory.CreateDirectory(DataDir);

            using (var master = new SqlConnection(MasterConn))
            {
                master.Open();
                bool exists;
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM sys.databases WHERE name = @n", master))
                {
                    cmd.Parameters.AddWithValue("@n", DbName);
                    exists = (int)cmd.ExecuteScalar() > 0;
                }
                if (!exists)
                {
                    string ldf = Path.Combine(DataDir, DbName + "_log.ldf");
                    string sql = File.Exists(MdfPath)
                        ? "CREATE DATABASE [" + DbName + "] ON (FILENAME = N'" + MdfPath + "') FOR ATTACH"
                        : "CREATE DATABASE [" + DbName + "] ON (NAME = N'" + DbName + "', FILENAME = N'" + MdfPath +
                          "') LOG ON (NAME = N'" + DbName + "_log', FILENAME = N'" + ldf + "')";
                    using (var cmd = new SqlCommand(sql, master)) cmd.ExecuteNonQuery();
                }
            }

            const string schema = @"
IF OBJECT_ID('dbo.Users', 'U') IS NULL
CREATE TABLE dbo.Users (
    Id           INT IDENTITY(1,1) PRIMARY KEY,
    Username     NVARCHAR(50)  NOT NULL UNIQUE,
    FullName     NVARCHAR(100) NOT NULL,
    PasswordHash VARBINARY(32) NOT NULL,
    Salt         VARBINARY(16) NOT NULL,
    CreatedAt    DATETIME2     NOT NULL DEFAULT SYSUTCDATETIME()
);
IF OBJECT_ID('dbo.Products', 'U') IS NULL
CREATE TABLE dbo.Products (
    Id        INT IDENTITY(1,1) PRIMARY KEY,
    Name      NVARCHAR(100)  NOT NULL,
    Quantity  INT            NOT NULL DEFAULT 0,
    Price     DECIMAL(18,2)  NOT NULL DEFAULT 0,
    CreatedAt DATETIME2      NOT NULL DEFAULT SYSUTCDATETIME()
);";
            using (var conn = new SqlConnection(AppConn))
            {
                conn.Open();
                using (var cmd = new SqlCommand(schema, conn)) cmd.ExecuteNonQuery();
            }
            _initialized = true;
        }

        private static SqlConnection Open()
        {
            Initialize();
            var c = new SqlConnection(AppConn);
            c.Open();
            return c;
        }

        // ---------------------------------------------------------------- passwords

        private static byte[] Hash(string password, byte[] salt)
        {
            using (var kdf = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
                return kdf.GetBytes(32);
        }

        private static bool SameBytes(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++) diff |= a[i] ^ b[i];
            return diff == 0;
        }

        // ---------------------------------------------------------------- users

        /// <summary>Mag-register ng bagong user. Return false kung may kaparehong username na.</summary>
        public static bool Register(string fullName, string username, string password)
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create()) rng.GetBytes(salt);
            byte[] hash = Hash(password, salt);

            using (var conn = Open())
            using (var cmd = new SqlCommand(
                @"IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Username = @u)
                  BEGIN
                      INSERT INTO dbo.Users (Username, FullName, PasswordHash, Salt) VALUES (@u, @f, @h, @s);
                      SELECT 1;
                  END
                  ELSE SELECT 0;", conn))
            {
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = username;
                cmd.Parameters.Add("@f", SqlDbType.NVarChar, 100).Value = fullName;
                cmd.Parameters.Add("@h", SqlDbType.VarBinary, 32).Value = hash;
                cmd.Parameters.Add("@s", SqlDbType.VarBinary, 16).Value = salt;
                return (int)cmd.ExecuteScalar() == 1;
            }
        }

        /// <summary>I-check ang username/password. Return UserInfo kung tama, null kung mali.</summary>
        public static UserInfo Authenticate(string username, string password)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand(
                "SELECT Id, Username, FullName, PasswordHash, Salt FROM dbo.Users WHERE Username = @u", conn))
            {
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = username;
                using (var r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    byte[] stored = (byte[])r["PasswordHash"];
                    byte[] salt = (byte[])r["Salt"];
                    if (!SameBytes(stored, Hash(password, salt))) return null;
                    return new UserInfo
                    {
                        Id = (int)r["Id"],
                        Username = (string)r["Username"],
                        FullName = (string)r["FullName"]
                    };
                }
            }
        }

        // ---------------------------------------------------------------- products

        public static List<Product> GetProducts()
        {
            var list = new List<Product>();
            using (var conn = Open())
            using (var cmd = new SqlCommand("SELECT Id, Name, Quantity, Price FROM dbo.Products ORDER BY Name", conn))
            using (var r = cmd.ExecuteReader())
            {
                while (r.Read())
                    list.Add(new Product
                    {
                        Id = (int)r["Id"],
                        Name = (string)r["Name"],
                        Quantity = (int)r["Quantity"],
                        Price = (decimal)r["Price"]
                    });
            }
            return list;
        }

        public static int AddProduct(string name, int quantity, decimal price)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand(
                "INSERT INTO dbo.Products (Name, Quantity, Price) VALUES (@n, @q, @p); SELECT CAST(SCOPE_IDENTITY() AS INT);", conn))
            {
                cmd.Parameters.Add("@n", SqlDbType.NVarChar, 100).Value = name;
                cmd.Parameters.Add("@q", SqlDbType.Int).Value = quantity;
                cmd.Parameters.Add("@p", SqlDbType.Decimal).Value = price;
                return (int)cmd.ExecuteScalar();
            }
        }

        public static void UpdateProduct(int id, string name, int quantity, decimal price)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand(
                "UPDATE dbo.Products SET Name = @n, Quantity = @q, Price = @p WHERE Id = @id", conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@n", SqlDbType.NVarChar, 100).Value = name;
                cmd.Parameters.Add("@q", SqlDbType.Int).Value = quantity;
                cmd.Parameters.Add("@p", SqlDbType.Decimal).Value = price;
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteProduct(int id)
        {
            using (var conn = Open())
            using (var cmd = new SqlCommand("DELETE FROM dbo.Products WHERE Id = @id", conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
