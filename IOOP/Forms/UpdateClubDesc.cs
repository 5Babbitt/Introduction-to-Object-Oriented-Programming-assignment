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
    public partial class UpdateClubDesc : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public static string cname;

        public UpdateClubDesc(string name)
        {
            InitializeComponent();
            cname = name;

            UpdateDescription();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Club set description=@desc where clubName='" + cname + "'", con);
            cmd.Parameters.AddWithValue("@desc", txtDetails.Text);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                MessageBox.Show("Club Description Updated Successful ");
            else
                MessageBox.Show("Unable to Update");

            con.Close();

            this.Close();
        }

        private void UpdateDescription()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select description from Club where clubName='" + cname + "'", con);
            SqlDataReader read = cmd.ExecuteReader();
            read.Read();
            string desc = read.GetString(0);
            con.Close();

            txtDetails.Text = desc;
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
