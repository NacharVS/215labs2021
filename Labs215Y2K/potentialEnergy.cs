using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class potentialEnergy
        //Найти потенциальную энергию
    {
        public static void ex()
        {
            Console.WriteLine("Введите массу и высоту ");
            int m = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int g = 10;
            int F = m * g * h;
            Console.WriteLine($"Потенциальная энергия равна {F}");
        }
    }
}
