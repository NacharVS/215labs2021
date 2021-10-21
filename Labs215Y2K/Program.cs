using System;
using Units;

namespace Labs215Y2K
{
    class Program
    {
        public static void Main(string[] args)
        {
            ////int[] qq = new int[10];
            //int[,] qqnya = new int[10, 5];
            ////ArrayOperations.ArrayGeneration(qq, 11, 50);
            //ArrayOperations.ArrayGeneration(qqnya, 2);
            //Magazin.Ashan.catalog();
            //StudentsSort.StudentsSort.StudentSort();
            Peacful Builder = new Peacful("Builder", 50,1,10 , 15, 30, 10);
            Console.WriteLine($"Имя - {Builder.name} \t Здоровье - {Builder.MaxHealth} \t Урон - /*damage*/ \t Броня - {Builder.armor} \t Скорость - {Builder.speed} \t Скорость атаки - {Builder.workspeed}");

            Peacful Woodman = new Peacful("Woodman", 60,1, 10, 15, 40, 15);
            Console.WriteLine($"Имя - {Woodman.name} \t Здоровье - {Woodman.MaxHealth} \t Урон - Woodman.damage \t Броня - {Woodman.armor} \t Скорость - { Woodman.speed} \t Скорость атаки - {Woodman.workspeed}");

            Peacful Miner = new Peacful("Miner", 65,1, 10, 15, 45, 20);
            Console.WriteLine($"Имя - {Miner.name} \t Здоровье - {Miner.MaxHealth} \t Урон - Miner.damage \t Броня - {Miner.armor} \t Скорость - {Miner.speed} \t Скорость атаки - {Miner.workspeed}");

            Warior Warior = new Warior("Warior", 100, 100, 30, 50, 50, 20, 45);
            Console.WriteLine($"Имя - {Warior.name} \t Здоровье - {Warior.MaxHealth}  Урон - Warior.damage \t Броня - {Warior.armor} \t Скорость - {Warior.speed} \t Скорость атаки - {Warior.atackspeed}");

            Figters Mage = new Figters("Mage", 120, 120,10,20, 70, 100, 45,50, 30, 30);
            Console.WriteLine($"Имя - {Mage.name} \t Здоровье - {Mage.MaxHealth}  Урон - Mage.damage  \t Броня - {Mage.armor} \t Скорость - {Mage.speed} \t Скорость атаки - {Mage.atackspeed}");

            Healer Healer = new Healer("Healer", 100, 100, 5, 15, 10, 25, 10, 50);
            Console.WriteLine($"Имя - {Healer.name} \t Здоровье - {Healer.MaxHealth}  Урон - Mage.damage  \t Броня - {Healer.armor} \t Скорость - {Healer.speed} \t Скорость атаки - {Healer.Healing}");

            Figters Archer = new Figters("Archer", 80, 80,15,25, 60, 80, 30,100, 40, 40);
            Console.WriteLine($"Имя - {Archer.name} \t Здоровье - {Archer.MaxHealth} \t Урон - Archer.damage \t Броня - {Archer.armor} \t Скорость - {Archer.speed} \t Скорость атаки - {Archer.atackspeed}");
            Console.WriteLine();

            Peacful.Moving(Builder.name); Peacful.Moving(Woodman.name); Peacful.Moving(Miner.name);
            Console.WriteLine();

            Figters.Moving(Archer.name); Figters.Moving(Warior.name); Figters.Moving(Mage.name);
            Console.WriteLine();

            Figters.ArcherDamage(Archer.name, Archer.MinRangeDamage, Archer.MaxRangeDamage,Warior.name,Warior.CurrentHealth,Archer.CurrentArrows);

            
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

        //    Builder Builder = new Builder("Builder", 50, 10, 15, 30, 10);
        //    Console.WriteLine($"Имя - {Builder.name} \t Здоровье - {Builder.health} \t Урон - {Builder.damage} \t Броня - {Builder.armor} \t Скорость - {Builder.speed} \t Скорость атаки - {Builder.atackspeed}");

        //    Woodman Woodman = new Woodman("Woodman", 60, 10, 15, 40, 15);
        //    Console.WriteLine($"Имя - {Woodman.name} \t Здоровье - {Woodman.health} \t Урон - {Woodman.damage} \t Броня - {Woodman.armor} \t Скорость - { Woodman.speed} \t Скорость атаки - {Woodman.atackspeed}");

        //    Miners Miner = new Miners("Miner", 65, 10, 15, 45, 20);
        //    Console.WriteLine($"Имя - {Miner.name} \t Здоровье - {Miner.health} \t Урон - {Miner.damage} \t Броня - {Miner.armor} \t Скорость - {Miner.speed} \t Скорость атаки - {Miner.atackspeed}");

        //    Wariors Warior = new Wariors("Warior", 100, 50, 50, 20, 45);
        //    Console.WriteLine($"Имя - {Warior.name} \t Здоровье - {Warior.health}  Урон - {Warior.damage} \t Броня - {Warior.armor} \t Скорость - {Warior.speed} \t Скорость атаки - {Warior.atackspeed}");

        //    Mages Mage = new Mages("Mage", 120, 100, 45, 30, 30);
        //    Console.WriteLine($"Имя - {Mage.name} \t Здоровье - {Mage.health}  Урон - {Mage.damage}  \t Броня - {Mage.armor} \t Скорость - {Mage.speed} \t Скорость атаки - {Mage.atackspeed}");

        //    Archers Archer = new Archers("Archer", 80, 90, 30, 40, 40);
        //    Console.WriteLine($"Имя - {Archer.name} \t Здоровье - {Archer.health} \t Урон - {Archer.damage} \t Броня - {Archer.armor} \t Скорость - {Archer.speed} \t Скорость атаки - {Archer.atackspeed}");
        //}
    }
}
