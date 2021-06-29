using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    public class Developer
    {
        //ID Number
        public int IDNumber { get; set; }
        //Name
        public string Name { get; set; }
        //PluralSight Access
        public bool PluralSight { get; set; }
        public Developer(int idNumber, string name, bool pluralSight)
        {
            IDNumber = idNumber;
            Name = name;
            PluralSight = pluralSight;
        }
    }
}
