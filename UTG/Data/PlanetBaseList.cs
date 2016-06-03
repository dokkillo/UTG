using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Planet.Objects;

namespace UTG.Data
{
    public static class PlanetBaseList
    {
        public static List<PlanetBase> GetTypes()
        {
            List<PlanetBase> planetList = new List<PlanetBase>();
            planetList.Add(new PlanetBase(null, true, 30, true, 10, 100, 10, 20, 40, 30, 5,5, 5, PlanetType.Barren));
            planetList.Add(new PlanetBase(null, false, 50, false, 50, 200, 40, 40, 0, 25, 0,8, 10, PlanetType.Gas));
            planetList.Add(new PlanetBase(null, true, 20, true, 15, 80, 20, 30, 20, 45, 10,3, 8, PlanetType.Oceanic));

            return planetList;
        }
    }
}
