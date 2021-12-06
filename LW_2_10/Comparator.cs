using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    public class Comparator : IComparer
    {
        public int Compare(object x, object y)
        {
            Organization org1 = (Organization)x;
            Organization org2 = (Organization)y;

            int res = string.Compare(org1.Name, org2.Name);
            return res;
        }
    }
}
