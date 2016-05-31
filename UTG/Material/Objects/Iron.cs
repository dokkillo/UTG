using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Material.Interface;

namespace UTG.Material.Objects
{
    public class Iron : IMaterial
    {
        public double GetWeight(int Quantity)
        {
           return 5 * Quantity;
        }

        public string GetName()
        {
           return "Iron";
        }
        public double Difficulty()
        {
            return 4;
        }
    }
}
