using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Material.Interface;

namespace UTG.Material.Objects
{
    public class Oxygen : IMaterial
    {

        public double GetWeight(int Quantity)
        {
            return 1 * Quantity;
        }

        public string GetName()
        {
            return "Oxygen";
        }
        public double Difficulty()
        {
            return 3;
        }
    }
}
