using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class ShipConstructingCompany : Organization
    {
        public int ShipConstructed { get; set; }

        public ShipConstructingCompany(string name, string locationCity) : base(name, locationCity)
        {
            ShipConstructed = 0;
        }

        public ShipConstructingCompany(ref Random rn) : base(ref rn)
        {
            ShipConstructed = rn.Next(0, 1000);
        }

        public override string Print()
        {
            string res = base.Print();
            res += $"Number of constructed ships: {ShipConstructed}\n";
            return res;
        }
    }
}
