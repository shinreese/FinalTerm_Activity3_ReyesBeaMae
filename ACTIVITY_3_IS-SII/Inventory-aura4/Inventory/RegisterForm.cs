using System;
using System.Windows.Forms;

namespace Inventory
{
    // SIGN IN
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            AcceptButton = btnSignIn;
            btnSignIn.Click += btnSignIn_Click;
            lnkCreateAccount.LinkClicked += lnkCreateAccount_LinkClicked;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please enter your username and password.", "Sign In",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserInfo user = Database.Authenticate(username, password);
                if (user == null)
                {
                    MessageBox.Show("Incorrect username or password.", "Sign In",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                txtPassword.Clear();
                Hide();
                using (var dash = new DashboardForm(user)) dash.ShowDialog();
                Show();   // Return to the sign-in form after logging out
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to the database:\n" + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            using (var reg = new SignInForm()) reg.ShowDialog();
            Show();
            txtUsername.Focus();
        }

        private void lblWelcomeBack_Click(object sender, EventArgs e)
        {

        }
    }
}