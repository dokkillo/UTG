using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTG.Utils
{
    public static class MathUtil
    {
        public static double GetRandomNumber(double minimum, double maximum)
        {            
            Random random = new Random(SeedUtil.GetSeed());
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

        public static double GetRandomNumber(int minimum, int maximum)
        {
            Random random = new Random(SeedUtil.GetSeed());
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
