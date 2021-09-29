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
                array[i] = new Random().Next(1, 100);
                array2[i] = new Random().Next(1, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i]==array2[j])
                    {
                        Console.WriteLine($"Found a identical elem:{array[i]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
