using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Material.Objects;

namespace UTG.Planet.Interface
{
   public interface IPlanet
    {
       string Name();
       string GetType();
       bool CanHandleLive();
       double Frequency();
       bool CanHandleCities();
       double MinSize();
       double MaxSize();
       double HeliumProportion();
       double HidrogenProportion();
       double IronProportion();
       double OxygenProportion();
       double PlatiniumProportion();
       double UraniumProportion();
       double VanadiumProportion();       
    }
}
