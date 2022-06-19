using System;
using System.Collections.Generic;

namespace Constants
{
    public static class HelperFunctions
    {
        public static int RoundUp(int toRound, int roundingMultiple)
        {
            if (toRound % roundingMultiple == 0) return toRound;
            return (roundingMultiple - toRound % roundingMultiple) + toRound;
        }

        public static int RoundDown(int toRound, int roundingMultiple)
        {
            return toRound - toRound % roundingMultiple;
        }
    }

}
