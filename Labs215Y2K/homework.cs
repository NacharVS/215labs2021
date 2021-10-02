using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class homework
    {
        public static void ex1()
        {
            Console.WriteLine("Привет, меня зовут Серёжа! А как тебя зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);
            Console.WriteLine("Как дела?");
            string dela = Console.ReadLine();
            Console.WriteLine("У меня тоже.");
            Console.WriteLine("Что делаешь?");
            String delaesh = Console.ReadLine();
            Console.WriteLine("Я сейчас занят, пока.");
        }
        public static void ex2()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            if (b == 0)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= b; i++)
                {
                    a = a * c;
                }
                Console.WriteLine(a);
            }
        }

    }
}
