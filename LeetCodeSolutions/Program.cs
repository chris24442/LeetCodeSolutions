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

        public string IntToRoman(int num)
        {
            // TODO: this shouldn't be here. I need somewhere to hard code these types of things.
            var romanNumeralValues = new Dictionary<int, string>()
            {
                {1, "I"},
                {2, "II"},
                {3 , "III"},
                {4, "IV"},
                {5, "V" },
                {6, "VI"},
                {7, "VII"},
                {8 , "VIII"},
                {9, "IX"},
                {10, "X" },
                {20, "XX"},
                {30 , "XXX"},
                {40, "XL"},
                {50, "L" },
                {60, "LX"},
                {70, "LXX"},
                {80, "LXXX"},
                {90, "XC"},
                {100, "C" },
                {200, "CC"},
                {300 , "CCC"},
                {400, "CD"},
                {500, "D" },
                {600, "DC"},
                {700, "DCC"},
                {800, "DCCC"},
                {900, "CM"},
                {1000, "M" },
                {2000, "MM"},
                {3000 , "MMM"},
                };

            string result = "";
            char[] sChar = num.ToString().ToCharArray();
            double tenPowerOf = sChar.Length - 1;

            foreach (char c in sChar)
            {
                int lookupValue = int.Parse(c.ToString()) * (int)Math.Pow(10, tenPowerOf);

                if (lookupValue != 0) 
                    result += romanNumeralValues[lookupValue];

                tenPowerOf--;
            }
            
            return result;
        }

    }
}
