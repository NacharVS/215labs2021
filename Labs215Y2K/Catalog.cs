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
                    Catalog.pay();
                if (a == "Н")
                    Catalog.pay();
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

            Console.WriteLine(z + "." + products[i]);
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


        int totalsum = 0;
        int localsum = 0;
        int grSUM = 0;
        int grammcount = 0;
        Console.WriteLine("Приветствуем в нашем онлайн-магазине 'Идель'");
        Console.WriteLine("На данный момент Ваша корзина пуста. давайте сделаем заказ!");
        Console.WriteLine("Введите количество продуктов, которое Вы собираетесь приобрести.");
        Console.WriteLine("Оно не должно превышать 4, так как наш ассортимент мал. Также нельзя ввести число 0. Наример: 1.");

        int countNUMB = int.Parse(Console.ReadLine());

        if (countNUMB != 0)
        {

            for (int i = 0; i < countNUMB; i++)
            {
                Console.WriteLine("Введите номер товара, который хотите приобрести");
                int a = int.Parse(Console.ReadLine());
                if (a >= 0 && a < 10)
                {
                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Введите количество приобретаемого товара. Цена указана за штуку.");
                        int count = int.Parse(Console.ReadLine());
                        localsum += prices[a] * count;
                        totalsum += localsum;
                        Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х" + count + " = " + localsum + " руб");
                        localsum = 0;

                    }
                    if (a % 2 != 0)
                    {

                        Console.WriteLine("Введите количество грамм, кратное 100.");
                        grammcount = int.Parse(Console.ReadLine());
                        if (grammcount % 100 == 0)
                        {
                            localsum += prices[a] * grammcount / 100;
                            totalsum += localsum;
                            Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                            localsum = 0;
                        }
                        //не факт
                        else
                        {
                            Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число.");
                            Console.WriteLine("Введите количество грамм, кратное 100.");
                            grammcount = int.Parse(Console.ReadLine());
                            if (grammcount % 100 == 0)
                            {
                                localsum += prices[a] * grammcount / 100;
                                totalsum += localsum;

                                Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                                localsum = 0;

                            }
                            if (grammcount % 100 != 0)
                            {
                                Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число.");
                                Console.WriteLine("Введите количество грамм, кратное 100.");
                                grammcount = int.Parse(Console.ReadLine());
                                if (grammcount % 100 == 0)
                                {
                                    localsum += prices[a] * grammcount / 100;
                                    totalsum += localsum;
                                    Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                                    localsum = 0;
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
            Console.WriteLine($"Итого к оплате: {totalsum} рублей.");
            Console.ReadKey();
        }
        else
            Console.WriteLine("Ошибка! Позиций не может быть 0. Перезапустите программу!");
        Console.ReadKey();
    }
}
   

     
