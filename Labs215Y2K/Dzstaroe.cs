using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Dzstaroe
    {
        public static void n1()
        {
            int number, result = 0;

            Console.Write("enter number: ");
            number = Int32.Parse(Console.ReadLine());

            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            Console.WriteLine(result);
        }
    }
}
