using System;
using System.Windows.Forms;

namespace Inventory
{
    // Dashboard
    
    public partial class DashboardForm : Form
    {
        private readonly UserInfo _user;

        public DashboardForm() : this(new UserInfo { Username = "", FullName = "" }) { }

        public DashboardForm(UserInfo user)
        {
            InitializeComponent();
            _user = user;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTotalCap_Click(object sender, EventArgs e)
        {

        }

        private void lblLowValue_Click(object sender, EventArgs e)
        {

        }

        private void lblOutValue_Click(object sender, EventArgs e)
        {

        }

        private void recR2C2_Click(object sender, EventArgs e)
        {

        }
    }
}
