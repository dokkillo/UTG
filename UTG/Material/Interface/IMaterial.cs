using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTG.Material.Interface
{
    public interface IMaterial
    {
        double GetWeight(int Quantity);
        string GetName();
        double Difficulty();

    }
}
