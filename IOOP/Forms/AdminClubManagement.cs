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
    public partial class AdminClubManagement : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public AdminClubManagement()
        {
            InitializeComponent();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            Password _password = new Password();
            _password.ShowDialog();
            string password = _password.password;

            Club obj = new Club(txtName.Text, dateEstablished.Value.Date, txtDescription.Text, txtPresident.Text, txtVPresident.Text, txtSecretary.Text);
            SqlCommand cmd = new SqlCommand("insert into clubs(clubName, clubRegistrationDate, clubDescription, clubPresident, clubVicePresident, clubSecretary) values (@name, @date, @d, @p, @vp, @s)", con);
            SqlCommand cmd2 = new SqlCommand("insert into users(username, password, role) values(@name, @password, 'club')", con);

            cmd.Parameters.AddWithValue("@name", obj.ClubName);
            cmd2.Parameters.AddWithValue("@name", obj.ClubName);
            cmd2.Parameters.AddWithValue("@password", password);
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

        private void AdminClubManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
