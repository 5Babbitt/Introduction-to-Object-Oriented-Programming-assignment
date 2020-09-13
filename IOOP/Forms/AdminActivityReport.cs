using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP.Forms
{
    public partial class AdminActivityReport : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public AdminActivityReport()
        {
            InitializeComponent();
        }

        private void AdminActivityReport_Load(object sender, EventArgs e)
        {
            UpdateActivities();
        }

        private void UpdateActivities()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Activity", con);
            SqlDataReader info = cmd.ExecuteReader();

            while (info.Read())
            {
                string cName = info.GetString(1);
                DateTime d = info.GetDateTime(2);
                string s = info.GetString(3);

                lstActivity.Items.Add(cName + " - " + d.ToString() + " - " + s);
            }

            con.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string Fpath = "C:/Users/owenh/source/repos/IOOP/IOOP/Reports/ActivityReport.txt";

            using (StreamWriter fs = File.CreateText(Fpath))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Activity", con);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string cName = read.GetString(1);
                    DateTime d = read.GetDateTime(2);
                    string s = read.GetString(3);

                    fs.WriteLine(cName + " - " + d.ToString() + " - " + s);
                }
                con.Close();
            }

            MessageBox.Show("Report Successfully Generated");
        }
    }
}
