using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Diagonal
    {
        public void main002(string[] args)
        {
            int R = 0, C = 0;
            Console.WriteLine("Введите число строк и столбцов матрицы");
            Console.Write("Число строк = ");
            R = int.Parse(Console.ReadLine());
            Console.Write("Число столбцов = ");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] array = new int[R, C];
            int sum = 0;
            for (int r = 0; r < R; r++)
            {
                for (int c = 0; c < C; c++)
                {
                    array[r, c] = new Random().Next(0, 100);
                }
                if (r < R && r < C)
                    sum += array[r, r];
            }

            Console.WriteLine("Создана матрица M[R,C] случайных чисел");
            Console.WriteLine();
            for (int r = 0; r < R; ++r)
            {
                for (int c = 0; c < C; ++c)
                {
                    Console.Write(array[r, c] + " \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Результат");
            Console.WriteLine();
            Console.WriteLine("Сумма диагонали матрицы = " + sum);
            Console.ReadKey();
        }
    }
}
