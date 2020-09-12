using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP.Forms
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            AdminClubManagement aClubMenu = new AdminClubManagement();
            aClubMenu.ShowDialog();
        }

        private void btnClubReport_Click(object sender, EventArgs e)
        {

        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            LoginMenu _Login = new LoginMenu();
            _Login.Show();
            this.Hide();
        }
    }
}
