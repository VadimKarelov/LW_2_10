using System;
using System.Collections.Generic;

namespace LW_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static private void Task1()
        {
            List<object> someList = new();
            someList.Add(new Organization("Simple organization", "Magadan"));
            someList.Add(new ShipConstructingCompany("TopBoats", "Ekaterinburg"));
            someList.Add(new InsuranceCompany("No money - no problem", "Vladivostok", 100));
            someList.Add(new Factory("Future", "Vladimir", "Wood"));
            someList.Add(new Library("Biblia", "Alexandriysk", 0));

            foreach (var elem in someList)
            {
                if (elem is Organization org)
                {
                    Console.WriteLine(org.Print());
                }
            }
        }
    }
}
