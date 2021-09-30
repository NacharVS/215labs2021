using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Massiv
    {
        public static void ex1()
        {
            int[] array = new int[10];         
            for (int i = 0; i < array.Length; i++)
                array[i] = new Random().Next(0, 100);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            int min, max;
            min = max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Макс {max}");
            Console.WriteLine($"Мин {min}");

        }
          
        
            

    }
}
