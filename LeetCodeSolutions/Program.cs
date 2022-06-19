using Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LeetCodeSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        #region 19JUNE22

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


        #endregion

        #region 18JUNE22

        // 13. Roman to Integer
        // Feedback after looking at hints: Would be better to iterate right to left
        //  But the gist is right
        public int RomanToInt(string s)
        {
            int solution = 0;

            string leftChar = "";
            string rightChar = "";
            int index = 0;
            string[] sChar = s.ToCharArray().Select(c => c.ToString()).ToArray();

            while (index < s.Length)
            {
                // first char
                if (leftChar == "")
                {
                    leftChar = sChar[index];
                    index++;
                    continue;
                }

                // a decreasing char
                rightChar = sChar[index];
                if (Dictionaries.romanNumeralToInt[leftChar] >= Dictionaries.romanNumeralToInt[rightChar])
                {
                    solution += Dictionaries.romanNumeralToInt[leftChar];
                    leftChar = rightChar;
                    index++;
                    continue;
                }

                // an increasing char
                solution += Dictionaries.romanNumeralToInt[leftChar + rightChar];
                leftChar = rightChar = "";
                index++;
            }
            if (leftChar != "")
            {
                solution += Dictionaries.romanNumeralToInt[leftChar];
            }

            return solution;
        }

        // 12. Integer to Roman
        // Other methods are available, but the gist is right
        public string IntToRoman(int num)
        {
            string result = "";
            string[] sChar = num.ToString().ToCharArray().Select(c => c.ToString()).ToArray(); ;
            double tenPowerOf = sChar.Length - 1;

            foreach (string c in sChar)
            {
                int lookupValue = int.Parse(c) * (int)Math.Pow(10, tenPowerOf);

                if (lookupValue != 0)
                    result += Dictionaries.intToRomanNumeral[lookupValue];

                tenPowerOf--;
            }

            return result;
        }

        // 273. Integer to English Words
        // Pretty happy with my approach
        // Could be refactored
        public string NumberToWords(int num)
        {
            // 12345
            string result = "";
            string inputStr = num.ToString();
            int numberSuffix = 1; // thousand / million etc

            while (inputStr.Length >= 3)
            {
                string lastThreeDigits = inputStr.Substring(inputStr.Length - 3);
                inputStr = inputStr.Substring(0, inputStr.Length - 3);

                if (Convert.ToInt32(lastThreeDigits) == 0)
                {
                    numberSuffix *= 1000;
                    continue;
                }

                if (numberSuffix != 1)
                {
                    result = threeDigitNumberToWords(Convert.ToInt32(lastThreeDigits)) + " " + Dictionaries.intToLongString[numberSuffix] + " " + result;
                }
                else
                {
                    result = threeDigitNumberToWords(Convert.ToInt32(lastThreeDigits));
                }
                numberSuffix *= 1000;
            }

            if (inputStr.Length % 3 == 0)
                return result.Trim();

            // add prefix
            string prefixString = num.ToString().Substring(0, inputStr.Length % 3);

            if (numberSuffix != 1)
                result = threeDigitNumberToWords(Convert.ToInt32(prefixString)) + " " + Dictionaries.intToLongString[numberSuffix] + " " + result;
            else
                result = threeDigitNumberToWords(Convert.ToInt32(prefixString)) + result;

            return result.Trim();
        }

        public string threeDigitNumberToWords(int num)
        {
            // TODO: Test for valid input
            string result = "";
            int inputHundreds = HelperFunctions.RoundDown(num, 100) / 100;
            string input = num.ToString();
            if (input.Length == 3)
            {
                result += Dictionaries.intToLongString[inputHundreds] + " ";
                result += "Hundred" + " ";
                input = input[1..];
                num = num % 100;
            }

            // where 100 is used, 00 does not need to be converted for display
            if (Convert.ToInt32(input) == 0 && result != "")
                return result.Trim();

            if (input.Length == 2)
            {
                // works for teens
                if (Dictionaries.intToLongString.ContainsKey(Convert.ToInt32(input)))
                {
                    result += Dictionaries.intToLongString[Convert.ToInt32(input)];
                    return result.Trim();
                }

                // works for 67
                int inputTens = HelperFunctions.RoundDown(num, 10);
                result += Dictionaries.intToLongString[inputTens] + " ";
                input = input[1..];
            }
            result += Dictionaries.intToLongString[Convert.ToInt32(input)] + " ";

            // remove last character
            return result.Trim();
        }

        #endregion
    }
}
