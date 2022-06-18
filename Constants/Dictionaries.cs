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
    }
}
