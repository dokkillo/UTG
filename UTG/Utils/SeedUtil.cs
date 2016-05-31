using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTG.Utils
{
    public static class SeedUtil
    {
        public static int GetSeed()
        {
            return Guid.NewGuid().GetHashCode();
        }
    }
}
