using System;

namespace ALL_Homework
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {

                Console.WriteLine("Циклы - С");
                Console.WriteLine("Массивы - М1");
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
                }
                if (Vvod == "1")
                {
                    Console.Clear();

                }
            }
        }

    }
}


