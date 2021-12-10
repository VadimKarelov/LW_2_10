using Microsoft.VisualStudio.TestTools.UnitTesting;
using LW_2_10;
using System;

namespace LW_2_10Tests
{
    [TestClass]
    public class UnitTest1
    {
        // === class Organization ===
        [TestMethod]
        public void TestConstructor()
        {
            Organization actual = new("HH", "Perm");

            Assert.AreEqual(actual, actual);
        }

        [TestMethod]
        public void TestPrint()
        {
            Organization org = new("HH", "Perm");
            string actual = org.Print();

            string expected = "Organisation name: HH\nLocation city: Perm\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompareTo_null()
        {
            Organization org = new("HH", "Perm");
            int actual = org.CompareTo(null);

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompareTo_equal()
        {
            Organization org = new Organization("HH", "Perm");
            int actual = org.CompareTo(new Organization("HH", "Perm"));

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompareTo_more()
        {
            Organization org = new Organization("HH", "Perm");
            int actual = org.CompareTo(new Organization("SH", "Saratov"));

            int expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCompareTo_less()
        {
            Organization org = new Organization("HH", "Perm");
            int actual = org.CompareTo(new Organization("AH", "Anapa"));

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestClone()
        {
            Organization org = new("HH", "Perm");
            Organization actual = (Organization)org.Clone();

            Assert.AreEqual(-1, org.CompareTo(actual));
        }

        // === class Factory ===

        [TestMethod]
        public void Factory_ConstructorTest()
        {
            Factory actual = new Factory("HH", "HH", "HH");

            Assert.AreEqual(actual, actual);
        }

        [TestMethod]
        public void Factory_PrintTest()
        {
            Factory f = new Factory("HH", "Perm", "HH");
            string actual = f.Print();

            string expected = "Organisation name: HH\nLocation city: Perm\nType of production: HH\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factory_TestCompareTo_null()
        {
            Random rn = new Random();
            Factory org = new(ref rn);
            int actual = org.CompareTo(null);

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factory_TestCompareTo_equal()
        {
            Factory org = new("HH", "Perm", "HH"); 
            int actual = org.CompareTo(new Organization("HH", "Perm"));

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factory_TestCompareTo_more()
        {
            Factory org = new("HH", "Perm", "HH");
            int actual = org.CompareTo(new Factory("AA", "Perm", "HH"));

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factory_TestCompareTo_less()
        {
            Factory org = new("HH", "Perm", "HH");
            int actual = org.CompareTo(new Factory("ZZ", "Perm", "HH"));

            int expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factory_TestClone()
        {
            Factory org = new("HH", "Perm", "HH");
            var actual = org.Clone();

            Assert.AreEqual(-1, org.CompareTo(actual));
        }

        [TestMethod]
        public void Factory_TestDeepClone()
        {
            Factory org = new("HH", "Perm", "HH");
            Random rnd = new Random();
            org.HeadOrganization = new(ref rnd);
            var actual = org.DeepClone();

            Assert.AreEqual(-1, org.CompareTo(actual));
        }

        // === class ShipConstructingCompany ===
        [TestMethod]
        public void Ship_PrintTest()
        {
            var f = new ShipConstructingCompany("HH", "Perm");
            string actual = f.Print();

            string expected = "Organisation name: HH\nLocation city: Perm\nNumber of constructed ships: 0\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ship_TestCompareTo_null()
        {
            Random rn = new Random();
            ShipConstructingCompany org = new(ref rn);
            int actual = org.CompareTo(null);

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ship_TestCompareTo_equal()
        {
            ShipConstructingCompany org = new("HH", "Perm");
            int actual = org.CompareTo(new Organization("HH", "Perm"));

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ship_TestCompareTo_more()
        {
            ShipConstructingCompany org = new("HH", "Perm");
            org.ShipConstructed--;
            int actual = org.CompareTo(new ShipConstructingCompany("AA", "Perm"));

            int expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ship_TestCompareTo_less()
        {
            ShipConstructingCompany org = new("HH", "Perm");
            org.ShipConstructed++;
            int actual = org.CompareTo(new ShipConstructingCompany("ZZ", "Perm"));

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Ship_TestClone()
        {
            ShipConstructingCompany org = new("HH", "Perm");
            var actual = org.Clone();

            Assert.AreEqual(0, org.CompareTo(actual));
        }

        // === class InsuranceCompany ===
        [TestMethod]
        public void Insurance_PrintTest()
        {
            var f = new InsuranceCompany("HH", "Perm", 100);
            string actual = f.Print();

            string expected = "Organisation name: HH\nLocation city: Perm\nNumber of clients: 100\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insurance_TestCompareTo_null()
        {
            Random rn = new Random();
            InsuranceCompany org = new InsuranceCompany(ref rn);
            int actual = org.CompareTo(null);

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insurance_TestCompareTo_equal()
        {
            InsuranceCompany org = new InsuranceCompany("HH", "Perm", 100);
            int actual = org.CompareTo(new InsuranceCompany("HH", "Perm", 100));

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insurance_TestCompareTo_more()
        {
            InsuranceCompany org = new InsuranceCompany("HH", "Perm", 100);
            int actual = org.CompareTo(new InsuranceCompany("HH", "Perm", 1000));

            int expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insurance_TestCompareTo_less()
        {
            InsuranceCompany org = new InsuranceCompany("HH", "Perm", 100);
            int actual = org.CompareTo(new InsuranceCompany("HH", "Perm", 10));

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insurance_TestCompareTo_other()
        {
            InsuranceCompany org = new InsuranceCompany("HH", "Perm", 100);
            int actual = org.CompareTo(new Organization("HH", "Perm"));

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Insurance_TestClone()
        {
            InsuranceCompany org = new InsuranceCompany("HH", "Perm", 100);
            var actual = org.Clone();

            Assert.AreEqual(0, org.CompareTo(actual));
        }

        // === class Library ===
        [TestMethod]
        public void Library_PrintTest()
        {
            var f = new Library("HH", "Perm", 100);
            string actual = f.Print();

            string expected = "Organisation name: HH\nLocation city: Perm\nNumber of books: 100\n";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Library_TestCompareTo_null()
        {
            Random rn = new Random();
            Library org = new Library(ref rn);
            int actual = org.CompareTo(null);

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Library_TestCompareTo_equal()
        {
            Library org = new Library("HH", "Perm", 100);
            int actual = org.CompareTo(new Library("HH", "Perm", 100));

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Library_TestCompareTo_more()
        {
            Library org = new Library("HH", "Perm", 100);
            int actual = org.CompareTo(new Library("HH", "Perm", 1000));

            int expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Library_TestCompareTo_less()
        {
            Library org = new Library("HH", "Perm", 100);
            int actual = org.CompareTo(new Library("HH", "Perm", 10));

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Library_TestCompareTo_other()
        {
            Library org = new Library("HH", "Perm", 100);
            int actual = org.CompareTo(new Organization("HH", "Perm"));

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Library_TestClone()
        {
            Library org = new Library("HH", "Perm", 100);
            var actual = org.Clone();

            Assert.AreEqual(0, org.CompareTo(actual));
        }

        // === other classes ===
        [TestMethod]
        public void ComparatorTest()
        {
            var comp = new Comparator();

            var actual = comp.Compare(new Organization("a", "a"), new Organization("a", "a"));

            Assert.AreEqual(0, actual);
        }
    }
}
