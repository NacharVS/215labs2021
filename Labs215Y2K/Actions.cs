using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labs215Y2K
{
    class Actions
    {
        public static void Fight(Unit unit, Unit unit2)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"unit {unit.Name} hited unit {unit2.Name}");
            unit2.GetDamage(unit.InflictDamage());
            Console.WriteLine($"unit {unit2.Name} hited unit {unit.Name}");
            unit.GetDamage(unit2.InflictDamage());
            Console.WriteLine($"{unit2.Name} - {unit2.Health}");
            Console.WriteLine($"{unit.Name} - {unit.Health}");
        }
    }
}
