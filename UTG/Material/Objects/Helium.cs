using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Material.Interface;

namespace UTG.Material.Objects
{
    public class Helium : IMaterial
    {
        public double GetWeight(int Quantity)
        {
            return 0.1 * Quantity;
        }

        public string GetName()
        {
            return "Helium";
        }
        public double Difficulty()
        {
            return 1;
        }
    }
}
