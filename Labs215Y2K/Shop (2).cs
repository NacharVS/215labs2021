using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Shop

    {
        public static void realbasket(int totalsum, int[] prices, string[] products, int numb)
        {

            Console.WriteLine("Ваша корзина:");
            // krivo rabotaet

            for (int i = 0; i < numb; i++)
            {

                Console.WriteLine(products[i] + $"({prices[i]} руб/шт)");
            }

        }
        static void Main(string[] args)
        {
            string[] products = new string[10];
            products[0] = " Зубная паста";
            products[1] = " Конфеты 'коровка' (на развес)";
            products[2] = " Туалетная бумага";
            products[3] = " Гречневая крупа (на развес)";
            products[4] = " Зубная щётка";
            products[5] = " Рисовая крупа (на развес)";
            products[6] = " Буханка хлеба";
            products[7] = " Сахар (на развес)";
            products[8] = " Жевательная резинка 'Dirol'";
            products[9] = " Соль (на развес)";



            int[] prices = new int[10];
            prices[0] = 110;
            prices[1] = 25;
            prices[2] = 15;
            prices[3] = 6;
            prices[4] = 65;
            prices[5] = 7;
            prices[6] = 30;
            prices[7] = 3;
            prices[8] = 30;
            prices[9] = 4;

            int numb = 1;
            Console.WriteLine("Введите 'Д', чтобы посмотреть список товаров");
            Console.WriteLine("Введите 'З', чтобы посмотреть корзину");
            string a = Console.ReadLine();
            if (a == "Д")
            {
                Shop.buy(prices, products);
                Console.WriteLine("Если Вы хотите вернуться в корзину, введите 'З'");
                string b = Console.ReadLine();
                if (b == "З")
                    Shop.basket(prices, products, numb);

            }
            if (a == "З")
                Shop.basket(prices, products, numb);
            else
                Console.WriteLine("Вы ввели неверный символ. Соблюдайте регистры букв!");
            Console.ReadKey();





        }

        public static void buy(int[] prices, string[] products)
        {


            int z = 0;
            for (int i = 0; i < products.Length; i++)
            {

                Console.WriteLine(z + "." + products[i]);
                if (i % 2 != 0)
                    Console.WriteLine(prices[i] + " руб за 100г");
                else
                    Console.WriteLine(prices[i] + " руб");
                z++;
            }
            Console.WriteLine("WARNING: Числа перед наименованием товара - номер товара.");

        }


        public static void basket(int[] prices, string[] products, int numb)
        {


            int totalsum = 0;
            int localsum = 0;
            int grammcount = 0;
            Console.WriteLine("Приветствуем в нашем онлайн-магазине 'ScamShop'");
            Console.WriteLine("На данный момент Ваша корзина пуста. Давайте перейдём к покупкам!");




            string o;
            int besk = 1;



            while (besk == 1)
            {




                numb++;



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

                        else
                        {
                            Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число. Количество грамм ДОЛЖНО быть кратно сотне.");
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
                                Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число.Количество грамм ДОЛЖНО быть кратно сотне.");
                                Console.WriteLine("Введите количество грамм, кратное 100.");
                                grammcount = int.Parse(Console.ReadLine());
                                if (grammcount % 100 == 0)
                                {
                                    localsum += prices[a] * grammcount / 100;
                                    totalsum += localsum;

                                    Console.WriteLine("Вы добавили в корзину:" + products[a] + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                                    localsum = 0;
                                }
                            }
                        }
                    }


                }
                else
                    Console.WriteLine("Ошибка! Введите число от 0 до 9, предварительно перезапустив программу. У нас нет столько ассортимента!");

                Console.WriteLine("Введите 'Да', если хотите продолжить покупки");
                Console.WriteLine("Введите 'Нет', если хотите прекратить покупки.");


                o = Console.ReadLine();
                if (o == "Да")
                    continue;

                if (o == "Нет")
                {
                    Console.WriteLine($"Итого к оплате: {totalsum} рублей");

                    break;
                }
            }






            Console.WriteLine("Введите 'Щ', чтобы просмотреть содержимое своей корзины");
            string u = Console.ReadLine();
            if (u == "Щ")
            {

                Shop.realbasket(totalsum, prices, products, numb);

            }

            Console.WriteLine($"Итого к оплате: {totalsum} рублей.");
            Console.ReadKey();

        }


    }
}
