using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;

namespace LeetCodeTests
{
    [TestClass]
    public class NumberToWordsTests
    {
        [TestMethod]
        public void NumberToWordsExampleTest1()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.NumberToWords(123);

            Assert.AreEqual("One Hundred Twenty Three", result);
        }

        [TestMethod]
        public void NumberToWordsExampleTest2()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.NumberToWords(12345);

            Assert.AreEqual("Twelve Thousand Three Hundred Forty Five", result);
        }


        [TestMethod]
        public void NumberToWordsExampleTest3()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.NumberToWords(1234567);

            Assert.AreEqual("One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven", result);
        }
    }
}