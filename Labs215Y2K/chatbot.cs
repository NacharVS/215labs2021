using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class chatbot
    {
        public static void Ex4()
        {
            int ent;
            Console.WriteLine("Приветствие");
            Console.WriteLine("1)Дарова!");
            Console.WriteLine("2)Приветик");
            ent = Convert.ToInt32(Console.ReadLine());

            if (ent == 1)
            {
                Console.WriteLine("Саламалейкум");
                Console.WriteLine("");
            }
            else if (ent == 2)
            {
                Console.WriteLine("Здравия желаю!");
                Console.WriteLine("");
            }
            Console.WriteLine("Как дела?");
            Console.WriteLine("1)Как обычно");
            Console.WriteLine("2)Прекрасно");
            ent = Convert.ToInt32(Console.ReadLine());
            if (ent == 1)
            {
                Console.WriteLine("1)Ну это хорошо!");
                Console.WriteLine("");
            }
            else if (ent == 2)
            {
                Console.WriteLine("2)Понятно");
                Console.WriteLine("");
            }
            Console.WriteLine("Сколько тебе лет?");
            Console.WriteLine("1)17?");
            Console.WriteLine("2)16?");
            ent = Convert.ToInt32(Console.ReadLine());
            if (ent == 1)
            {
                Console.WriteLine("1)Понятно");
                Console.WriteLine("");
            }
            else if (ent == 2)
            {
                Console.WriteLine("1)Понятно");
                Console.WriteLine("");
            }
            Console.WriteLine("Где ты живешь?");
            Console.WriteLine("1)Казань");
            Console.WriteLine("2)Москва");
            ent = Convert.ToInt32(Console.ReadLine());
            if (ent == 1)
            {
                Console.WriteLine("1)Ммм, круто!");
                Console.WriteLine("");
            }
            else if (ent == 2)
            {
                Console.WriteLine("2)Далекоооо");
                Console.WriteLine("");
            }
            Console.WriteLine("Чем любишь заниматься?");
            Console.WriteLine("1)Программировать");
            Console.WriteLine("2)Спать");
            ent = Convert.ToInt32(Console.ReadLine());
            if (ent == 1)
            {
                Console.WriteLine("1)Класс! Программирование это круто!");
                Console.WriteLine("");
            }
            else if (ent == 2)
            {
                Console.WriteLine("2)Я тоже люблю поспать!");
                Console.WriteLine("");
            }
        }
    }
}
