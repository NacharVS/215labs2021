using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Units;

namespace Action
{
    class Actions
    {
        public static void WarriorVSArcher(Unit unit, Unit unit2)
        {
                Thread.Sleep(500);
                Console.WriteLine();
            if (unit.Health > 0 )
            {
                Console.WriteLine($"{unit.Name} наносит урон {unit2.Name}у");
                unit2.GetDamage(unit.InflictDamage());
            }
            if (unit2.Health > 0)
            {
                Console.WriteLine($"{unit2.Name} наносит урон {unit.Name}у");
                unit.GetDamage(unit2.InflictDamage());
            }

            Console.WriteLine();

            if (unit2.Health > 0)
            {
                Console.WriteLine($"{unit2.Name} - {unit2.Health} xp");
            }
            if (unit.Health > 0)
            {
                Console.WriteLine($"{unit.Name} - {unit.Health} xp");
            }

        }
    }
}