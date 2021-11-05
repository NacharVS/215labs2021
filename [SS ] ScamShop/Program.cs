using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScamShop
{
    class Program
    {
        
        Storage prod1 = new Storage(80, 50, " Зубная паста");
        Storage prod2 = new Storage(25, 20000, " Конфеты 'коровка' (на развес)");
        Storage prod3 = new Storage(15, 100, " Туалетная бумага");
        Storage prod4 = new Storage(6, 100000, " Гречневая крупа (на развес)");
        Storage prod5 = new Storage(65, 100, " Зубная щётка");
        Storage prod6 = new Storage(7, 100000, " Рисовая крупа(на развес)");
        Storage prod7 = new Storage(30, 100, " Буханка хлеба");
        Storage prod8 = new Storage(3, 100000, " Сахар (на развес)");
        Storage prod9 = new Storage(25, 60, " Жевательная резинка 'Dirol'");
        Storage prod10 = new Storage(4, 100000, " Соль (на развес)");



        static void Main(string[] args)
        {

            Storage[] storage = new Storage[10];
            storage[0] = new Storage(80, 50, " Зубная паста");
            storage[1] = new Storage(25, 20000, " Конфеты 'коровка' (на развес)");
            storage[2] = new Storage(15, 100, " Туалетная бумага");
            storage[3] = new Storage(6, 100000, " Гречневая крупа (на развес)");
            storage[4] = new Storage(65, 100, " Зубная щётка");
            storage[5] = new Storage(7, 100000, " Рисовая крупа(на развес)");
            storage[6] = new Storage(30, 100, " Буханка хлеба");
            storage[7] = new Storage(3, 100000, " Сахар (на развес)");
            storage[8] = new Storage(25, 60, " Жевательная резинка 'Dirol'");
            storage[9] = new Storage(4, 100000, " Соль (на развес)");

            int numb = 0;

            Console.WriteLine("Введите 'Д', чтобы посмотреть список товаров");
            Console.WriteLine("Введите 'З', чтобы посмотреть корзину");
            string a = Console.ReadLine();
            if (a == "Д")
            {
                OurProducts(storage);
                Console.WriteLine("Если Вы хотите вернуться в корзину, введите 'З'");
                string b = Console.ReadLine();
                if (b == "З")
                    Basket(storage, numb);

            }
            if (a == "З")
                Basket(storage, numb);


            Console.ReadKey();
        }



        public static void OurProducts(Storage[] storage)
        {

            int z = 1;
            for (int i = 0; i < storage.Length; i++)
            {

                Console.WriteLine(z + "." + storage[i].Name);
                if (i % 2 != 0)
                    Console.WriteLine(storage[i].Prices + " руб за 100г");
                else
                    Console.WriteLine(storage[i].Prices+ " руб");
                z++;
            }
            Console.WriteLine("WARNING: Числа перед наименованием товара - номер товара.");
        }

        public static void Basket(Storage[] storage, int numb)
        {
            double totalsum = 0;
            double localsum = 0;
            int grammcount = 0;
            Console.WriteLine("Приветствуем в нашем онлайн-магазине 'ScamShop'");
            Console.WriteLine("На данный момент Ваша корзина пуста. Давайте перейдём к покупкам!");
            Console.WriteLine("У нас действует скидка при покупке товаров на сумму до 500 рублей в размере 20%");

            string o;
            int besk = 1;
            int[] trasharray = new int[10];
            int[] trasharrayforcount = new int[5];
            int trash = 0;
            int trash2 = -1;

            while (besk == 1)
            {
                trash++;
                numb++;
                trash2++;

                Console.WriteLine("Введите номер товара, который хотите приобрести");
                int a = int.Parse(Console.ReadLine());
                a -= 1;
                trasharray[trash] = a;

                if (a >= 0 && a < 10)
                {

                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Введите количество приобретаемого товара. Цена указана за штуку.");
                        int count = int.Parse(Console.ReadLine());
                        if (storage[a].Quantity < count)
                        {
                            Console.WriteLine("Товара на складе недостаточно. Приходите в другой раз");
                            break;
                        }
                        else
                        {
                            storage[a].Quantity -= count;

                            trasharrayforcount[trash2] = count; // test



                            localsum += storage[a].Prices * count;
                            totalsum += localsum;
                            Console.WriteLine("Вы добавили в корзину:" + storage[a].Name + "\t" + "х" + count + " = " + localsum + " руб");
                            localsum = 0;
                        }

                    }
                    if (a % 2 != 0)
                    {

                        Console.WriteLine("Введите количество грамм, кратное 100.");
                        grammcount = int.Parse(Console.ReadLine());

                        if (storage[a].Quantity < grammcount)
                        {
                            Console.WriteLine("Товара на складе недостаточно. Приходите в другой раз");
                            break;
                        }
                        else
                        {
                            storage[a].Quantity -= grammcount;

                            if (grammcount % 100 == 0)
                            {
                                trasharrayforcount[trash2] = grammcount / 100; // test
                                localsum += storage[a].Prices * grammcount / 100;

                                totalsum += localsum;
                                Console.WriteLine("Вы добавили в корзину:" + storage[a].Name + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                                localsum = 0;

                            }

                            else
                            {
                                Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число. Количество грамм ДОЛЖНО быть кратно сотне.");
                                Console.WriteLine("Введите количество грамм, кратное 100.");
                                grammcount = int.Parse(Console.ReadLine());
                                trasharrayforcount[trash2] = grammcount / 100; // test
                                if (grammcount % 100 == 0)
                                {
                                    localsum += storage[a].Prices * grammcount / 100;
                                    totalsum += localsum;

                                    Console.WriteLine("Вы добавили в корзину:" + storage[a].Name + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                                    localsum = 0;


                                }
                                if (grammcount % 100 != 0)
                                {
                                    Console.WriteLine("Ошибка! Вы ввели НЕВЕРНОЕ число.Количество грамм ДОЛЖНО быть кратно сотне.");
                                    Console.WriteLine("Введите количество грамм, кратное 100.");
                                    grammcount = int.Parse(Console.ReadLine());
                                    trasharrayforcount[trash2] = grammcount / 100; // test
                                    if (grammcount % 100 == 0)
                                    {
                                        localsum += storage[a].Prices * grammcount / 100;
                                        totalsum += localsum;

                                        Console.WriteLine("Вы добавили в корзину:" + storage[a].Name + "\t" + "х " + grammcount + " г" + " = " + localsum + " руб");
                                        localsum = 0;
                                    }
                                }
                            }
                        }

                    }
                }
                else
                    Console.WriteLine("Ошибка! Введите число от 1 до 10, предварительно перезапустив программу. У нас нет столько ассортимента!");

                Console.WriteLine("Введите 'Да', если хотите продолжить покупки");
                Console.WriteLine("Введите 'Нет', если хотите прекратить покупки.");


                o = Console.ReadLine();
                if (o == "Да")
                    continue;

                if (o == "Нет")
                {
                    if (totalsum <= 500)
                    {
                        totalsum -= totalsum * 0.2;
                        Console.WriteLine($"С учётом скидки, итого к оплате: {totalsum} рублей");
                    }
                    else
                        Console.WriteLine($"Итого к оплате: { totalsum} рублей");

                    break;
                }

            }


            ShowBasket(storage, numb, trash, trasharray, totalsum, trasharrayforcount);


        }

        public static void ShowBasket(Storage[] storage, int numb, int trash, int[] trasharray, double totalsum, int[] trasharrayforcount)
        {

            Console.WriteLine("Ваша корзина:");
            int test = 0;
            for (int i = 0; i < numb; i++)
            {
                test = trasharray[i + 1];
                Console.WriteLine(storage[test].Name + " = " + storage[test].Prices * trasharrayforcount[i] + " руб " + "\t" +  $"х {trasharrayforcount[i]}");

            }

            //if (totalsum <= 500)
            //    totalsum -= totalsum * 0.2;
            if (totalsum <= 500)
            {
                Console.WriteLine($"С учётом скидки, итого к оплате: {totalsum} рублей");
            }
            else
                Console.WriteLine($"Итого к оплате: { totalsum} рублей");

        }
    }
}



