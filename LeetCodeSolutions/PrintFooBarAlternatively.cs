using Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class PrintFooBarAlternatively
    {


        //1115. Print FooBar Alternately
        public class FooBar
        {
            private int n;
            private Action printFoo = () => { Console.Write("foo"); };
            private Action printBar = () => { Console.Write("bar"); };
            //private static AutoResetEvent printFooBool = new AutoResetEvent(true);
            private static AutoResetEvent print = new AutoResetEvent(true);

            public FooBar(int n)
            {
                this.n = n;
                Task.Factory.StartNew(() => Foo(printFoo));
                Task.Factory.StartNew(() => Bar(printBar));
            }

            public void Foo(Action printFoo)
            {

                for (int i = 0; i < n; i++)
                {
                    print.WaitOne();
                    // printFoo() outputs "foo". Do not change or remove this line.
                    printFoo();
                    print.Set();
                }
            }

            public void Bar(Action printBar)
            {

                for (int i = 0; i < n; i++)
                {
                    print.WaitOne();
                    // printBar() outputs "bar". Do not change or remove this line.
                    printBar();
                    print.Set();
                }
            }
        }

    }
}
