using System;

namespace zadanie2
{
    class Переворот
    {
        static void ПереворотЧисла(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                {
                    Console.Write(number % 10);
                    number = number / 10;
                }
            }


        }
    }
}