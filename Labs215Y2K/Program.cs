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
            StudentsSort.StudentsSort.StudentSort();
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
            Units.Builder Builder = new Units.Builder("Builder", 50, 10, 5, 30, 10);
            Console.WriteLine($"{Builder.name} {Builder.health} {Builder.damage} { Builder.armor} { Builder.speed} { Builder.atackspeed}");

            Units.Lumberjack Lumberjack = new Units.Lumberjack("Builder", 50, 10, 5, 30, 10);
            Console.WriteLine($"{Lumberjack.name} {Lumberjack.health} {Lumberjack.damage} { Lumberjack.armor} { Lumberjack.speed} { Lumberjack.atackspeed}");

            Units.Miners Miner = new Units.Miners("Builder", 50, 10, 5, 30, 10);
            Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

            Units.Wariors Warior = new Units.Wariors("Builder", 50, 10, 5, 30, 10);
            Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

            Units.Mages Mage = new Units.Mages("Builder", 50, 10, 5, 30, 10);
            Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

            Units.Archers Archer = new Units.Archers("Builder", 50, 10, 5, 30, 10);
            Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");
        }
    }
}

    }
}
