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
    }
}