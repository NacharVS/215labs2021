using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class square
    {
        public static void Ex6() 
        {
            Console.WriteLine("Введите r");
            int r = int.Parse(Console.ReadLine());
            double result = 4 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
