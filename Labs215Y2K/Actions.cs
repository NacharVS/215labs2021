using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Units;

namespace Action
{
    class Actions
    {
        public static void WarriorVSArcher(Unit WarriorArcher, Unit Warrior)
        {
            Console.WriteLine($"Бой между {WarriorArcher.Name} и {Warrior.Name}");
            Thread.Sleep(500);
            Console.WriteLine();
            if (WarriorArcher.Health > 0 )
            {
                Console.WriteLine($"{WarriorArcher.Name} наносит урон {Warrior.Name}у");
                Warrior.GetDamage(WarriorArcher.InflictDamage());
            }
            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name} наносит урон {WarriorArcher.Name}у");
                WarriorArcher.GetDamage(Warrior.InflictDamage());
            }

            Console.WriteLine();

            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name} - {Warrior.Health} xp");
            }
            if (WarriorArcher.Health > 0)
            {
                Console.WriteLine($"{WarriorArcher.Name} - {WarriorArcher.Health} xp");
            }
        }


    }
}