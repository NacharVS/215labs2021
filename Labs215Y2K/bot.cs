using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class bot
    {
        public static void ex1()
        {
         
            {
                Console.WriteLine("Добро пожаловать!");
                Console.WriteLine("Как тебя зовут?");
                string name = Console.ReadLine();
                Console.WriteLine($"Добро пожаловать в нашу семью {name}");
                Console.WriteLine($"Сколько тебе лет {name}");
                int years = int.Parse(Console.ReadLine());
                if (18 > years)
                {
                    Console.WriteLine("Оо ты младше меня!");
                }
                if (18 < years)
                {
                    Console.WriteLine("Старик!!!");
                }
                if (18 == years)
                {
                    Console.WriteLine("О мы с тобой одногодки!");
                }

                Console.WriteLine($"Хорошо что познакомились! {name}");
            }
        }
    }
}
