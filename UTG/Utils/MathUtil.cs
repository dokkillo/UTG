using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTG.Utils
{
    public static class MathUtil
    {
        public static double GetRandomNumber(double Minimum, double Maximum)
        {            
            Random random = new Random(SeedUtil.GetSeed());
            return random.NextDouble() * (Maximum - Minimum) + Minimum;
        }  
    }
}
