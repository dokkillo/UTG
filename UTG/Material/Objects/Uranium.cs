using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Material.Interface;

namespace UTG.Material.Objects
{
    public class Uranium : IMaterial
    {
        public double GetWeight(int Quantity)
        {
            return 3 * Quantity;
        }

        public string GetName()
        {
            return "Uranium";
        }
        public double Difficulty()
        {
            return 7;
        }
    }
}
