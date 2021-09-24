using System;
namespace Плоащдьшара
{
    class Площадьшара
    {
        static void площадь(string[] args)
        {

            Console.WriteLine("Vvedite r");
            int r = int.Parse(Console.ReadLine());
            double result = 4 * Math.PI * Math.Pow(r, 2);
            Console.WriteLine(result);
        }
    }
}