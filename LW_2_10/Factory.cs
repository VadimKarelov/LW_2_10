using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class Factory : Organization
    {
        public string Production { get; set; }

        public Factory(string name, string locationCity, string production) : base(name, locationCity)
        {
            Production = production;
        }

        public Factory(ref Random rn) : base(ref rn)
        {
            string[] products = { "Phones", "Tables", "Chairs", "Lamps" };
            Production = products[rn.Next(0, products.Length)];
        }

        public override string Print()
        {
            string res = base.Print();
            res += $"Type of production: {Production}\n";
            return res;
        }
    }
}
