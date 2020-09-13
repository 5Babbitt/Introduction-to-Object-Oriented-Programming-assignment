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
            if(txtName.TextLength > 1 && txtDescription.TextLength > 1 && txtPresident.TextLength > 1 && txtVPresident.TextLength > 1 && txtSecretary.TextLength > 1)
            {
                if (txtPassword1.Text == txtPassword2.Text && txtPassword2.TextLength >= 3 && txtPassword2.TextLength <= 18)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from Users where username ='" + txtName.Text + "'", con);
                    SqlCommand cmd2 = new SqlCommand("select count(*) from Archive where clubName ='" + txtName.Text + "'", con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    int count2 = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                    con.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("An active club already exists");
                        this.Close();
                    }
                    else if (count2 > 0)
                    {
                        DialogResult result = MessageBox.Show("Club found in archive. Would you like to reactivate it?", "Reactivate Club?", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            con.Open();
                            SqlCommand cmd1 = new SqlCommand("select regDate from Archive where clubName='" + txtName.Text + "'", con);
                            SqlDataReader readDate = cmd1.ExecuteReader();
                            readDate.Read();
                            DateTime rDate = readDate.GetDateTime(0);
                            con.Close();

                            Reactivate(txtName.Text, rDate);
                        }
                    }
                    else
                        Register();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords must match and contain between 3 and 18 characters!");
                }
            }
            else
            {
                MessageBox.Show("Please do not leave any fields empty");
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

        private void Reactivate(string n, DateTime d)
        {
            con.Open();
            string password = txtPassword2.Text;

            Club obj = new Club(n, d.Date, txtDescription.Text, txtPresident.Text, txtVPresident.Text, txtSecretary.Text);
            SqlCommand cmd = new SqlCommand("insert into Club(clubName, registrationDate, description, president, vicePresident, secretary) values (@name, @date, @d, @p, @vp, @s)", con);
            SqlCommand cmd1 = new SqlCommand("insert into Users(username, password, role) values(@name, '" + password + "', 'club')", con);
            SqlCommand cmd2 = new SqlCommand("Delete from Archive where clubName='" + n + "'", con);

            cmd.Parameters.AddWithValue("@name", obj.ClubName);
            cmd1.Parameters.AddWithValue("@name", obj.ClubName);
            cmd.Parameters.AddWithValue("@date", obj.ClubRegDate);
            cmd.Parameters.AddWithValue("@d", obj.ClubDesc);
            cmd.Parameters.AddWithValue("@p", obj.ClubPres);
            cmd.Parameters.AddWithValue("@vp", obj.ClubVPres);
            cmd.Parameters.AddWithValue("@s", obj.ClubSec);

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                MessageBox.Show("Club Reactivation Successful");
            else
                MessageBox.Show("Unable to Reactivate");

            con.Close();
        }

        private void RegisterClub_Load(object sender, EventArgs e)
        {

        }
    }
}
