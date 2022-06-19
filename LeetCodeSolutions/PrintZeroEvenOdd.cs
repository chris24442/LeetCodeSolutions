using Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks; // not required on leetcode

namespace LeetCodeSolutions
{

    //1116. Print Zero Even Odd
    // TODO - simplify by removing count and length
    public class ZeroEvenOdd
    {
        private readonly int n;

        private Action<int> print = (input) => { Console.Write(input.ToString()); }; // not required on leetcode

        private static readonly AutoResetEvent printZeroEvent = new(true);
        private static readonly AutoResetEvent printEvenEvent = new(false);
        private static readonly AutoResetEvent printOddEvent = new(false);

        public ZeroEvenOdd(int n)
        {
            this.n = n;

            Task.Factory.StartNew(() => Zero(print)); // not required on leetcode
            Task.Factory.StartNew(() => Even(print)); // not required on leetcode
            Task.Factory.StartNew(() => Odd(print)); // not required on leetcode
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Zero(Action<int> printNumber)
        {
            int count = 1;
            for (int length = 0; length < 2 * n; length += 2 )
            {
                printZeroEvent.WaitOne();
                printNumber(0);

                // release lock
                if (count % 2 == 0)
                    printEvenEvent.Set();
                else
                    printOddEvent.Set();

                count++;
            }
        }

        public void Even(Action<int> printNumber)
        {
            int count = 2;
            for (int length = 2; length < 2 * n; length += 3)
            {
                printEvenEvent.WaitOne();
                printNumber(count);
                printZeroEvent.Set();
                count += 2; // get next even number
            }
        }

        public void Odd(Action<int> printNumber)
        {
            int count = 1;
            for (int length = 1; length < 2 * n; length += 3)
            {
                printOddEvent.WaitOne();
                printNumber(count);
                printZeroEvent.Set();
                count += 2; // get next odd number
            }
        }
    }
}
