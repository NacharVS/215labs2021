using System;

namespace Площадь_поверхности_шара
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Площадь поверхности шара находится по формуле: S = 4пR^2");
            Console.WriteLine();
            Console.WriteLine("Введите R: ");
            int r = int.Parse(Console.ReadLine());
            double S = 4 * Math.PI * (r * r);
            Console.WriteLine($"Площадь поверхности шара = {S}");
        }
    }
}
