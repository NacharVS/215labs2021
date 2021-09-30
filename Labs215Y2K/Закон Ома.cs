using System;

namespace Закон_Ома
{
    class Om
    {
        public static void ex3()
        {
            Console.WriteLine("Закон Ома для участка цепи находится по формуле: I = U/R");
            Console.WriteLine();
            Console.WriteLine("Введите напряжение U: ");
            double U = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление R: ");
            double R = int.Parse(Console.ReadLine());
            double I = U/R;
            Console.WriteLine($"Закон Ома для участка цепи = {I}");
        }
    }
}
