using System;

namespace Возведениевстепень
{
    class Степень
    {
        static void Степенб(string[] args)
        {
            Console.WriteLine("Vvedite chislo");
            int chislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Vvedite stepenb");
            int stepenb = int.Parse(Console.ReadLine());
            int i = 1;
            while (i < stepenb)
            {
                chislo *= chislo;
                i++;
            }
            Console.WriteLine(chislo);
            Console.WriteLine();
        }
    }
}
