using System;
using System.ComponentModel.DataAnnotations;
using Units;
using Action;

namespace Labs215Y2K
{
    class Program
    {
         static void Main(string[] args)
        {
            ////int[] qq = new int[10];
            //int[,] qqnya = new int[10, 5];
            ////ArrayOperations.ArrayGeneration(qq, 11, 50);
            //ArrayOperations.ArrayGeneration(qqnya, 2);
            //Magazin.Ashan.catalog();
            //StudentsSort.StudentsSort.StudentSort();

            //BuilderPeacful Builder = new BuilderPeacful("Builder", 50, 1, 10, 15, 30, 10);
            //WoodmanPeacful Woodman = new WoodmanPeacful("Woodman", 60, 1, 10, 15, 40, 15);
            //MinerPeacful Miner = new MinerPeacful("Miner", 65, 1, 10, 15, 45, 20);
            //Healer Healer = new Healer("Healer", 100, 100, 5, 15, 10, 25, 10, 50,30,2,50);
            //Warrior Warrior = new Warrior("Warrior", 100, 100, 30, 50, 50, 20, 45);
            //MageWarrior Mage = new MageWarrior("Mage", 120, 120, 10, 20, 70, 100, 45, 50, 30, 30);
            //ArcherWarrior Archer = new ArcherWarrior("Archer", 80, 80, 15, 25, 60, 80, 30, 100, 40, 40, 2);

            //Console.WriteLine("Хотите ли вы видеть характеристики персонажей? 1 - да, 0 - нет");
            //int pers = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //if (pers == 1)
            //{
            //    Console.WriteLine($"Имя - {Builder.name} \t Здоровье - {Builder.MaxHealth} \t Минимальный урон - {Builder.MinDamage} \t Максимальный урон - {Builder.MaxDamage}  Броня - {Builder.armor}  Скорость - {Builder.speed}  Скорость атаки - {Builder.workspeed}");

            //    Console.WriteLine($"Имя - {Woodman.name} \t Здоровье - {Woodman.MaxHealth} \t Минимальный урон - {Woodman.MinDamage} \t Максимальный урон - {Woodman.MaxDamage}  Броня - {Woodman.armor}  Скорость - { Woodman.speed}  Скорость атаки - {Woodman.workspeed}");

            //    Console.WriteLine($"Имя - {Miner.name} \t Здоровье - {Miner.MaxHealth} \t Минимальный урон - {Miner.MinDamage} \t Максимальный урон - {Miner.MaxDamage}  Броня - {Miner.armor}  Скорость - {Miner.speed}  Скорость атаки - {Miner.workspeed}");

            //    Console.WriteLine($"Имя - {Warrior.name} \t Здоровье - {Warrior.MaxHealth}  Минимальный урон - {Warrior.MinDamage} \t Максимальный урон - {Warrior.MaxDamage}  Броня - {Warrior.armor}  Скорость - {Warrior.speed}  Скорость атаки - {Warrior.atackspeed}");

            //    Console.WriteLine($"Имя - {Mage.name} \t Здоровье - {Mage.MaxHealth}  Минимальный урон - {Mage.MinDamage} \t Максимальный урон - {Mage.MaxDamage}  Броня - {Mage.armor}  Скорость - {Mage.speed}  Скорость атаки - {Mage.atackspeed}");

            //    Console.WriteLine($"Имя - {Healer.name} \t Здоровье - {Healer.MaxHealth}  Минимальный урон - {Healer.MinDamage} \t Максимальный урон - {Healer.MaxDamage}  Броня - {Healer.armor}  Скорость - {Healer.speed}  Восстанавливает xp - {Healer.Healing} ");

            //    Console.WriteLine($"Имя - {Archer.name} \t Здоровье - {Archer.MaxHealth} \t Минимальный урон - {Archer.MinDamage} \t Максимальный урон - {Archer.MaxDamage}  Броня - {Archer.armor}  Скорость - {Archer.speed}  Скорость атаки - {Archer.atackspeed}");
            //}
            //Console.WriteLine();

            //BuilderPeacful.Moving(Builder.name); WoodmanPeacful.Moving(Woodman.name); MinerPeacful.Moving(Miner.name);
            //Console.WriteLine();
            //Console.WriteLine();

            //ArcherWarrior.ArcherDamage(Archer.name, Archer.MinRangeDamage, Archer.MaxRangeDamage, Archer.MinDamage, Archer.MaxDamage , Warrior.name,Warrior.MaxHealth ,Archer.CurrentHealth, Warrior.armor, Archer.CurrentArrows,Warrior.CurrentHealth);

            //Healer.MageVSArcherAndHealer(Mage.name, Mage.MaxHealth, Mage.CurrentHealth, Mage.MinDamage, Mage.MaxDamage, Archer.name, Archer.MinRangeDamage, Archer.MaxRangeDamage, Archer.CurrentHealth, Archer.CurrentArrows,Healer.Healing);

            //MageWarrior.MageVSArcher(Mage.name, Mage.MaxHealth, Mage.CurrentHealth, Mage.MinDamage, Mage.MaxDamage, Archer.name, Archer.MinRangeDamage, Archer.MaxRangeDamage, Archer.CurrentHealth, Archer.CurrentArrows);
            Peasant p1 = new Peasant();
            Peasant p2 = new Peasant();
            p1.Name = "Valera"; p2.Name = "Danila";
            p1.MinDamage = 15;
            p1.MaxDamage = 20;
            p2.MinDamage = 15;
            p2.MaxDamage = 20;
            p1.CurrentHealth = 50;
            p2.CurrentHealth = 50;
            Actions.Fight(p1, p2);
            Actions.Fight(p1, p2);
            Actions.Fight(p1, p2);


        }
        public static void magaz(int[] numberofproduct, int yesno, string[] catalog, string[] korzina, int counter, int cycleoperation, int[] countofproduct, int[] korzinakolvo, int[] price, int[] Sum, int[] sumtwo, int[] korzinaprice)
        {
            int cou = 1;
            while (cycleoperation > 1)
            {
                Console.WriteLine("Выберите номер товара: ");
                numberofproduct[cou] = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите кол-во товара(товары на развес указывать в граммах с шагом в 100): ");
                countofproduct[cou] = int.Parse(Console.ReadLine());
                cou++;
                cycleoperation--;
                if (numberofproduct[cou] < 6)
                {
                    Sum[cou] += price[numberofproduct[cou]] * countofproduct[cou];
                    Console.WriteLine(Sum);
                }
                Console.WriteLine();

                if (numberofproduct[cou] > 5 && countofproduct[cou] % 100 == 0)
                {
                    int check = countofproduct[cou] / 100;
                    sumtwo[cou] += price[numberofproduct[cou]] * check;
                    Console.WriteLine(sumtwo);
                }
                else
                {
                    Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
                }
                if (numberofproduct[cou] != 0)
                {
                    korzina[counter] = catalog[numberofproduct[cou]];
                    Console.Write($"Корзина: {korzina[counter]}");
                    counter++;

                }

            }
            Console.WriteLine();
            Console.Write($"Товар:       Кол-во:         Цена:");
            Console.WriteLine();

            for (int i = 0; i < numberofproduct.Length; i++)
            {
                korzina[counter] = catalog[numberofproduct[i]];
                Console.Write($"{  korzina[counter]}          ");
                Console.Write($"{  countofproduct[counter]}          ");
                korzinakolvo[counter] = price[numberofproduct[i]];
                Console.Write($"{  korzinakolvo[counter]}         ");

                if (numberofproduct[cou] < 6)
                {
                    korzinaprice[counter] = Sum[counter];
                }
                else
                {
                    korzinaprice[counter] = sumtwo[counter];
                }
                Console.WriteLine($"{korzinaprice[counter]}");
                counter++;
                Console.WriteLine();
            }
        }

        //public static void UnitsCreator()
        //{

        //}
    }
}
