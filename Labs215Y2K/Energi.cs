using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Energi
    {
        public static void ex7()
        {
            Console.WriteLine("Введите маасу и высоту");
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int g = 10;
            int F = h * m * g;
            Console.WriteLine($"Энергия равна =" + F + "Н/кг");
        }
    }
}
