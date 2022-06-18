using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //13. Roman to Integer
        // Feedback after looking at hints: Would be better to iterate right to left
        //  But the gist is right
        public int RomanToInt(string s)
        {
            int solution = 0;

            // TODO: this shouldn't be here. I need somewhere to hard code these types of things.
            var romanNumeralValues = new Dictionary<string, int>()
            {
                {"I" , 1 },
                {"V" , 5 },
                {"X" , 10 },
                {"L" , 50 },
                {"C" , 100 },
                {"D" , 500 },
                {"M" , 1000 },
                {"IV" , 4 },
                {"IX" , 9 },
                {"XL" , 40 },
                {"XC" , 90 },
                {"CD" , 400 },
                {"CM" , 900 }
            };

            string leftChar = "";
            string rightChar = "";
            int index = 0;
            string[] sChar = s.ToCharArray().Select(c => c.ToString()).ToArray(); ;

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
                if (romanNumeralValues[leftChar] >= romanNumeralValues[rightChar])
                {
                    solution += romanNumeralValues[leftChar];
                    leftChar = rightChar;
                    index++;
                    continue;
                }

                // an increasing char
                solution += romanNumeralValues[leftChar + rightChar];
                leftChar = rightChar = "";
                index++;
            }
            if (leftChar != "")
            {
                solution += romanNumeralValues[leftChar];
            }

            return solution;
        }
    }
}
