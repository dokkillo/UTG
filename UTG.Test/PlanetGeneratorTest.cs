using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTG.Universe.Generate;
using UTG.Planet.Objects;

namespace UTG.Test
{
    [TestClass]
    public class PlanetGeneratorTest
    {
        [TestMethod]
        public void PlanetInit()
        {             
            Barren barrenPlanet = new Barren();
            var result = PlanetGenerator.Init(barrenPlanet);
            var result2 = PlanetGenerator.Init(barrenPlanet);
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Size >= barrenPlanet.MinSize());
            Assert.IsTrue(result.Size <= barrenPlanet.MaxSize());
            Assert.IsTrue(result.Size != result2.Size);
        }
    }
}
