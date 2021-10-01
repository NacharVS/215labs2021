using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class maxmin
    {
        public void Arrs()
        {
            int[] Myarray = new int[10];
            for (int i = 0; i < Myarray.Length; i++)
            {
                Myarray[i] = new Random().Next(0, 100);
                Console.Write($" {Myarray[i]}");
            }

            Console.WriteLine();
            Console.Write("для поиска минимального и максимального элемента нажмите ENTER:");
            Console.ReadLine();
            int min = Myarray[0];
            int max = Myarray[0];
            for (int i = 0; i < Myarray.Length; i++)
            {
                if (min > Myarray[i])
                    min = Myarray[i];
                if (max < Myarray[i])
                    max = Myarray[i];

            }
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine($"минимальный элемент:{min} Максимальный элемент:{max}");
            Console.ReadLine();
        }
    }
}
