using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class bot
    {
        public static void bott()
        {
            Console.ReadLine();
            Console.WriteLine("Привет!Как тебя зовут?Сколько тебе лет?");
            Console.ReadLine();
            Console.WriteLine("Меня зовут Харитон - я бот для общения!Как твои дела?");
            string a1 = Console.ReadLine();
            if (a1 == "Отлично")
            {
                Console.WriteLine("Понятно. Чем увлекаешься?");
            }
            else if (a1 == "Хорошо")
            {
                Console.WriteLine("Понятно. Чем увлекаешься?");
            }
            else
            {
                Console.WriteLine("Почему?");
            }
            string c = Console.ReadLine();
            string d = "Футболом";
            string e = "Игрой на пианино";
            string f = "Программированием";
            string k = "Плохо с оценками";
            string l = "Не успеваю";
            if (c == d)
            {
                Console.WriteLine("Понятно. Как дела с учёбой?");
            }
            else if (c == e)
            {
                Console.WriteLine("Понятно. Как дела с учёбой?");
            }
            else if (c == f)
            {
                Console.WriteLine("О!Как и я!Молодец, а как дела с учёбой?");
            }
            else
            {
                Console.WriteLine("Тогда погуляй или отдохни. Должно помочь. А чем ты увлекаешься?");
            }
            string g = Console.ReadLine();
            if (g == d)
            {
                Console.WriteLine("Понятно. Как дела с учёбой?");
            }
            else if (g == e)
            {
                Console.WriteLine("Понятно. Как дела с учёбой?");
            }
            else if (g == f)
            {
                Console.WriteLine("О!Как и я!Молодец, а как дела с учёбой?");
            }
            else if (g == k)
            {
                Console.WriteLine("Постарайся улучшить ситуацию! Нам пора прощаться");
            }
            else if (g == "Отлично")
            {
                Console.WriteLine("Ты молодец! Нам пора прощаться!");
            }
            else if (g == "Хорошо")
            {
                Console.WriteLine("Ты молодец! Нам пора прощаться!");
            }
            else
            {
                Console.WriteLine("Постарайся успевать!");
            }
            string s = Console.ReadLine();
            if (s == k)
            {
                Console.WriteLine("Постарайся улучшить ситуацию! Мне пора, я побежал. Удачи!");
            }
            else if (s == l)
            {
                Console.WriteLine("Постарайся успевать! Мне пора, я побежал, удачи!");
            }
            else
            {
                Console.WriteLine("Пока! Мне пора бежать. Приятно было познакомиться");
            }
        }
    }
}
