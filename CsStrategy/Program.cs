using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            Weapon knife = new Knife();
            Weapon gun = new Gun();
            Weapon atomic = new AtomicBomb();
            Console.WriteLine(soldier.Shoot());
            soldier.SetWeapon(knife);
            Console.WriteLine(soldier.Shoot());
            soldier.SetWeapon(gun);
            Console.WriteLine(soldier.Shoot());
            soldier.SetWeapon(atomic);
            Console.WriteLine(soldier.Shoot());
            Console.ReadKey();
        }
    }
}
