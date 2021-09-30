using System;

namespace Поменять_значения_A_и_B
{
    class exchange
    {
       public static void ex5()
        {
            int a = 5;
            int b = 2;
            Console.WriteLine("Было:");
            Console.WriteLine("a = 5");
            Console.WriteLine("b = 2");
            Console.WriteLine();
            Console.WriteLine("Стало: ");
            a = (a + b) - a;
            b = (a * 5 ) /2 ;
            Console.WriteLine($"a = {a} ");
            Console.WriteLine($"b = {b} ");
        }
    }
}
