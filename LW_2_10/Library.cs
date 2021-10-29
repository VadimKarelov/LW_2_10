using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class Library : Organization
    {
        public int NumberOfBooks
        {
            get
            {
                return NumberOfBooks;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Number of books must be positive");
            }
        }

        public Library(string name, string locationCity, int numOfBooks) : base(name, locationCity)
        {
            NumberOfBooks = numOfBooks;
        }
    }
}
