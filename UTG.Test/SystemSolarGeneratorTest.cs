using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTG.Universe.Generate;

namespace UTG.Test
{
    [TestClass]
    public class SystemSolarGeneratorTest
    {
        [TestMethod]
        public void SystemSolarTest()
        {
           var result = SystemSolarGenerator.Init();
            Assert.IsTrue(result.Count > 0);            
        }
    }
}
