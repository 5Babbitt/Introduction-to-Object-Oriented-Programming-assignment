using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP.Forms
{
    public partial class ClubRepMenu : Form
    {
        public static string CName;

        SqlConnection link = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public ClubRepMenu(string N)
        {
            InitializeComponent();
            CName = N;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateClubDesc desc = new UpdateClubDesc(CName);
            desc.ShowDialog();

            UpdateDescription();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WeeklyLog log = new WeeklyLog(CName);
            log.ShowDialog();

        }

        private void ClubRepMenu_Load(object sender, EventArgs e)
        {

            lblClubName.Text = CName;

            UpdateDescription();

            link.Open();
            SqlCommand loadD = new SqlCommand("SELECT registrationDate FROM Club WHERE clubName='" + CName + "'", link);
            SqlDataReader getD = loadD.ExecuteReader();
            getD.Read();
            lblDate.Text = getD.GetDateTime(0).ToString().Remove(11);
            link.Close();

            UpdateActivities();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateDescription()
        {
            link.Open();
            SqlCommand loadCD = new SqlCommand("SELECT description FROM Club WHERE clubName='" + CName + "'", link);
            SqlDataReader getCD = loadCD.ExecuteReader();
            getCD.Read();
            txtDetails.Text = getCD.GetString(0);
            link.Close();
        }

        private void UpdateActivities()
        {
            link.Open();

            link.Close();
        }
    }
}
