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
        Action doWorkA = () => { Console.Write("First"); };
        Action doWorkB = () => { Console.Write("Second"); };
        Action doWorkC = () => { Console.Write("Third"); };

        [TestMethod]
        public void PrintFooBarAlternativelyTest1()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.PrintFooBarAlternatively.FooBar(2);

                string expected = string.Format("FooBar");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintFooBarAlternativelyTest2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.PrintFooBarAlternatively.FooBar(2);
                Thread.Sleep(50);

                string expected = string.Format("FooBar");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }
        [TestMethod]
        public void PrintFooBarAlternativelyTest3()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.PrintFooBarAlternatively.FooBar(5);
                Thread.Sleep(500);

                string expected = string.Format("FooBarFooBarFoo");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }
    }
}