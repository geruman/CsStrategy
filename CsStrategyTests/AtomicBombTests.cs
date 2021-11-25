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
    public class AtomicBombTests
    {
        [TestMethod()]
        public void ShootTest()
        {
            AtomicBomb bomb = new AtomicBomb();
            Assert.AreEqual("BOOOOOOOOM! an atomic explotion destroys everything!", bomb.Shoot());
        }
    }
}