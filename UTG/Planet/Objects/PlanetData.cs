using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Planet.Interface;

namespace UTG.Planet.Objects
{
    public class PlanetData
    {
        public int HeliumQuantity { get; set; }
        public int HidrogenQuantity { get; set; }
        public int IronQuantity { get; set; }
        public int OxygenQuantity { get; set; }
        public int PlatiniumQuantity { get; set; }
        public int UraniumQuantity { get; set; }
        public int VanadiumQuantity { get; set; }
        public IPlanet Type { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }

    }
}
