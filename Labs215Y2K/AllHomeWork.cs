using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class AllHomeWork
    {
        public void Bot001()
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("Как тебя зовут?");
            string answer = Console.ReadLine();
            Console.WriteLine($"Отлично, {answer}! Расскажи о себе. Сколько тебе лет?");
            answer = Console.ReadLine();
            Console.WriteLine("Ничего себе! И на каком курсе ты учишься?");
            answer = Console.ReadLine();
            Console.WriteLine($"Я тебя понял, {answer}. Был рад знакомству с тобой. До встречи!");
        }
        public void Arrmax()
        {
            int[,] array = new int[5, 5];
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = new Random().Next(100);
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();

            }
            int max = array[0, 0];
            for (int y = 0; y < array.GetLength(0); y++)
            {

                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (array[y, x] > max)
                    {
                        max = array[y, x];

                    }

                }
                Console.WriteLine(max);
                max = 0;
            }
            Console.ReadKey();
        }
        public void Cycless()
        {
            Console.WriteLine("Введите число, которое необходимо возвести в степень");
            double a = double.Parse(Console.ReadLine());
            double b = 1;
            Console.WriteLine("Введите степень, в которую необходимо возвести число");
            int stepen = int.Parse(Console.ReadLine());
            if (stepen >= 0)
            {
                for (int i = 0; i < stepen; i++)
                    b = a * b;
            }

            else
            {
                while (stepen < 0)
                {
                    stepen = stepen + 1;
                    b = b * (1 / a);
                }
            }

            Console.WriteLine(b);
            Console.ReadKey();
        }
        public void Reverse()
        {
            Console.WriteLine("Введите число, которое необходимо перевернуть");
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                Console.Write(a % 10);
                Console.Write(a);
            }
        }
        public static void ArraySumLine()
        {
            Random z = new Random();
            int[,] array = new int[3, 3];

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = z.Next(10, 100);
                    Console.Write($"{ array[y, x]} ");

                }
                Console.WriteLine();
            }

            int sum = 0;

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    sum += array[y, x];
                }
                Console.WriteLine(sum);
                sum = 0;
            }
            Console.ReadKey();
            Console.WriteLine(sum);
        }
    }
}