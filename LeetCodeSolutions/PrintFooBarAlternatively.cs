using Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks; // not required on leetcode

namespace LeetCodeSolutions
{
    public class PrintFooBarAlternatively
    {


        //1115. Print FooBar Alternately
        public class FooBar
        {
            private int n;
            private Action printFoo = () => { Console.Write("foo"); }; // not required on leetcode
            private Action printBar = () => { Console.Write("bar"); }; // not required on leetcode
            private static AutoResetEvent printFooEvent = new AutoResetEvent(true);
            private static AutoResetEvent printBarEvent = new AutoResetEvent(false);

            public FooBar(int n)
            {
                this.n = n;
                Task.Factory.StartNew(() => Foo(printFoo)); // not required on leetcode
                Task.Factory.StartNew(() => Bar(printBar)); // not required on leetcode
            }

            public void Foo(Action printFoo)
            {

                for (int i = 0; i < n; i++)
                {
                    printFooEvent.WaitOne();
                    // printFoo() outputs "foo". Do not change or remove this line.
                    printFoo();
                    printBarEvent.Set();
                }
            }

            public void Bar(Action printBar)
            {

                for (int i = 0; i < n; i++)
                {
                    printBarEvent.WaitOne();
                    // printBar() outputs "bar". Do not change or remove this line.
                    printBar();
                    printFooEvent.Set();
                }
            }
        }

    }
}
