using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    public class DevTeam
    {
        //Developers
        public string Developer { get; set; }
        //Team Name
        public string TeamName { get; set; }
        //Team ID
        public int TeamID { get; set; }
        public DevTeam(string developer, string teamName, int teamID)
        {
            Developer = developer;
            TeamName = teamName;
            TeamID = teamID;
        }
    }
}
