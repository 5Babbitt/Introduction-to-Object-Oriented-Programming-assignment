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
            AdminClubsReport aClubReport = new AdminClubsReport();
            aClubReport.ShowDialog();
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            AdminActivityReport aActivityReport = new AdminActivityReport();
            aActivityReport.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
