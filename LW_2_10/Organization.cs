using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class Organization
    {
        public string Name { get; set; }
        public string City { get; set; }

        public Organization(string name, string locationCity)
        {
            Name = name;
            City = locationCity;
        }

        public virtual string Print()
        {
            string res = "";
            res += "Organisation name: " + Name + "\n";
            res += "Location city: " + City + "\n";
            return res;
        }
    }
}
