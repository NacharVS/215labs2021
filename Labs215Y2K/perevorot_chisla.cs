using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class perevorot_chisla
    {
        public static void r1()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-50, 50);
                
                if (array[i]<0)
                {
                    Console.Write($" {array[i]}");
                }
            }
        }
        public static void r2()
        {
            int[] array = new int[10];
            int maxnumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($" {array[i]}");
                {
                    if (maxnumber < array[i])
                    {
                        maxnumber = array[i];
                        
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine($"Максимальное число массива: {maxnumber}");
        }
        public static void r3()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 10);
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine("");
            int[] array1 = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = new Random().Next(0, 10);
                Console.Write($" {array1[i]} ");
            }
            Console.WriteLine();
            Console.Write("-----------------------------------");
            Console.WriteLine();
            int[] array2 = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array1[i] + array[i];
                Console.Write($" {array2[i]} ");
            }

        }
        
            
        
    }
}
