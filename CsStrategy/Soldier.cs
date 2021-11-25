using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStrategy
{
    public class Soldier
    {
        private Weapon weapon;
        public void SetWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }
        public string Shoot()
        {
            if(weapon != null)
            {
                return weapon.Shoot();
            }
            else
            {
                return "No weapons in hand";
            }
        }

    }
}
