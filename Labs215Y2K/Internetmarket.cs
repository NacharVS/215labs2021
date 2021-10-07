using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Internetmarket
    {
        public static void catalog()
        {
            string[] array = new string[10];
            for (int i = 0; i < array.Length; i++)
            {
                string a = "Буханка хлеба 30р";
                array[i] = a;
                Console.Write($" {array[i]}");
                Console.WriteLine();
            }
        }
    }
}
