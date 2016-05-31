using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Planet.Interface;
using UTG.Planet.Objects;
using UTG.Utils;

namespace UTG.Universe.Generate
{
    public static class PlanetGenerator
    {
        public static PlanetData Init(IPlanet PlanetBase)
        {
            PlanetData Planet = new PlanetData();
            Planet.Size = MathUtil.GetRandomNumber(PlanetBase.MinSize(), PlanetBase.MaxSize());
            return Planet;
        }


    }
}
