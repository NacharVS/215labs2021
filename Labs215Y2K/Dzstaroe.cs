using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Dzstaroe
    {
        public static void n1()
        {
            int number, result = 0;

            Console.Write("enter number: ");
            number = Int32.Parse(Console.ReadLine());

            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            Console.WriteLine(result);
        }
        public static void n2()
        {
            Console.WriteLine("Привет, покупатель, как тебя зовут?");

            string name = (Console.ReadLine());

            Console.WriteLine($"Привет,это магазин кросовок, {name}, как твои дела?");

            string a = Console.ReadLine();

            if (true)
            {
                Console.WriteLine("Я рад, что у тебя все хорошо!");

            }

            Console.WriteLine("Какой цвет кросовок тебе нравятся больше? красный/желтый/синий/зеленый (Выберите цвет)");
            string b = "желтый";
            string c = "синий";
            string d = "красный";
            string f = "зеленый";
            string g = Console.ReadLine();
            if (g != b)
            {
                Console.WriteLine("Они очень маркие, выбери другой цвет");
            }
            else
            {
                Console.WriteLine("Какой цвет кросовок тебе нравятся больше ? красный / синий / зеленый");
                Console.ReadLine();

            }
            if (g == c)
            {
                Console.WriteLine("Отличный выбор!");
            }
            if (g != d)
            {
                Console.WriteLine("К сожалению,у нас закончился такой размер, выбери другой цвет");

            }
            else
            {
                Console.WriteLine("Какой цвет кросовок тебе нравятся больше? синий/зеленый");
                Console.ReadLine();
            }
            if (g != f)
            {
                Console.WriteLine("К сожалению, у нас закночился твой размер, выбери другой размер");

            }
            else
            {
                Console.WriteLine("Какой цвет кросовок тебе нравятся больше ? синий");
                Console.ReadLine();
            }
            Console.WriteLine("Сколько сантиметров длина твоей стопы?");

            int a1 = int.Parse(Console.ReadLine());
            if (a1 >= 25)
            {
                Console.WriteLine("У тебя большой размер ноги!!!");
            }
            else
            {
                Console.WriteLine("У тебя не очень большой размер ноги");
            }
            Console.WriteLine("Хорошо, теперь разберемся с русским размером обуви.Сколько см длина твоей стопы?");
            string n = Console.ReadLine();
            int p = int.Parse(n);
            double first = 1.5;
            double second = 0.5;
            double q = p * first + second;
            Console.WriteLine($"Русский размер твоей обуви: {q}");
            Console.WriteLine($"Отличный выбор, Ждем тебя снова, {name}!");
        }
        public static void n3()
        {
            Console.WriteLine("Введите число");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введие степень");

            int b = int.Parse(Console.ReadLine());

            int c = 1;

            for (int i = 1; i <= b; i++)
            {
                c = a * c;
            }
            Console.WriteLine($"Число {a} в {b} степени равно  {c}");
        }
        public static void n4()
        {
            Console.WriteLine("Введите сумму попыток замка");
            int mama = int.Parse(Console.ReadLine());
            for (int a = 0; a <= 9; a++)
            {
                for (int b = a + 1; b <= 9; b++)
                {
                    for (int c = b + 1; c <= 9; c++)
                    {
                        if ((a + b + c == mama) && (a != b) && (a != c) && (b != c))
                        {
                            Console.Write(a);
                            Console.Write(b);
                            Console.WriteLine(c);
                        }
                        else Console.Write("");
                    }
                }
            }
        }
    }
    
}
            
        
       
    

