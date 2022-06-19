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

        [TestMethod]
        public void NumberToWordsErrorTest1()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.NumberToWords(0);

            Assert.AreEqual("Zero", result);
        }

        [TestMethod]
        public void NumberToWordsErrorTest2()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.NumberToWords(100);

            Assert.AreEqual("One Hundred", result);
        }

        [TestMethod]
        public void NumberToWordsErrorTest3()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.NumberToWords(1000);

            Assert.AreEqual("One Thousand", result);
        }

        [TestMethod]
        public void NumberToWordsErrorTest4()
        {
            var program = new LeetCodeSolutions.Program();

            string result = program.NumberToWords(1000000);

            Assert.AreEqual("One Million", result);
        }
    }
}