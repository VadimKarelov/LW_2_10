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

        public Organization(ref Random rn)
        {
            string[] names = { "Alpha", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel" };
            string[] cities = { "Magadan", "Arhangelsk", "Sochi", "Moscow", "Omsk" };
            Name = names[rn.Next(0, names.Length)];
            City = cities[rn.Next(0, cities.Length)];
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
