using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    public class DevTeamRepo
    {
        protected readonly List<DevTeam> _devteamDirectory = new List<DevTeam>();

        //Create
        public bool AddDevTeamToDirectory(DevTeam newDevTeam)
        {
            int startingCount = _devteamDirectory.Count;
            _devteamDirectory.Add(newDevTeam);
            bool wasAdded = (_devteamDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read
        public List<DevTeam> GetDevTeams()
        {
            return _devteamDirectory;
        }
        public DevTeam getDevTeamByTeamID(int teamID)
        {
            foreach (DevTeam devTeam in _devteamDirectory)
            {
                if (devTeam.TeamID == teamID)
                {
                    return devTeam;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingDevTeam(int originalTeamID, DevTeam newDevTeam)
        {
            DevTeam olddevTeam = getDevTeamByTeamID(originalTeamID);
            if (olddevTeam != null)
            {
                olddevTeam.TeamID = newDevTeam.TeamID;
                olddevTeam.TeamName = newDevTeam.TeamName;
                olddevTeam.Developer = newDevTeam.Developer;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
        public bool DeleteExistingDevTeam(DevTeam existingDevTeam)
        {
            bool deleteResult = _devteamDirectory.Remove(existingDevTeam);
            return deleteResult;
        }
    }
}
