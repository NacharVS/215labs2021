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
        public static void ex3()
        {
            int U = int.Parse(Console.ReadLine());
            int R = int.Parse(Console.ReadLine());
            int I = U / R;
            Console.WriteLine("Сила тока = " + I);
        }
        public static void ex4()
        {
            int[] array = new int[10];
            int a = 0;
            int b = 0;
            int max = 0;
            int min = 10000000;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 100);

                Console.Write($" {array[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    a = array[i];
                    if (a > max)
                    {
                        max = a;
                    }
                }
                if (array[i] < array[i + 1])
                {
                    b = array[i];
                    if (min > b)
                    {
                        min = b;
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
        public static void ex5()
        {
            int number = int.Parse(Console.ReadLine());
            while (number >= 0)
            {
                if (number % 10 > 0)
                {
                    Console.Write(number % 10);
                    number = number / 10;
                }
                else
                    number = number / 10;
            }
        }
        public static void ex6()
        {
            Double R = Double.Parse(Console.ReadLine());
            Double S = 4 * Math.PI * Math.Pow(R, 2);
            Console.WriteLine($"Площадь поверхности шара " + S);
        }
    }
}
