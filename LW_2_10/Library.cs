﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_2_10
{
    class Library : Organization
    {
        public int NumberOfBooks { get; set; }

        public Library(string name, string locationCity, int numOfBooks) : base(name, locationCity)
        {
            NumberOfBooks = numOfBooks;
        }

        public override string Print()
        {
            string res = base.Print();
            res += $"Number of books: {NumberOfBooks}\n";
            return res;
        }
    }
}
