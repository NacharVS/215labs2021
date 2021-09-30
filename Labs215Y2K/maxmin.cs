using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class maxmin
    {
        public static void Ex1() 
        {
            int[] array = new int[10];
            Random z = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = z.Next(100);
                Console.WriteLine(array[i]);
            }

            int max = array[0];
            int min = array[0];


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }


            Console.WriteLine("min" + min);
            Console.WriteLine("max" + max);
            Console.ReadKey();
        }
    }
}
