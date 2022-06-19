using Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LeetCodeSolutions
{
    public class Concurrency19JUNE2022
    {

        // 1114. Print in Order

        public class Foo
        {
            // https://docs.microsoft.com/en-us/dotnet/api/system.threading.autoresetevent?view=net-6.0
            // true is the signalled state, false is unsignalled
            private static AutoResetEvent event_1 = new AutoResetEvent(false);
            private static AutoResetEvent event_2 = new AutoResetEvent(false);
            //private static AutoResetEvent event_3 = new AutoResetEvent(false); // not needed

            public Foo()
            { }

            public void First(Action printFirst)
            {
                // printFirst() outputs "first". Do not change or remove this line.
                printFirst();
                event_1.Set();
            }

            public void Second(Action printSecond)
            {
                event_1.WaitOne();
                // printSecond() outputs "second". Do not change or remove this line.
                printSecond();
                event_2.Set();
            }

            public void Third(Action printThird)
            {
                event_2.WaitOne();
                // printThird() outputs "third". Do not change or remove this line.
                printThird();
            }
        }

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
