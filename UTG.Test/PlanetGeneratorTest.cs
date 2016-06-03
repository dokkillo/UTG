using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTG.Universe.Generate;
using UTG.Planet.Objects;
using UTG.Data;

namespace UTG.Test
{
    [TestClass]
    public class PlanetGeneratorTest
    {
        [TestMethod]
        public void PlanetInit()
        {            
            var planetTypeList = PlanetBaseList.GetTypes();
            var barrenPlanet = planetTypeList[0];
            var result = PlanetGenerator.Init(barrenPlanet);
            var result2 = PlanetGenerator.Init(barrenPlanet);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Size >= barrenPlanet.MinSize);
            Assert.IsTrue(result.Size <= barrenPlanet.MaxSize);
            Assert.IsTrue(result.Size != result2.Size);
            Assert.IsTrue(result.HeliumQuantity > 0);
            Assert.IsTrue(result.HeliumQuantity == barrenPlanet.HeliumProportion * result.Size);
            Assert.IsTrue(result.HidrogenQuantity > 0);
            Assert.IsTrue(result.HidrogenQuantity == barrenPlanet.HidrogenProportion * result.Size);
            Assert.IsTrue(result.IronQuantity > 0);
            Assert.IsTrue(result.IronQuantity == barrenPlanet.IronProportion * result.Size);
            Assert.IsTrue(result.OxygenQuantity > 0);
            Assert.IsTrue(result.OxygenQuantity == barrenPlanet.OxygenProportion * result.Size);
            Assert.IsTrue(result.PlatiniumQuantity > 0);
            Assert.IsTrue(result.PlatiniumQuantity == barrenPlanet.PlatiniumProportion * result.Size);
            Assert.IsTrue(result.UraniumQuantity > 0);
            Assert.IsTrue(result.UraniumQuantity == barrenPlanet.UraniumProportion * result.Size);
        }
    }
}
