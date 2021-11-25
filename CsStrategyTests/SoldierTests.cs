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
    public class SoldierTests
    {
        [TestMethod()]
        public void ShootTest()
        {
            Soldier soldier = new Soldier();
            Assert.AreEqual("No weapons in hand", soldier.Shoot());
            Weapon knife = new Knife();
            soldier.SetWeapon(knife);
            Assert.AreEqual("A knife is wielded", soldier.Shoot());
        }
    }
}