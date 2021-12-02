using System;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayGlobal = new int[5, 5];
            ArrayOperations.TwoDimensionalArrayGeneration(arrayGlobal);
            int[,] arrayGlobal2 = new int[5, 5];
            Console.WriteLine();
            ArrayOperations.TwoDimensionalArrayGeneration(arrayGlobal2);
            Console.WriteLine(arrayGlobal[1,1]);

        }       
    }
}
