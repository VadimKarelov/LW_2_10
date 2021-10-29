using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class ShipConstructingCompany : Organization
    {
        public int ShipConstructed
        {
            get
            {
                return ShipConstructed;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Number of constructed ship must be positive");
                ShipConstructed = value;
            }
        }

        public ShipConstructingCompany(string name, string locationCity) : base(name, locationCity)
        {
            ShipConstructed = 0;
        }
    }
}
