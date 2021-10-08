using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    internal class Program2
    {
        static void main(string[] args)
        {
            int[,] array = new int[5, 5];
            int[] array2 = new int[5];

            ArrayOperations.ArrayGeneration(array, 100, 1000);
            ArrayOperations.ArrayGeneration(array2, 10);


        }
    }
}
