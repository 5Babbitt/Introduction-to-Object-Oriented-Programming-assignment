using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group_11.Classes
{
    class User
    {
        private string username;
        private string password;
        private string role;

        public User(string u, string p)
        {
            Username = u;
            Password = p;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
