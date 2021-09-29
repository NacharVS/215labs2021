using System;

namespace Labs215Y2K
{
    class Homework
    {
        public static void arraySUMstr()
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
        public static void reverse()
        {
            Console.WriteLine("Введите число, которое необходимо перевернуть");
            int a = int.Parse(Console.ReadLine());
            do
            {
                Console.Write(a % 10);
            }


            while ((a /= 10) != 0);
        }
        public static void cycles()
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
        public static void arraymax()
        {
            int[,] array = new int[5, 5];



            Random z = new Random();
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = z.Next(100);
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
        public static void SUMMAglavnoiDIAGONALI()
        {
            int[,] array = new int[5, 5];
            int sum = 0;
            int s = -1;


            Random z = new Random();
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    array[y, x] = z.Next(100);
                    Console.Write(array[y, x] + "\t");
                }
                Console.WriteLine();

            }


            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {

                }
                s++;
                sum += array[y, s];
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
        public static void arraysMINandMAX()
        {
            int[] array = new int[10];
            Random z = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = z.Next(100);
                Console.WriteLine(array[i]);
            }

            int max = array[0];
            int min = array[0];


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }


            Console.WriteLine("min" + min);
            Console.WriteLine("max" + max);
            Console.ReadKey();
        }
        public static void bot()
        {
            Console.WriteLine("Привет, студент!");
            Console.WriteLine("Давай знакомиться. Моё имя - Бот Стёпа. А тебя как я могу называть?");
            string abc = Console.ReadLine();
            Console.WriteLine($"Отлично, {abc}! Расскажи о себе подробнее. Сколько тебе лет?");
            Console.ReadLine();
            Console.WriteLine("Ничего себе! И на каком курсе ты учишься?");
            Console.ReadLine();
            Console.WriteLine($"Я тебя понял, {abc}. Был рад знакомству с тобой, дорогой друг. До встречи!");
        }


    }
}


     