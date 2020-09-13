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
    }
}
