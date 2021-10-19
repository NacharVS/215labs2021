using System;

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
            Program.UnitsCreator();
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

        public static void UnitsCreator()
        {

            Units.Builder Builder = new Units.Builder("Builder", 50, 10, 15, 30, 10);
            Console.WriteLine($"Имя - {Builder.name} Здоровье - {Builder.health} Урон - {Builder.damage} Броня - {Builder.armor} Скорость - {Builder.speed} Скорость атаки - {Builder.atackspeed}");

            Units.Lumberjack Lumberjack = new Units.Lumberjack("Lumberjack", 60, 10, 15, 40, 15);
            Console.WriteLine($"Имя - {Lumberjack.name} Здоровье - {Lumberjack.health} Урон - {Lumberjack.damage} Броня - {Lumberjack.armor} Скорость - { Lumberjack.speed} Скорость атаки - {Lumberjack.atackspeed}");

            Units.Miners Miner = new Units.Miners("Miner", 65, 10, 15, 45, 20);
            Console.WriteLine($"Имя - {Miner.name} Здоровье - {Miner.health} Урон - {Miner.damage} Броня - {Miner.armor} Скорость - {Miner.speed} Скорость атаки - {Miner.atackspeed}");

            Units.Wariors Warior = new Units.Wariors("Warior", 100, 50, 50, 20, 45);
            Console.WriteLine($"Имя - {Warior.name} Здоровье - {Warior.health} Урон - {Warior.damage} Броня - {Warior.armor} Скорость - {Warior.speed} Скорость атаки - {Warior.atackspeed}");

            Units.Mages Mage = new Units.Mages("Mage", 120, 100, 45, 30, 30);
            Console.WriteLine($"Имя - {Mage.name} Здоровье - {Mage.health} Урон -{Mage.damage} Броня -{Mage.armor} Скорость - {Mage.speed} Скорость атаки - {Mage.atackspeed}");

            Units.Archers Archer = new Units.Archers("Archer", 80, 90, 30, 40, 40);
            Console.WriteLine($"Имя - {Archer.name} Здоровье - {Archer.health} Урон - {Archer.damage} Броня - {Archer.armor} Скорость - {Archer.speed} Скорость атаки - {Archer.atackspeed}");
        }
    }
}
