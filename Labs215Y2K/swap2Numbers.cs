using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class swap2Numbers
        //перевернуть два заданных числа местами
    {
        public static void exercise()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            string resultfirst = "a = ";
            string resultsecond = "b = ";
            Console.WriteLine(resultfirst + a);
            Console.WriteLine(resultsecond + b);
            Console.WriteLine();
        }
    }
}
