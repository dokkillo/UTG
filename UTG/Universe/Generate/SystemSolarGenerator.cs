using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Data;
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
            var numPlanets = MathUtil.GetRandomNumber(1, MAX_NUM_PLANETS,true);
            var planetBaseList = PlanetBaseList.GetTypes();

            foreach (var planetBase in planetBaseList)
            {
                var numPlanetTypes = Convert.ToInt32((planetBase.Frequency  * numPlanets)/100);
                if(numPlanetTypes > 0)
                {
                    for (int i = 0; i < numPlanetTypes; i++)
                    {
                        PlanetList.Add(PlanetGenerator.Init(planetBase));
                    }
                }
            }
            return PlanetList;
        }
    }
}
