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
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 100);
                Console.Write($" {array[i]}");
            }
            Console.WriteLine();
            Console.Write("Для вывода минимального элемента нажмите ENTER");
            Console.ReadLine();
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            Console.WriteLine("");
            Console.WriteLine("минимальный элемент:" + min);
            Console.ReadLine();
        }
    }
}
