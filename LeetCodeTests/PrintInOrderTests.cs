using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;
using System;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace LeetCodeTests
{
    [TestClass]
    public class PrintInOrderTests
    {
        Action doWorkA = () => { Console.Write("First"); };
        Action doWorkB = () => { Console.Write("Second"); };
        Action doWorkC = () => { Console.Write("Third"); };

        [TestMethod]
        public void PrintInOrderExampleTest1()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.Concurrency19JUNE2022.Foo();

                Task.Factory.StartNew(() => a.First(doWorkA));
                Task.Factory.StartNew(() => a.Second(doWorkB));
                Thread.Sleep(50);
                Task.Factory.StartNew(() => a.Third(doWorkC));
                Thread.Sleep(50);

                string expected = string.Format("FirstSecondThird");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }

        [TestMethod]
        public void PrintInOrderExampleTest2()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                var a = new LeetCodeSolutions.Concurrency19JUNE2022.Foo();

                Task.Factory.StartNew(() => a.First(doWorkA));
                Task.Factory.StartNew(() => a.Third(doWorkC));
                Thread.Sleep(50);
                Task.Factory.StartNew(() => a.Second(doWorkB));
                Thread.Sleep(50);

                string expected = string.Format("FirstSecondThird");
                Assert.AreEqual<string>(expected, sw.ToString());
            }
        }
    }
}