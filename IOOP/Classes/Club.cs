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
        private string clubRegDate;
        private string clubDesc;
        private string clubPres;
        private string clubVPres;
        private string clubSec;

        public Club(string n, string rd, string d, string p, string vp, string s)
        {
            clubName = n;
            clubRegDate = rd;
            clubDesc = d;
            clubPres = p;
            clubVPres = vp;
            clubSec = s;
        }

        public void UpdateClubDesc(string d)
        {
            clubDesc = d;
        }


    }
}
