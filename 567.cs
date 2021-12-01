using System;

namespace ConsoleApp3
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в наш магазин Салават. Все цены в нашем магазине указаны за 100 грамм.");

            Console.WriteLine();
            double sum = 0;
            string[] mass1 = new string[10] {
            "Мука",
            "Макароны",
            "Печенье",
            "Конфеты",
            "Гречка",
            "Сушки",
            "Орехи",
            "Рис",
            "Пшено",
            "Попкорн"};

            double[] mass = new double[10] {
            40,
            150,
            160,
            200,
            90,
            170,
            460,
            120,
            100,
            150};

            for (int i = 0; i < mass1.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {mass1[i]} - цена {mass[i]} рублей");
            }
            //Console.WriteLine();
            Console.WriteLine("Если хотите закончить покупку, то введите число больше 10");
            Console.WriteLine();
            Console.WriteLine("Выбирайте товары:");
            int a = int.Parse(Console.ReadLine());

            while (a < 11)
            {
                Console.Write("Выберете нужное количество грамм: ");
                double b = double.Parse(Console.ReadLine());

                sum = b / 1000 * mass[a];
                Console.WriteLine("Выбирайте товары:");
                a = int.Parse(Console.ReadLine());
            }
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine("Ваша корзина наполнена след.товарами:");
                Console.WriteLine($" ");
            }

            Console.WriteLine("_________________________________");
            Console.WriteLine($"ИТОГО: {sum} рублей.");
            Console.WriteLine("магаз Салыч");
        }
    }
}
