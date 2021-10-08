using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Catalog
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("здравствуйте, это сеть магазинов Идель.");
                Console.WriteLine("в нашем ассортименте вы можете найти следующие товары; гречка, горох, пшеница, рис" +
                    "Хотите осуществить покупку?");
                Console.WriteLine("напишите Д или Н");
                string a = Console.ReadLine();
                if (a == "Д")
                    Catalog.pay ();
                if (a == "Н")
                    Catalog.pay ();
            }
        }
    }

    public static void pay()
    {
        string[] products = new string[4];
        products[0] = "гречка";
        products[1] = "горох";
        products[2] = "пшеница";
        products[3] = "рис";

        int[] prices = new int[4];
        prices[0] = 11;
        prices[1] = 50;
        prices[2] = 20;
        prices[3] = 30;
    }

    public static void pay(int[] prices, string[] products)
    {


        int f = 0;
        for (int i = 0; i < products.Length; i++)
        {

            Console.WriteLine(f + "." + products[i]);
            if (i % 2 != 0)
                Console.WriteLine(prices[i] + " руб за 100г");
            else
                Console.WriteLine(prices[i] + " руб за 100г");
            f++;
        }
        Console.WriteLine("числа - номер товара");

    }


    public static void basket(int[] prices, string[] products)
    {
        int total = 0;
        int local = 0;
        int gr = 0;
        int gramm = 0;
        Console.WriteLine("Приветствуем в нашем онлайн-магазине 'Идель'");
        Console.WriteLine("На данный момент Ваша корзина пуста. давайте сделаем заказ!");
        Console.WriteLine("Введите количество продуктов, которое Вы собираетесь приобрести.");
        Console.WriteLine("Оно не должно превышать 4, так как наш ассортимент мал. Также нельзя ввести число 0. Наример: 1.");

        int NUMB = int.Parse(Console.ReadLine());

        if (NUMB != 0)
        {

            for (int i = 0; i < NUMB; i++)
            {
                Console.WriteLine("Введите номер товара, который хотите приобрести");
                int a = int.Parse(Console.ReadLine());
                if (a >= 0 && a < 10)
                {
                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Введите количество приобретаемого товара. Цена указана за штуку.");
                        int count = int.Parse(Console.ReadLine());
                        local += prices[a] * count;
                        total += local;
                        Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х" + count + " = " + local + " руб");
                        local = 0;

                    }
                    if (a % 2 != 0)
                    {

                        Console.WriteLine("Введите количество грамм, кратное 100.");
                        gramm = int.Parse(Console.ReadLine());
                        if (gramm % 100 == 0)
                        {
                            local += prices[a] * gramm / 100;
                            total += local;
                            Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х " + gramm + " г" + " = " + local + " руб");
                            local = 0;
                        }
                        //не факт что правильно
                        else
                        {
                            Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число.");
                            Console.WriteLine("Введите количество грамм, кратное 100.");
                            gramm = int.Parse(Console.ReadLine());
                            if (gramm % 100 == 0)
                            {
                                local += prices[a] * gramm / 100;
                                total += local;

                                Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х " + gramm + " г" + " = " + local + " руб");
                                local = 0;

                            }
                            if (gramm % 100 != 0)
                            {
                                Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число.");
                                Console.WriteLine("Введите количество грамм, кратное 100.");
                                gramm = int.Parse(Console.ReadLine());
                                if (gramm % 100 == 0)
                                {
                                    local += prices[a] * gramm / 100;
                                    total += local;

                                    Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х " + gramm + " г" + " = " + local + " руб");
                                    local = 0;
                                }
                                else
                                    Console.WriteLine("ОШИБКА! Товар не был добавлен.");
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("Ошибка! Введите число от 0 до 4. нас нет столько ассортимента!");
            }
            Console.WriteLine($"Итого к оплате: {total} рублей.");
            Console.ReadKey();
        }
        else
            Console.WriteLine("Ошибка! Позиций не может быть 0. Перезапустите программу!");
        Console.ReadKey();
    }
}
   

     
