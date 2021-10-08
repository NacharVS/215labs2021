using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Market
    {
        static string a11 = "1 - Просмотреть список товаров";
        static string a22 = "2 - Перейти в корзину";
        public static void catalog()
        {
            Console.WriteLine("Добро пожаловать в магазин. Что вы хотите сделать?");
            Console.WriteLine(a11);
            Console.WriteLine(a22);
            string solution = Console.ReadLine();
            switch (solution)
            {
                case "1":
                    Console.WriteLine("");
                    Market.catalog1();
                    break;
                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("Корзина пуста. Выберите товары");
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Ваша итоговая цена равна ");
                    break;
            }
    
        }
        public static void catalog1()
        {
            string[] a = new string[10];
            for (int j = 0; j < 10; j++)
            {

                a[0] = "Буханка хлеба - 30 р.";
                a[1] = "Гречневая крупа 100 гр. - 8 р.";
                a[2] = "Лимонад Грушевый 1 л. - 40 р.";
                a[3] = "Вырезка говяжья 100 гр. - 250 р.";
                a[4] = "Индийский чай 1 шт. - 50 р.";
                a[5] = "Сыр российский 100 гр - 70 р.";
                a[6] = "Резинка жевательная мятная  1 шт. - 36 р.";
                a[7] = "Апельсины 100 гр. - 13 р.";
                a[8] = "Орех грецкий 100 гр. - 75 р.";
                a[9] = "Сок Яблочный 2 л. - 150 р.";
                Console.Write(a);
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Выберите товары по списку, помните , что выбор веса должен быть кратным 100(5 кг = 50*100)");
            Market.chooseproducts();
        }
        public static void productinfo()
        {
            int[] b = { 30, 8, 40, 250, 50, 70, 36, 13, 75, 150 };
            ref int b0 = ref b[0];
        }
        public static void chooseproducts()
        {
            int[] c = new int[10];
            Console.Write("Сколько буханок хлеба вы хотите купить:");
            c[0] = int.Parse(Console.ReadLine());
            Console.Write("Сколько грамм гречки вы хотите купить(X*100gr.):");
            c[1] = int.Parse(Console.ReadLine());
            Console.Write("Сколько бутылок лимонада вы хотите купить(1 бутылка - 1 литр):");
            c[2] = int.Parse(Console.ReadLine());
            Console.Write("Сколько сотен грамм вырезки вы хотите купить:");
            c[3] = int.Parse(Console.ReadLine());
            Console.Write("Сколько упаковак чая вы хотите купить:");
            c[4] = int.Parse(Console.ReadLine());
            Console.Write("Сколько сотен грамм сыра вы хотите купить:");
            c[5] = int.Parse(Console.ReadLine());
            Console.Write("Сколько пачек жевательной резинки вы хотите купить:");
            c[6] = int.Parse(Console.ReadLine());
            Console.Write("Сколько сотен грамм апельсинов вы хотите купить:");
            c[7] = int.Parse(Console.ReadLine());
            Console.Write("Сколько сотен грамм ореха вы хотите купить:");
            c[8] = int.Parse(Console.ReadLine());
            Console.Write("Сколько упаковок сока вы хотите купить:");
            c[9] = int.Parse(Console.ReadLine());
            ref int c0 = ref c[0];
            Console.WriteLine("");
            Market.next2();
        }
        public static void next2()
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine(Market.a11);
            Console.WriteLine(Market.a22);
            string z = Console.ReadLine();
            switch (z)
            {
                

            }
        }
        public static void allprice()
        {
            
        }
        
    }
}
