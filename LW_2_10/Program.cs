using System;
using System.Collections.Generic;
using System.Linq;

namespace LW_2_10
{
    class Program
    {
        private static Random rn = new();

        static void Main(string[] args)
        {
            Task1();
            Console.ReadKey();
            Console.Clear();
            Task2();
            Console.ReadKey();
            Console.Clear();
            Task3();
        }

        static private void PrintOrganizations(List<Organization> organizations)
        {
            foreach (var org in organizations)
            {
                Console.WriteLine(org.Print());
            }
        }

        static private void PrintOrganizations(List<IExecutable> organizations)
        {
            foreach (var org in organizations)
            {
                Console.WriteLine(org.Print());
            }
        }

        static private void Task1()
        {
            Console.WriteLine("//////////////////Task 1");

            List<Organization> someList = new();
            someList.Add(new Organization("Simple organization", "Magadan"));
            someList.Add(new ShipConstructingCompany("TopBoats", "Ekaterinburg"));
            someList.Add(new InsuranceCompany("No money - no problem", "Vladivostok", 100));
            someList.Add(new Factory("Future", "Vladimir", "Wood"));
            someList.Add(new Library("Biblia", "Alexandriysk", 0));

            PrintOrganizations(someList);
        }

        static private void Task2()
        {
            Console.WriteLine("//////////////////Task 2");

            List<Organization> someList = new();

            for (int i = 0; i < 5; i++)
                someList.Add(new Organization(ref rn));
            for (int i = 0; i < 5; i++)
                someList.Add(new ShipConstructingCompany(ref rn));
            for (int i = 0; i < 5; i++)
                someList.Add(new InsuranceCompany(ref rn));
            for (int i = 0; i < 5; i++)
                someList.Add(new Factory(ref rn));
            for (int i = 0; i < 5; i++)
                someList.Add(new Library(ref rn));

            Console.WriteLine("===Cписок всех организаций");
            PrintOrganizations(someList);

            Console.WriteLine("===Список организаций из Магадана");
            PrintOrganizations(Request1(someList));

            Console.WriteLine("===Список библиотек, где количество книг больше 50");
            PrintOrganizations(Request2(someList));

            Console.WriteLine("===Список заводов из Москвы");
            PrintOrganizations(Request3(someList));
        }

        static private List<Organization> Request1(List<Organization> organizations)
        {
            // вывести все организации из Магадана
            List<Organization> res = new();
            foreach (var elem in organizations)
            {
                if (elem.City == "Magadan")
                {
                    res.Add(elem);
                }
            }
            return res;
        }

        static private List<Organization> Request2(List<Organization> organizations)
        {
            // вывести список библиотек, с количеством книг > 50
            List<Organization> res = new();
            foreach (var elem in organizations)
            {
                if (elem is Library lb && lb.NumberOfBooks > 50)
                {
                    res.Add(elem);
                }
            }
            return res;
        }

        static private List<Organization> Request3(List<Organization> organizations)
        {
            // вывести заводы из Москвы
            List<Organization> res = new();
            foreach (var elem in organizations)
            {
                if (elem is Factory fact && fact.City == "Moscow")
                {
                    res.Add(elem);
                }
            }
            return res;
        }

        static private void Task3()
        {
            Console.WriteLine("//////////////////Task 3");

            List<IExecutable> someList = new();

            for (int i = 0; i < 3; i++)
                someList.Add(new Organization(ref rn));
            for (int i = 0; i < 3; i++)
                someList.Add(new ShipConstructingCompany(ref rn));
            for (int i = 0; i < 3; i++)
                someList.Add(new InsuranceCompany(ref rn));
            for (int i = 0; i < 3; i++)
                someList.Add(new Factory(ref rn));
            for (int i = 0; i < 3; i++)
                someList.Add(new Library(ref rn));

            Console.WriteLine("===Before sort");
            PrintOrganizations(someList);
            IExecutable[] someArray = someList.ToArray();
            Array.Sort(someArray, new Comparator());
            someList = someArray.ToList();
            Console.WriteLine("===After sort");
            PrintOrganizations(someList);

            Console.WriteLine("Find organisation with name Bravo");
            Console.WriteLine(someArray[Array.BinarySearch(someArray, new Organization("Bravo", ""), new Comparator())].Print());

            Console.WriteLine("===Copying");
            Factory t1 = new Factory("Factory1", "Perm", "Product 1")
            {
                HeadOrganization = new Organization(ref rn)
            };
            Console.WriteLine("**Copy first factory to second");
            Factory t2 = t1.Clone();

            Console.WriteLine(t1.Print());
            Console.WriteLine(t2.Print());

            Console.WriteLine("**Changed all information in first factory");
            t1.Name = "Factory 2";
            t1.City = "Moscow";
            t1.Production = "Product 2";
            t1.HeadOrganization.Name = "New head org name";

            Console.WriteLine(t1.Print());
            Console.WriteLine(t2.Print());

            Console.WriteLine("**Deep clone first factory to second");
            t2 = t1.DeepClone();

            Console.WriteLine(t1.Print());
            Console.WriteLine(t2.Print());

            Console.WriteLine("**Changed all information in first factory");
            t1.Name = "Factory 3";
            t1.City = "Vladivostok";
            t1.Production = "Product 3";
            t1.HeadOrganization.Name = "Another new head org name";

            Console.WriteLine(t1.Print());
            Console.WriteLine(t2.Print());
        }
    }
}
