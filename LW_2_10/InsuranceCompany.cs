using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class InsuranceCompany : Organization
    {
        public int NumberOfClients { get; set; }

        public InsuranceCompany(string name, string locationCity, int numOfClients) : base(name, locationCity)
        {
            NumberOfClients = numOfClients;
        }

        public InsuranceCompany(ref Random rn) : base(ref rn)
        {
            NumberOfClients = rn.Next(0, 100);
        }

        public override string Print()
        {
            string res = base.Print();
            res += $"Number of clients: {NumberOfClients}\n";
            return res;
        }
    }
}
