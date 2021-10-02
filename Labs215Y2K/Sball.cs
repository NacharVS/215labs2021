using System;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Sball
    {
        static void Main(string[] args)
        {
            //Заполнить двумерный массив по следующему правилу, массив произвольной размерности, массив передается через параметр:
            //1 2 3 4 5
            //2 1 2 3 4
            //3 2 1 2 3
            //4 3 2 1 2
            //5 4 3 2 1

            int[,] arrayGlobal = new int[5, 5];
            ArrayOperations.TwoDimensionalArrayGeneration(arrayGlobal);
            int[,] arrayGlobal2 = new int[5, 5];
            Console.WriteLine();
            ArrayOperations.TwoDimensionalArrayGeneration(arrayGlobal2);
            Console.WriteLine(arrayGlobal[1,1]);



        }       
    }
}
