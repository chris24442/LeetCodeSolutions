using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace LeetCodeTests
{
    [TestClass]
    public class PrintZeroEvenOddTests
    {
        [TestMethod]
        public void PrintZeroEvenOddTest1()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.ZeroEvenOdd(2);
                Thread.Sleep(500);
                string expected = string.Format("0102");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintZeroEvenOddTest2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.ZeroEvenOdd(5);
                Thread.Sleep(500);
                string expected = string.Format("0102030405");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintZeroEvenOddTest3()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.ZeroEvenOdd(7);
                Thread.Sleep(500);
                string expected = string.Format("01020304050607");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintZeroEvenOddTest4()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.ZeroEvenOdd(2);
                Thread.Sleep(500);
                string expected = string.Format("0102");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintZeroEvenOddTest5()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.ZeroEvenOdd(1);
                Thread.Sleep(500);
                string expected = string.Format("01");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

    }
}