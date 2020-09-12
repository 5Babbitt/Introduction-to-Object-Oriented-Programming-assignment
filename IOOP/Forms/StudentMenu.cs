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

    public partial class StudentMenu : Form
    {
        SqlConnection link = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public StudentMenu()
        {
            InitializeComponent();
        }

        private void StudentMenu_Load(object sender, EventArgs e)
        {
            link.Open();
            SqlCommand grab = new SqlCommand("SELECT clubName FROM Club", link);
            SqlDataReader update = grab.ExecuteReader();
            while (update.Read())
            {
                lstClubs.Items.Add(update.GetString(0));
            }
            link.Close();
        }

        private void lstClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClub = lstClubs.GetItemText(lstClubs.SelectedItem);
            lblClubName.Text = selectedClub;

            link.Open();
            SqlCommand checkP = new SqlCommand("SELECT president FROM Club WHERE clubName='" + selectedClub + "'", link);
            SqlDataReader readP = checkP.ExecuteReader();
            readP.Read();
            lblPresident.Text = "Club President: " + readP.GetString(0);
            link.Close();

            link.Open();
            SqlCommand checkDate = new SqlCommand("SELECT registrationDate FROM Club WHERE clubName='" + selectedClub + "'", link);
            SqlDataReader readDate = checkDate.ExecuteReader();
            readDate.Read();
            lblDate.Text = "Registered Date: " + readDate.GetDateTime(0).ToString().Remove(11);
            link.Close();

            link.Open();
            SqlCommand checkD = new SqlCommand("SELECT description FROM Club WHERE clubName='" + selectedClub + "'", link);
            SqlDataReader readD = checkD.ExecuteReader();                     
            readD.Read();
            txtDetails.Text = readD.GetString(0);
            link.Close();
        }
    }
}
