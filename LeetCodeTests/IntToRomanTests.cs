using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    [TestClass]
    public class IntToRomanTests
    {
        [TestMethod]
        public void IntToRomanExampleTest1()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.IntToRoman(3);

            Assert.AreEqual("III", result);
        }

        [TestMethod]
        public void IntToRomanExampleTest2()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.IntToRoman(58);

            Assert.AreEqual("LVIII", result);
        }

        [TestMethod]
        public void IntToRomanExampleTest3()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.IntToRoman(1994);

            Assert.AreEqual("MCMXCIV", result);
        }

        [TestMethod]
        public void IntToRomanLeadingZeroesTest3()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.IntToRoman(01994);

            Assert.AreEqual("MCMXCIV", result);
        }
    }

}