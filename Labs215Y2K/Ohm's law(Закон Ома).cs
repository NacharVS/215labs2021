using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Ohm_s_law_Закон_Ома_
    {
        public static void Ex() 
        {
            Console.WriteLine("Закон Ома для участка цепи находится по формуле: I = U/R");
            Console.WriteLine("Введите напряжение U ");
            int U = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление R ");
            int R = int.Parse(Console.ReadLine());
            double I = U / R;
            Console.WriteLine($"Закон Ома для участка цепи = {I}");
        }
    }
}
