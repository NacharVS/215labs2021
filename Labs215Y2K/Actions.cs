using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Units;

namespace Action
{
    class Actions
    {
        public static void WarriorVSArcher(Archer WarriorArcher, Warrior Warrior)
        {
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
        public static void MageVSWarior(Mage Mage, Warrior Warrior)
        {
            Thread.Sleep(500);
            Console.WriteLine();
            if (Mage.Health > 0)
            {
                Console.WriteLine($"{Mage.Name} наносит урон {Warrior.Name}у");
                Warrior.GetDamage(Mage.InflictDamage());
            }
            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name} наносит урон {Mage.Name}у");
                Mage.GetDamage(Warrior.InflictDamage());
            }

            Console.WriteLine();

            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name} - {Warrior.Health} xp");
            }
            if (Mage.Health > 0)
            {
                Console.WriteLine($"{Mage.Name} - {Mage.Health} xp");
            }
        }
        public static void ArcherVSMageVsWarrior(Mage Mage, Warrior Warrior, Archer WarriorArcher, Healer Healer)
        {
            Thread.Sleep(500);
            Console.WriteLine();
            int RandomFightOne = new Random().Next(1,3);
            int RandomHealingOne = new Random().Next(1, 5);
            if (RandomFightOne == 1)
            {
                if (Mage.Health > 0)
                {
                    Console.WriteLine($"{Mage.Name} наносит урон {Warrior.Name}у"); // Маг наносит Воину
                    Warrior.GetDamage(Mage.InflictDamage());
                }
            }
            else
            {
                if (Mage.Health > 0)
                {
                    Console.WriteLine($"{Mage.Name} наносит урон {WarriorArcher.Name}у"); // Маг наносит Лучнику
                    WarriorArcher.GetDamage(Mage.InflictDamage());
                }

                if (Healer.Health > 0) // ещё куда-нибудь добавить if
                {
                    Console.WriteLine($"{Healer.Name} хилит {WarriorArcher.Name}а"); // Хилер хилит Лучника
                    WarriorArcher.GetHeal(Healer.Healing);
                }
            }

            int RandomFightTwo = new Random().Next(1, 3);
            if (RandomFightTwo == 1)
            {
                if (Warrior.Health > 0)
                {
                    Console.WriteLine($"{Warrior.Name} наносит урон {Mage.Name}у"); //  Воин наносит Магу
                    Mage.GetDamage(Warrior.InflictDamage());
                }
            }
            else
            {
                if (Warrior.Health > 0)
                {
                    Console.WriteLine($"{Warrior.Name} наносит урон {WarriorArcher.Name}у"); //  Воин наносит Лучнику
                    WarriorArcher.GetDamage(Warrior.InflictDamage());
                }
            }
  

            int RandomFightThree = new Random().Next(1, 3);
            if (RandomFightThree == 1)
            {
                if (WarriorArcher.Health > 0)
                {
                    Console.WriteLine($"{WarriorArcher.Name} наносит урон {Warrior.Name}у"); // Лучник наносит Воину
                    Warrior.GetDamage(WarriorArcher.InflictDamage());
                }
            }
            else
            {
                if (WarriorArcher.Health > 0)
                {
                    Console.WriteLine($"{WarriorArcher.Name} наносит урон {Mage.Name}у"); // Лучник наносит Магу
                    Mage.GetDamage(WarriorArcher.InflictDamage());
                }
            }
            Console.WriteLine();

            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name} - {Warrior.Health} xp");
            }
            if (Mage.Health > 0)
            {
                Console.WriteLine($"{Mage.Name} - {Mage.Health} xp");
            }
            if (WarriorArcher.Health > 0)
            {
                Console.WriteLine($"{WarriorArcher.Name} - {WarriorArcher.Health} xp");
            }
            if (Healer.Health > 0)
            {
                Console.WriteLine($"{Healer.Name} - {Healer.Health} xp");
            }
        }

    }
}