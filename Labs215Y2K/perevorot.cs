using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class perevorot
    {
        public static void Ex7() 
        {
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                {
                    Console.Write(number % 10);
                    number = number / 10;
                }
            }

            Console.WriteLine();
        }
    }
}
