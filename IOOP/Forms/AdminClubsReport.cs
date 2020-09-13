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
using System.IO;

namespace IOOP.Forms
{
    public partial class AdminClubsReport : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public AdminClubsReport()
        {
            InitializeComponent();
        }

        private void AdminClubsReport_Load(object sender, EventArgs e)
        {
            lstClubs.Items.Clear();

            con.Open();
            SqlCommand cmd = new SqlCommand("select clubName from Club", con);
            SqlDataReader update = cmd.ExecuteReader();
            while (update.Read())
            {
                lstClubs.Items.Add(update.GetString(0));
            }
            con.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string Fpath = "C:/Users/owenh/Desktop/Reports/ClubReport.txt";

            using (StreamWriter fs = File.CreateText(Fpath))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select clubName, registrationDate from Club", con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    fs.WriteLine(read.GetString(0));
                }
                con.Close();
            }

            MessageBox.Show("Report Successfully Generated");
        }

        private void lstClubs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
