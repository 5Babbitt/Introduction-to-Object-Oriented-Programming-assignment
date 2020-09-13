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
    public partial class LoginMenu : Form
    {
        SqlConnection link = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User details = new User(txtUser.Text, txtPassword.Text);
            link.Open();
            SqlCommand check = new SqlCommand("select count(*) from Users where username='"+details.Username+"' and password='"+details.Password+"'", link);
            
            int count = Convert.ToInt32(check.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand roleCheck = new SqlCommand("select role from Users where username='" + details.Username + "'", link);
                string userRole = roleCheck.ExecuteScalar().ToString();
                if (userRole == "admin")
                {
                    AdminMenu a = new AdminMenu();
                    a.ShowDialog();
                }
                else if (userRole == "student")
                {
                    StudentMenu s = new StudentMenu();
                    s.ShowDialog();
                }
                else if (userRole == "club")
                {
                    ClubRepMenu c = new ClubRepMenu(txtUser.Text);
                    c.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            
            link.Close();

        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
