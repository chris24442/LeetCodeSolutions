using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RomanToIntExampleTest1()
        {
            var program = new LeetCodeSolutions.Program();

            int result = program.RomanToInt("III");

            Assert.AreEqual(3,result);
        }

        [TestMethod]
        public void RomanToIntExampleTest2()
        {
            var program = new LeetCodeSolutions.Program();

            int result = program.RomanToInt("LVIII");

            Assert.AreEqual(58, result);
        }

        [TestMethod]
        public void RomanToIntExampleTest3()
        {
            var program = new LeetCodeSolutions.Program();

            int result = program.RomanToInt("MCMXCIV");

            Assert.AreEqual(1994, result);
        }

        [TestMethod]
        public void RomanToIntEmptyTest()
        {
            var program = new LeetCodeSolutions.Program();

            int result = program.RomanToInt("");

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void RomanToIntUpToTenTest()
        {
            var program = new LeetCodeSolutions.Program();

            Assert.AreEqual(1, program.RomanToInt("I"));
            Assert.AreEqual(2, program.RomanToInt("II"));
            Assert.AreEqual(3, program.RomanToInt("III"));
            Assert.AreEqual(4, program.RomanToInt("IV"));
            Assert.AreEqual(5, program.RomanToInt("V"));
            Assert.AreEqual(6, program.RomanToInt("VI"));
            Assert.AreEqual(7, program.RomanToInt("VII"));
            Assert.AreEqual(8, program.RomanToInt("VIII"));
            Assert.AreEqual(9, program.RomanToInt("IX"));
            Assert.AreEqual(10, program.RomanToInt("X"));
        }

        [TestMethod]
        public void RomanToIntUpTo20Test()
        {
            var program = new LeetCodeSolutions.Program();

            Assert.AreEqual(11, program.RomanToInt("XI"));
            Assert.AreEqual(12, program.RomanToInt("XII"));
            Assert.AreEqual(13, program.RomanToInt("XIII"));
            Assert.AreEqual(14, program.RomanToInt("XIV"));
            Assert.AreEqual(15, program.RomanToInt("XV"));
            Assert.AreEqual(16, program.RomanToInt("XVI"));
            Assert.AreEqual(17, program.RomanToInt("XVII"));
            Assert.AreEqual(18, program.RomanToInt("XVIII"));
            Assert.AreEqual(19, program.RomanToInt("XIX"));
            Assert.AreEqual(20, program.RomanToInt("XX"));
        }

        [TestMethod]
        public void RomanToIntUpTo100Test()
        {
            var program = new LeetCodeSolutions.Program();

            Assert.AreEqual(21, program.RomanToInt("XXI"));
            Assert.AreEqual(22, program.RomanToInt("XXII"));
            Assert.AreEqual(23, program.RomanToInt("XXIII"));
            Assert.AreEqual(24, program.RomanToInt("XXIV"));
            Assert.AreEqual(30, program.RomanToInt("XXX"));
            Assert.AreEqual(40, program.RomanToInt("XL"));
            Assert.AreEqual(50, program.RomanToInt("L"));
            Assert.AreEqual(60, program.RomanToInt("LX"));
            Assert.AreEqual(70, program.RomanToInt("LXX"));
            Assert.AreEqual(80, program.RomanToInt("LXXX"));
            Assert.AreEqual(90, program.RomanToInt("XC"));
            Assert.AreEqual(100, program.RomanToInt("C"));
        }

        [TestMethod]
        public void RomanToIntUpTo1000Test()
        {
            var program = new LeetCodeSolutions.Program();

            Assert.AreEqual(101, program.RomanToInt("CI"));
            Assert.AreEqual(102, program.RomanToInt("CII"));
            Assert.AreEqual(200, program.RomanToInt("CC"));
            Assert.AreEqual(300, program.RomanToInt("CCC"));
            Assert.AreEqual(400, program.RomanToInt("CD"));
            Assert.AreEqual(500, program.RomanToInt("D"));
            Assert.AreEqual(600, program.RomanToInt("DC"));
            Assert.AreEqual(700, program.RomanToInt("DCC"));
            Assert.AreEqual(800, program.RomanToInt("DCCC"));
            Assert.AreEqual(900, program.RomanToInt("CM"));
            Assert.AreEqual(1000, program.RomanToInt("M"));
        }

        [TestMethod]
        public void RomanToIntUpTo5000Test()
        {
            var program = new LeetCodeSolutions.Program();

            Assert.AreEqual(1001, program.RomanToInt("MI"));
            Assert.AreEqual(1002, program.RomanToInt("MII"));
            Assert.AreEqual(1003, program.RomanToInt("MIII"));
            Assert.AreEqual(1900, program.RomanToInt("MCM"));
            Assert.AreEqual(2000, program.RomanToInt("MM"));
            Assert.AreEqual(2001, program.RomanToInt("MMI"));
            Assert.AreEqual(2002, program.RomanToInt("MMII"));
            Assert.AreEqual(2100, program.RomanToInt("MMC"));
            Assert.AreEqual(4000, program.RomanToInt("MMM"));
            Assert.AreEqual(4000, program.RomanToInt("MV"));
            Assert.AreEqual(5000, program.RomanToInt("V"));
        }
    }
}