using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStrategy.Tests
{
    [TestClass()]
    public class GunTests
    {
        [TestMethod()]
        public void ShootTest()
        {
            Gun gun = new Gun();
            Assert.AreEqual("A shot has been fired.", gun.Shoot());
        }
    }
}