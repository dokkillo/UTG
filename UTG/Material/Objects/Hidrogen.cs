using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Material.Interface;

namespace UTG.Material.Objects
{
    public class Hidrogen : IMaterial
    { 
        public double GetWeight(int Quantity)
        {
            return 0.5 * Quantity;
        }

        public string GetName()
        {
            return "Hidrogen";
        }
        public double Difficulty()
        {
            return 2;
        }
    }
}
