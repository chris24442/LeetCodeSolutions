using System;
using System.Collections.Generic;

namespace Constants
{
    public static class Dictionaries
    {
        public static Dictionary<string, int> romanNumeralToInt = new Dictionary<string, int>()
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

        public static Dictionary<int, string> intToRomanNumeral = new Dictionary<int, string>()
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

        public static Dictionary<int, string> intToLongString = new Dictionary<int, string>()
        {
            {0, "Zero"},
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five" },
            {6, "Six"},
            {7, "Seven"},
            {8 , "Eight"},
            {9, "Nine"},
            {10, "Ten" },
            {11, "Eleven"},
            {12, "Twelve"},
            {13, "Thirteen"},
            {14, "Fourteen"},
            {15, "Fifteen"},
            {16, "Sixteen"},
            {17, "Seventeen" },
            {18, "Eighteen"},
            {19, "Nineteen"},
            {20, "Twenty"},
            {30, "Thirty"},
            {40, "Forty"},
            {50, "Fifty"},
            {60, "Sixty"},
            {70, "Seventy"},
            {80, "Eighty"},
            {90, "Ninety"},
            {100, "Hundred"},
            {1000, "Thousand"},
            {1000000, "Million"},
            {1000000000, "Billion"}
            // TODO: something clever with 64 bit int
            //{1000000000000, "Trillion"},
            //{1000000000000000, "Quadrillion"},
            //{1000000000000000000, "Quintillion"},
            //{1000000000000000000, "Nonillion"},
            //{1000000000000000000000, "Decillion"}
//Googol: 1 followed by 100 zeros
//Centillion: 1 followed by 303 zeros
//Googolplex: 1 followed by a googol zero  s
        };

    }
}
