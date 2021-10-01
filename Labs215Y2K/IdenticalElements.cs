using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class IdenticalElements
    {
        public static void ex3()
        {
            int[] array1 = new int[10];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(10, 40);
                Console.Write($" {array1[i]}");
            }
            Console.WriteLine("");
            int[] array2 = new int[10];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(10, 60);
                Console.Write($" {array2[i]}");
            }

            Console.WriteLine("");

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        Console.WriteLine(array1[i]);
                        break;
                    }
                }
            }
        }               
    } 
    
}
