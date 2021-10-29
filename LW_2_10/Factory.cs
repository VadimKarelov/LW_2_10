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
    }
}
