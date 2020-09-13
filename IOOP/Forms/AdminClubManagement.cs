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

        public string password;

        public AdminClubManagement()
        {
            InitializeComponent();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select registrationDate from Club where clubName='" + txtName.Text + "'", con);
            SqlDataReader readDate = cmd1.ExecuteReader();
            readDate.Read();
            DateTime rDate = readDate.GetDateTime(0);
            con.Close();

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Archive (clubName, regDate) values (@name, @regDate)", con);
            SqlCommand cmd2 = new SqlCommand("Delete from Club where clubName='" + txtName.Text + "'", con);
            SqlCommand cmd3 = new SqlCommand("Delete from Users where username='" + txtName.Text + "'", con);

            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@regDate", rDate);

            int i = cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            con.Close();

            if (i != 0)
                MessageBox.Show("Club Archived Successfully");
            else
                MessageBox.Show("Unable to Archive");

            UpdateListBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update Club set description=@desc,president=@pres,vicePresident=@vPres,secretary=@sec where clubName='" + txtName.Text + "'", con);

            cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
            cmd.Parameters.AddWithValue("@pres", txtPresident.Text);
            cmd.Parameters.AddWithValue("@vPres", txtVPresident.Text);
            cmd.Parameters.AddWithValue("@sec", txtSecretary.Text);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
                MessageBox.Show("Club Info Updated Successful");
            else
                MessageBox.Show("Unable to Update");

            con.Close();

            UpdateListBox();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterClub regForm = new RegisterClub();
            regForm.ShowDialog();

            UpdateListBox();
        }

        private void AdminClubManagement_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void lstClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClub = lstClubs.GetItemText(lstClubs.SelectedItem);
            txtName.Text = selectedClub;

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select registrationDate from Club where clubName='" + selectedClub + "'", con);
            SqlDataReader readDate = cmd1.ExecuteReader();
            readDate.Read();
            txtDate.Text = readDate.GetDateTime(0).ToString().Remove(11);
            con.Close();

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select description from Club where clubName='" + selectedClub + "'", con);
            SqlDataReader readDesc = cmd2.ExecuteReader();
            readDesc.Read();
            txtDescription.Text = readDesc.GetString(0);
            con.Close();

            con.Open();
            SqlCommand cmd3 = new SqlCommand("select president from Club where clubName='" + selectedClub + "'", con);
            SqlDataReader readPres = cmd3.ExecuteReader();
            readPres.Read();
            txtPresident.Text = readPres.GetString(0);
            con.Close();

            con.Open();
            SqlCommand cmd4 = new SqlCommand("select vicePresident from Club where clubName='" + selectedClub + "'", con);
            SqlDataReader readVPres = cmd4.ExecuteReader();
            readVPres.Read();
            txtVPresident.Text = readVPres.GetString(0);
            con.Close();

            con.Open();
            SqlCommand cmd5 = new SqlCommand("select secretary from Club where clubName='" + selectedClub + "'", con);
            SqlDataReader readSec = cmd5.ExecuteReader();
            readSec.Read();
            txtSecretary.Text = readSec.GetString(0);
            con.Close();

            btnSave.Enabled = true;
            btnArchive.Enabled = true;
        }

        private void UpdateListBox()
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
