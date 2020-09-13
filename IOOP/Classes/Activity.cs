using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP.Classes
{
    class Activity
    {
        private string clubName;
        private DateTime dateEntry;
        private string description;

        public Activity(string n, DateTime d, string des)
        {
            ClubName = n;
            DateEntry = d;
            Description = des;
        }

        public string ClubName { get => clubName; set => clubName = value; }
        public DateTime DateEntry { get => dateEntry; set => dateEntry = value; }
        public string Description { get => description; set => description = value; }
    }
}
