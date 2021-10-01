using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class IdenticalElements
    {
        public static void ex3()
        {
            int[] array = new int[10];
            int[] array2 = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($"{array}");
            }
            Console.WriteLine();
            for (int j = 0; j < array.Length; j++)
            {
                array2[j] = new Random().Next(0, 100);
                Console.Write($"{array2}");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array2[j])
                    {
                        Console.Write($"{array[i]}");
                    }
                }
            }
            Console.WriteLine();

        }
    } 
    
}
