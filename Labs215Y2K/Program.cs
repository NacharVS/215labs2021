using System;
using System.Linq;

namespace Deletor
{
    public class MainClass
    {
        public static void Main()
        {
            int[,] array = new int[10, 10];
            int[] arraytwo = new int[10];
            int maxValue = 10;
            int sum = 0;

            //MaxMin.Maxmin.ex1(); // - максимальный элемент массива
            //Multplus.MultPlus.ex2();  // - Сумма и умножение массива
            //MaxElement.MaxElem.ex3(); // - Максимальный элемент в каждой строке
            //SumMatrix.SumMatrix.ex4(); // - Сумма каждой строки матрицы
            // SwapArray.Swap.ex5(); // - Меняет местами строки массива
            //TwoIdentElementDeletor.Deletor.ex7(); // - находит одинаковые числа в массиве
            // MatrixMult.Matrix.ex6(); // - Произведение двух матриц
            //Fill.Matrix.ex10(array);
            //Labs215Y2K.SummId.SummIdSort();
            //StudentsListsOperation();

            //UnitsCreator();

            //Console.WriteLine();
            //Labs215Y2K.ArrayOperations.ArrayGeneration(arraytwo,5,500);
            Magazin.Ashan.catalog();

        }
        public static void magaz(int[] numberofproduct, int yesno, string[] catalog, string[] korzina, int counter, int cycleoperation, int[] countofproduct, int[] korzinakolvo, int[] price, int[] Sum, int[] sumtwo, int[] korzinaprice)
        {
            int cou = 1;
            int pricecounter = 0;
            while (cycleoperation > 1)
            {
                Console.WriteLine("Выберите номер товара: ");
                numberofproduct[cou] = int.Parse(Console.ReadLine());
                Console.WriteLine("Выберите кол-во товара(товары на развес указывать в граммах с шагом в 100): ");
                countofproduct[cou] = int.Parse(Console.ReadLine());
                if (numberofproduct[pricecounter] < 6)
                {
                    Sum[pricecounter] += price[numberofproduct[pricecounter]] * countofproduct[pricecounter];
                    korzinaprice[pricecounter] = Sum[pricecounter];
                }
                Console.WriteLine();
                if (numberofproduct[pricecounter] > 5 && countofproduct[pricecounter] % 100 == 0)
                {
                    int check = countofproduct[pricecounter] / 100;
                    sumtwo[pricecounter] += price[numberofproduct[pricecounter]] * check;
                    korzinaprice[pricecounter] = sumtwo[pricecounter];
                }
                else
                {
                    Console.WriteLine("Кол-во товаров нужно указывать строго с шагом в 100");
                }
                //if (numberofproduct[cou] != 0)
                //{
                //    korzina[counter] = catalog[numberofproduct[cou]];
                //    Console.Write($"Корзина: {korzina[counter]}");
                //    counter++;

                //}
                cou++;
                pricecounter++;
                cycleoperation--;
            }
            Console.WriteLine();
            Console.Write($"Товар:       Кол-во:         Цена за 1шт:");
            Console.WriteLine();
            for (int i = 0; i < numberofproduct.Length; i++)
            {
                korzina[counter] = catalog[numberofproduct[i]];
                Console.Write($"{  korzina[counter]}          ");
                Console.Write($"{  countofproduct[counter]}          ");
                korzinakolvo[counter] = price[numberofproduct[i]];
                Console.Write($"{  korzinakolvo[counter]}         ");
                Console.Write($"{  korzinaprice[counter]}         ");
                counter++;
                Console.WriteLine();
            }
        }
        public static void ArrayOfMatrixSum(int[,] array, int maxValue, int sum)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(maxValue);
                    Console.Write($"{array[i, j]} ");
                    sum += array[i, j];

                }
                Console.Write($" summ - {sum}");
                Console.WriteLine();
                sum = 0;
            }
        }
        public static void StudentsListsOperation()
        {
            while (true)
            {
                Console.WriteLine("Для того чтобы вызвать список студентов введите 1");
                Console.WriteLine("Для того чтобы вызвать список студентов с оценками введите 2");
                Console.WriteLine("Для того чтобы вызвать список студентов проживающих в общежитие введите 3");
                while (true)
                {
                    try
                    {
                        int vvod = int.Parse(Console.ReadLine());
                        if (vvod == 1)
                        {
                            Labs215Y2K.StudentsSort.StudentSort();
                        }
                        if (vvod == 2)
                        {
                            Labs215Y2K.MarkStudentsSort.MarksSort();
                        }
                        if (vvod == 3)
                        {
                            Labs215Y2K.StudentsList.MarksSort();
                        }
                        if (vvod > 3)
                        {
                            Console.WriteLine("Вы использовали не правильный номер");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ввод не корректных данных");
                        break;
                    }
                }

                Console.WriteLine();
            }
        }
        //public static void UnitsCreator()
        //{
        //    Units.Builder Builder = new Units.Builder("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {Builder.health} {Builder.damage} { Builder.armor} { Builder.speed} { Builder.atackspeed}");

        //    Units.Lumberjack Lumberjack = new Units.Lumberjack("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Lumberjack.name} {Lumberjack.health} {Lumberjack.damage} { Lumberjack.armor} { Lumberjack.speed} { Lumberjack.atackspeed}");

        //    Units.Miners Miner = new Units.Miners("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

        //    Units.Wariors Warior = new Units.Wariors("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

        //    Units.Mages Mage = new Units.Mages("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");

        //    Units.Archers Archer = new Units.Archers("Builder", 50, 10, 5, 30, 10);
        //    Console.WriteLine($"{Builder.name} {.health} {.damage} { .armor} { .speed} { .atackspeed}");
        //}
    }
}
