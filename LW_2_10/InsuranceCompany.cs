using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class InsuranceCompany : Organization
    {
        public int NumberOfClients
        {
            get
            {
                return NumberOfClients;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Number of clients must be positive");
                NumberOfClients = value;
            }
        }

        public InsuranceCompany(string name, string locationCity, int numOfClients) : base(name, locationCity)
        {
            NumberOfClients = numOfClients;
        }
    }
}
