using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace LeetCodeTests
{
    [TestClass]
    public class PrintFooBarAlternativelyTests
    {
        [TestMethod]
        public void PrintFooBarAlternativelyTest1()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.PrintFooBarAlternatively.FooBar(1);
                Thread.Sleep(500);
                string expected = string.Format("foobar");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintFooBarAlternativelyTest2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.PrintFooBarAlternatively.FooBar(10);
                Thread.Sleep(500);

                string expected = string.Format("foobarfoobarfoobarfoobarfoobarfoobarfoobarfoobarfoobarfoobar");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }
    }
}