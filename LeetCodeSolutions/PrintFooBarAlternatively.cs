using Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LeetCodeSolutions
{
    public class PrintFooBarAlternatively
    {

        //1115. Print FooBar Alternately
        public class FooBar
        {
            private int n;

            public FooBar(int n)
            {
                this.n = n;
            }

            public void Foo(Action printFoo)
            {

                for (int i = 0; i < n; i++)
                {

                    // printFoo() outputs "foo". Do not change or remove this line.
                    printFoo();
                }
            }

            public void Bar(Action printBar)
            {

                for (int i = 0; i < n; i++)
                {

                    // printBar() outputs "bar". Do not change or remove this line.
                    printBar();
                }
            }
        }

    }
}
