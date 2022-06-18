using Constants;
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
        public string NumberToWords(int num)
        {
            return "";
        }

    }
}
