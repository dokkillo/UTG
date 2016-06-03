using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTG.Planet.Objects;
using UTG.Utils;

namespace UTG.Universe.Generate
{
    public static class PlanetGenerator
    {
        public static PlanetData Init(PlanetBase PlanetBase)
        {
            PlanetData Planet = new PlanetData();
            Planet.Size = MathUtil.GetRandomNumber(PlanetBase.MinSize, PlanetBase.MaxSize);
            Planet.Type = PlanetBase.Type;
            Planet.HeliumQuantity = GetMaterialQuantity(PlanetBase.HeliumProportion, Planet.Size);
            Planet.HidrogenQuantity = GetMaterialQuantity(PlanetBase.HidrogenProportion, Planet.Size);
            Planet.IronQuantity = GetMaterialQuantity(PlanetBase.IronProportion, Planet.Size);
            Planet.OxygenQuantity = GetMaterialQuantity(PlanetBase.OxygenProportion, Planet.Size);
            Planet.PlatiniumQuantity = GetMaterialQuantity(PlanetBase.PlatiniumProportion, Planet.Size);
            Planet.UraniumQuantity = GetMaterialQuantity(PlanetBase.UraniumProportion, Planet.Size);
            Planet.VanadiumQuantity = GetMaterialQuantity(PlanetBase.VanadiumProportion, Planet.Size);
            return Planet;
        }

        private static double GetMaterialQuantity(double MaterialQuantity, double PlanetSize)
        {
            return MaterialQuantity * PlanetSize;
        }

    }
}
