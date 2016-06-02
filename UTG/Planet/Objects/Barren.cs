using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Planet.Interface;

namespace UTG.Planet.Objects
{
    public sealed class Barren :IPlanet
    {
        public string Name()
        {
            throw new NotImplementedException();
        }

        public new string GetType()
        {
            return "Barren";
        }

        public bool CanHandleLive()
        {
            return true;
        }

        public double Frequency()
        {
           return 5;
        }

        public bool CanHandleCities()
        {
           return true;
        }

        public double MinSize()
        {
            return 10;
        }

        public double MaxSize()
        {
            return 100;
        }

        public double HeliumProportion()
        {
           return 5;
        }

        public double HidrogenProportion()
        {
            return 30;
        }

        public double IronProportion()
        {
            return 20;
        }

        public double OxygenProportion()
        {
            return 30;
        }

        public double PlatiniumProportion()
        {
           return 10;
        }

        public double VanadiumProportion()
        {
            return 1;
        }

        public double UraniumProportion()
        {
            return 4;
        }
    }
}
