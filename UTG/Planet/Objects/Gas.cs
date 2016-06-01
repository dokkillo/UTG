using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Planet.Interface;

namespace UTG.Planet.Objects
{
    public sealed class Gas : IPlanet
    {
        public bool CanHandleCities()
        {
            return false;
        }

        public bool CanHandleLive()
        {
            return false;
        }

        public double Frequency()
        {
            return 8;
        }

        public double HeliumProportion()
        {
            return 40;
        }

        public double HidrogenProportion()
        {
            return 40;
        }

        public double IronProportion()
        {
            return 0;
        }

        public double MaxSize()
        {
            return 2000;
        }

        public double MinSize()
        {
            return 400;
        }

        public string Name()
        {
            throw new NotImplementedException();
        }

        public double OxygenProportion()
        {
            return 20;
        }

        public double PlatiniumProportion()
        {
            return 0;
        }

        public double UraniumProportion()
        {
            return 5;
        }

        public double VanadiumProportion()
        {
            return 0;
        }

        string IPlanet.GetType()
        {
            return "Gas";
        }
    }
}
