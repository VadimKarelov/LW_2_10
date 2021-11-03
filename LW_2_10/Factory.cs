using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class Factory : Organization, IComparable, IComparer, ICloneable
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

        public new int CompareTo(object obj)
        {
            if (obj == null) return 1;

            var org = obj as Factory;
            if (org == null || org != null && this == org)
                return 0;
            else
                return this.Name.CompareTo(org.Name);
        }

        public new int Compare(object x, object y)
        {
            if (x == y) return 0;

            if (x is Factory o1 && y is Factory o2)
                return o1.CompareTo(o2);
            else
                return 0;
        }

        public new object Clone()
        {
            return this;
        }
    }
}
