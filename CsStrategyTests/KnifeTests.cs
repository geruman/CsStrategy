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
    public class KnifeTests
    {
        [TestMethod()]
        public void ShootTest()
        {
            Knife knife = new Knife();
            Assert.AreEqual("A knife is wielded", knife.Shoot());
        }
    }
}