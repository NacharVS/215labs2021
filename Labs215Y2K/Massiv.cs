using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Massiv
    {
        public static void ex1()
        {
            int[] mas = new int[10];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
                mas[i] = r.Next(0, 100);
            for (int i = 0; i < mas.Length; i++)
                Console.Write(mas[i] + " ");
            Console.WriteLine();
            int min, max;
            min = max = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (min > mas[i])
                {
                    min = mas[i];
                }
                if (max < mas[i])
                {
                    max = mas[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Макс {max}");
            Console.WriteLine($"Мин {min}");

        }
          
        
            

    }
}
