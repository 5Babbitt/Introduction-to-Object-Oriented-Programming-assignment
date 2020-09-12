using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group_11.Classes
{
    class Club
    {
        private string clubName;
        private DateTime clubRegDate;
        private string clubDesc;
        private string clubPres;
        private string clubVPres;
        private string clubSec;

        public Club(string n, DateTime date, string d, string p, string vp, string s)
        {
            ClubName = n;
            ClubRegDate = date;
            ClubDesc = d;
            ClubPres = p;
            ClubVPres = vp;
            ClubSec = s;
        }

        public string ClubName { get => clubName; set => clubName = value; }
        public DateTime ClubRegDate { get => clubRegDate; set => clubRegDate = value; }
        public string ClubDesc { get => clubDesc; set => clubDesc = value; }
        public string ClubPres { get => clubPres; set => clubPres = value; }
        public string ClubVPres { get => clubVPres; set => clubVPres = value; }
        public string ClubSec { get => clubSec; set => clubSec = value; }

        public void UpdateClubDesc(string d)
        {
            ClubDesc = d;
        }


    }
}
