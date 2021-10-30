using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Units;

namespace Action
{
    class Actions
    {
        public static void WarriorVSArcher(Archer Archer, Warrior Warrior)
        {
            Thread.Sleep(500);
            Console.WriteLine();
            if (Archer.Health > 0 )
            {
                Console.WriteLine($"{Archer.Name} наносит урон {Warrior.Name}у");
                Warrior.GetDamage(Archer.InflictDamage());
            }
            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name} наносит урон {Archer.Name}у");
                Archer.GetDamage(Warrior.InflictDamage());
            }

            Console.WriteLine();

            if (Warrior.Health > 0)
            {
                Console.WriteLine($"{Warrior.Name} - {Warrior.Health} xp");
            }
            if (Archer.Health > 0)
            {
                Console.WriteLine($"{Archer.Name} - {Archer.Health} xp");
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
        public static void ArcherVSMageVsWarrior(Mage Mage, Warrior Warrior, Archer Archer, Healer Healer)
        {
            Thread.Sleep(500);
            Console.WriteLine();
            int RandomFightOne = new Random().Next(1,3);
            int RandomHealingOne = new Random().Next(1, 2);
            int RandomHealingTwo = new Random().Next(1, 5);
            int RandomHealingThree = new Random().Next(1, 5);
            int RandomHealingFour = new Random().Next(1, 5);
            int RandomHealingFive = new Random().Next(1, 5);
            int RandomHealingSix = new Random().Next(1, 5);
            if (RandomFightOne == 1)
            {
                if (Mage.Health > 0)
                {
                    Console.WriteLine($"{Mage.Name} наносит урон {Warrior.Name}у"); // Маг наносит Воину
                    Warrior.GetDamage(Mage.InflictDamage());
                }
                if (RandomHealingOne == 1)
                {
                    if (Healer.Health > 0)
                    {
                        Console.WriteLine($"{Healer.Name} хилит {Warrior.Name}а"); // Хилер хилит Воина
                        Warrior.GetHeal(Healer.Healing);
                    }
                }
            }
            else
            {
                if (Mage.Health > 0)
                {
                    Console.WriteLine($"{Mage.Name} наносит урон {Archer.Name}у"); // Маг наносит Лучнику
                    Archer.GetDamage(Mage.InflictDamage());
                }
                if (RandomHealingTwo == 1)
                {
                    if (Healer.Health > 0) 
                    {
                        Console.WriteLine($"{Healer.Name} хилит {Archer.Name}а"); // Хилер хилит Лучника
                        Archer.GetHeal(Healer.Healing);
                    }
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
                if (RandomHealingThree == 1)
                {
                    if (Healer.Health > 0)
                    {
                        Console.WriteLine($"{Healer.Name} хилит {Mage.Name}а"); // Хилер хилит Мага
                        Mage.GetHeal(Healer.Healing);
                    }
                }
            }
            else
            {
                if (Warrior.Health > 0)
                {
                    Console.WriteLine($"{Warrior.Name} наносит урон {Archer.Name}у"); //  Воин наносит Лучнику
                    Archer.GetDamage(Warrior.InflictDamage());
                }
                if (RandomHealingFour == 1)
                {
                    if (Healer.Health > 0)
                    {
                        Console.WriteLine($"{Healer.Name} хилит {Archer.Name}а"); // Хилер хилит Лучника
                        Archer.GetHeal(Healer.Healing);
                    }
                }
            }
  

            int RandomFightThree = new Random().Next(1, 3);
            if (RandomFightThree == 1)
            {
                if (Archer.Health > 0)
                {
                    Console.WriteLine($"{Archer.Name} наносит урон {Warrior.Name}у"); // Лучник наносит Воину
                    Warrior.GetDamage(Archer.InflictDamage());
                }
                if (RandomHealingFive == 1)
                {
                    if (Healer.Health > 0)
                    {
                        Console.WriteLine($"{Healer.Name} хилит {Warrior.Name}а"); // Хилер хилит Воина
                        Warrior.GetHeal(Healer.Healing);
                    }
                }
            }
            else
            {
                if (Archer.Health > 0)
                {
                    Console.WriteLine($"{Archer.Name} наносит урон {Mage.Name}у"); // Лучник наносит Магу
                    Mage.GetDamage(Archer.InflictDamage());
                }
                if (RandomHealingSix == 1)
                {
                    if (Healer.Health > 0)
                    {
                        Console.WriteLine($"{Healer.Name} хилит {Mage.Name}а"); // Хилер хилит Мага
                        Mage.GetHeal(Healer.Healing);
                    }
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
            if (Archer.Health > 0)
            {
                Console.WriteLine($"{Archer.Name} - {Archer.Health} xp");
            }
            if (Healer.Health > 0)
            {
                Console.WriteLine($"{Healer.Name} - {Healer.Health} xp");
            }
        }

    }
}