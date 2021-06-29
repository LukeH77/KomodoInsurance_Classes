using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    public class DeveloperRepo
    {
        protected readonly List<Developer> _devloperDirectory = new List<Developer>();

        //Create
        public bool AddDeveloperToDirectory(Developer newDeveloper)
        {
            int startingCount = _devloperDirectory.Count;
            _devloperDirectory.Add(newDeveloper);
            bool wasAdded = (_devloperDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read
        public List<Developer> GetDevelopers()
        {
            return _devloperDirectory;
        }
        public Developer getDeveloperByIDNumber(int idNumber)
        {
            foreach (Developer developer in _devloperDirectory)
            {
                if (developer.IDNumber == idNumber)
                {
                    return developer;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingDeveloper(int originalIDNumber, Developer newDeveloper)
        {
            Developer olddeveloper = getDeveloperByIDNumber(originalIDNumber);
            if (olddeveloper != null)
            {
                olddeveloper.IDNumber = newDeveloper.IDNumber;
                olddeveloper.Name = newDeveloper.Name;
                olddeveloper.PluralSight = newDeveloper.PluralSight;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
        public bool DeleteExistingDeveloper(Developer existingDeveloper)
        {
            bool deleteResult = _devloperDirectory.Remove(existingDeveloper);
            return deleteResult;
        }
    }
}
