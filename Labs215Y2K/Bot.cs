using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Bot
    { 
        public static void ex10()
        {
            string
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Приятно познокомиться {name}");
            Console.WriteLine($"Сколько вам лет {name}");
            int years = int.Parse(Console.ReadLine());
            if (18 > years)
            {
                Console.WriteLine("Вы ещё молодой!");
            }
            if (18 < years)
            {
                Console.WriteLine("Вы уже старый");
            }
            if (18 == years)
            {
                Console.WriteLine("Вы такого же возраста что и я");
            }
                
                Console.WriteLine($"Приятно было с вами познакомиться! {name}");
        }
    }
}
