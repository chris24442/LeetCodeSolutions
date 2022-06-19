using Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LeetCodeSolutions
{
    public class PrintInOrder
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

    }
}
