using IOOP_Assignment_Group_11.Classes;
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
    public partial class RegisterClub : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public RegisterClub()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text == txtPassword2.Text && txtPassword2.TextLength >= 3 && txtPassword2.TextLength <= 18)
            {
                Register();

                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords must match and contain between 3 and 18 characters!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register()
        {
            
            
            con.Open();
            string password = txtPassword2.Text;

            Club obj = new Club(txtName.Text, dateEstablished.Value.Date, txtDescription.Text, txtPresident.Text, txtVPresident.Text, txtSecretary.Text);
            SqlCommand cmd = new SqlCommand("insert into Club(clubName, registrationDate, description, president, vicePresident, secretary) values (@name, @date, @d, @p, @vp, @s)", con);
            SqlCommand cmd2 = new SqlCommand("insert into Users(username, password, role) values(@name, '" + password + "', 'club')", con);

            cmd.Parameters.AddWithValue("@name", obj.ClubName);
            cmd2.Parameters.AddWithValue("@name", obj.ClubName);
            cmd.Parameters.AddWithValue("@date", obj.ClubRegDate);
            cmd.Parameters.AddWithValue("@d", obj.ClubDesc);
            cmd.Parameters.AddWithValue("@p", obj.ClubPres);
            cmd.Parameters.AddWithValue("@vp", obj.ClubVPres);
            cmd.Parameters.AddWithValue("@s", obj.ClubSec);

            cmd2.ExecuteNonQuery();

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                MessageBox.Show("Club Registration Successful");
            else
                MessageBox.Show("Unable to Register");

            con.Close();
        }
    }
}
