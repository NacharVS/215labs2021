using System;

namespace Закон_Ома
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Закон Ома для участка цепи находится по формуле: I = U/R");
            Console.WriteLine();
            Console.WriteLine("Введите напряжение U: ");
            int U = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление R: ");
            int R = int.Parse(Console.ReadLine());
            double I = U/R;
            Console.WriteLine($"Закон Ома для участка цепи = {I}");
        }
    }
}
