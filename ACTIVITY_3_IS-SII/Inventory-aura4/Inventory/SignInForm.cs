using System;
using System.Windows.Forms;

namespace Inventory
{
    // REGISTER
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            AcceptButton = btnRegister;
            btnRegister.Click += btnRegister_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (fullName.Length == 0 || username.Length == 0 || password.Length == 0)
            {
                Warn("Please fill in all fields.");
                return;
            }
            if (username.Length > 50 || fullName.Length > 100)
            {
                Warn("The username or full name is too long.");
                return;
            }
            if (password.Length < 6)
            {
                Warn("The password must be at least 6 characters long.");
                return;
            }
            if (password != txtConfirmPassword.Text)
            {
                Warn("The password and re-entered password do not match.");
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                if (!Database.Register(fullName, username, password))
                {
                    Warn("That username is already taken. Please choose another one.");
                    txtUsername.Focus();
                    return;
                }
                MessageBox.Show("Registration successful! You can now sign in.", "Register",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to the database:\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Connected to the Designer, so this must remain.
        private void SignInForm_Load(object sender, EventArgs e)
        {
        }

        private static void Warn(string msg)
        {
            MessageBox.Show(msg, "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // connected to "Already have an account? Sign in here."
        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lblSystemName1_Click(object sender, EventArgs e)
        {

        }
    }
}