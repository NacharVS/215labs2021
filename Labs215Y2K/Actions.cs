using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Units;

namespace Action
{
    class Actions
    {
        public static void Fight(UnitEs unit, UnitEs unit2)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"unit {unit.Name} hited unit {unit2.Name}");
            unit2.GetDamage(unit.InflictDamage());
            Console.WriteLine($"unit {unit2.Name} hited unit {unit.Name}");
            unit.GetDamage(unit2.InflictDamage());
            Console.WriteLine($"{unit2.Name} - {unit2.CurrentHealth}");
            Console.WriteLine($"{unit.Name} - {unit.CurrentHealth}");
        }
    }
}