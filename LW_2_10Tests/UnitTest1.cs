using Microsoft.VisualStudio.TestTools.UnitTesting;
using LW_2_10;

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
    }
}
