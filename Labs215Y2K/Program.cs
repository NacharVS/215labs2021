using System;

namespace ALL_Homework
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {

                Console.WriteLine("Циклы - C");
                
                Console.WriteLine("Массивы двумерные - М2");
                Console.WriteLine("Очистить консоль - 1");
                string Vvod = Console.ReadLine();
                if (Vvod == "С")
                {
                    Console.WriteLine("Квадрат Числа - 1");
                    Console.WriteLine("Переворот числа - 2");
                    Console.WriteLine("Подбор домофона по сумме - 3");




                    string vvod = Console.ReadLine();

                    if (vvod == "1")
                    {
                        Cycle.Cycles.Sgrt();
                    }
                    if (vvod == "2")
                    {
                        Cycle.Cycles.Reversenubmer();

                    }
                    if (vvod == "3")
                    {
                        Cycle.Cycles.HackDoor();
                    }
                    if (vvod == "5")
                    {
                        Console.Clear();

                    }

                }
                if (Vvod == "M2")
                {
                    Console.WriteLine("Поменять столбцы местами - 1"); 
                    Console.WriteLine("Сумма строки матрицы - 2");
                    Console.WriteLine("Умножение матриц - 3");
                    Console.WriteLine("Максимальный элемент  в строке матрицы - 4"); 
                    Console.WriteLine("Сумма элементов главной матрицы - 5"); 
                    Console.WriteLine("Минимальный элемент в строке в матрицы - 6");




                    string vvod = Console.ReadLine();

                    if (vvod == "1")
                    {
                        ArrayM2.CreateArray();
                    }
                    if (vvod == "2")
                    {
                        ArrayM2.sumMatrix();
                    }
                    if (vvod == "3")
                    {
                        ArrayM2.MatrixNAmatritcy();
                    }
                    if (vvod == "4")
                    {
                        ArrayM2.MaxElementMatritci();
                    }
                    if (vvod == "5")
                    {
                        ArrayM2.MIDDioganal();
                    }
                    if (vvod == "6")
                    {
                        ArrayM2.MinElementMatritci();
                    }
                    if (vvod == "7")
                    {
                        Console.Clear();

                    }
                }
                if (Vvod == "1")
                {
                    Console.Clear();

                }
            }
        }

    }
}


