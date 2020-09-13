using IOOP.Classes;
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
    public partial class WeeklyLog : Form
    {
        public static string cName;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public WeeklyLog(string n)
        {
            InitializeComponent();
            cName = n;

            lblClubName.Text = cName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtDescription.TextLength > 0)
            {
                con.Open();
                Activity activ = new Activity(cName, dateOfEntry.Value, txtDescription.Text);

                SqlCommand cmd = new SqlCommand("insert into Activity(clubName, dateTime, description) values(@name, @doe, @desc)", con);

                cmd.Parameters.AddWithValue("@name", activ.ClubName);
                cmd.Parameters.AddWithValue("@doe", activ.DateEntry);
                cmd.Parameters.AddWithValue("@desc", activ.Description);

                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                    MessageBox.Show("Activity Added Successfully");
                else
                    MessageBox.Show("Unable to add activity");

                con.Close();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please don't leave any empty fields");
            }
        }
    }
}
