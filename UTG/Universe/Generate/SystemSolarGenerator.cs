using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Planet.Objects;
using UTG.Utils;

namespace UTG.Universe.Generate
{
    public static class SystemSolarGenerator
    {
        private const int MAX_NUM_PLANETS = 10;
        public static List<PlanetData> Init()
        {
            List<PlanetData> PlanetList = new List<PlanetData>();
            var numPlanets = MathUtil.GetRandomNumber(1, MAX_NUM_PLANETS);




            return PlanetList;
        }
    }
}
