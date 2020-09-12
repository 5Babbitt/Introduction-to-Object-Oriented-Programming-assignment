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
    public partial class ClubRepMenu : Form
    {
        public ClubRepMenu()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateClubDesc desc = new UpdateClubDesc();
            desc.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WeeklyLog log = new WeeklyLog();
            log.ShowDialog();

        }
    }
}
