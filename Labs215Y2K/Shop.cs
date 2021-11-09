using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Shop
    {
        static string a11 = "1 - Просмотреть список товаров";
        static string a22 = "2 - Перейти в корзину";
        
        
        public static void catalog(int[] productschoose, int[] priceproducts)
        {
            Console.WriteLine("Добро пожаловать в магазин. Что вы хотите сделать?");
            Console.WriteLine(a11);
            Console.WriteLine(a22);
            string solution = Console.ReadLine();
            switch (solution)
            {
                case "1":
                    Console.WriteLine("");
                    Shop.catalog1(productschoose, priceproducts);
                    break;
                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("Корзина пуста. Выберите товары");
                    Console.WriteLine("");
                    Shop.catalog1(productschoose, priceproducts);
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Ваша итоговая цена равна ");
                    break;
            }

        }

        public static void catalog1(int[] productschoose, int[] priceproducts)
        {
            string[] a = new string[10];
            for (int j = 0; j < 10; j++)
            {

                a[0] = "0. Буханка хлеба - 30 р.";
                a[1] = "1. Гречневая крупа 100 гр. - 8 р.";
                a[2] = "2. Лимонад Грушевый 1 л. - 40 р.";
                a[3] = "3. Вырезка говяжья 100 гр. - 250 р.";
                a[4] = "4. Индийский чай 1 шт. - 50 р.";
                a[5] = "5. Сыр российский 100 гр - 70 р.";
                a[6] = "6. Резинка жевательная мятная  1 шт. - 36 р.";
                a[7] = "7. Апельсины 100 гр. - 13 р.";
                a[8] = "8. Орех грецкий 100 гр. - 75 р.";
                a[9] = "9. Сок Яблочный 2 л. - 150 р.";
                Console.Write(a[j]);
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("Выберите товары по списку, помните , что выбор веса должен быть кратным 100(5 кг = 50*100)");
            Shop.chooseproducts(productschoose, priceproducts);

        }

        public static void chooseproducts(int[] productschoose, int[] priceproducts)
        {

            Console.Write("Сколько буханок хлеба вы хотите купить:");
            productschoose[0] = int.Parse(Console.ReadLine());
            Console.Write("Сколько грамм гречки вы хотите купить(X*100gr.):");
            productschoose[1] = int.Parse(Console.ReadLine());
            Console.Write("Сколько бутылок лимонада вы хотите купить(1 бутылка - 1 литр):");
            productschoose[2] = int.Parse(Console.ReadLine());
            Console.Write("Сколько сотен грамм вырезки вы хотите купить:");
            productschoose[3] = int.Parse(Console.ReadLine());
            Console.Write("Сколько упаковак чая вы хотите купить:");
            productschoose[4] = int.Parse(Console.ReadLine());
            Console.Write("Сколько сотен грамм сыра вы хотите купить:");
            productschoose[5] = int.Parse(Console.ReadLine());
            Console.Write("Сколько пачек жевательной резинки вы хотите купить:");
            productschoose[6] = int.Parse(Console.ReadLine());
            Console.Write("Сколько сотен грамм апельсинов вы хотите купить:");
            productschoose[7] = int.Parse(Console.ReadLine());
            Console.Write("Сколько сотен грамм ореха вы хотите купить:");
            productschoose[8] = int.Parse(Console.ReadLine());
            Console.Write("Сколько упаковок сока вы хотите купить:");
            productschoose[9] = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Shop.next2(productschoose, priceproducts);
        }
        public static void next2(int[] productschoose, int[] priceproducts)
        {
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("Просмотреть корзину");
            Console.WriteLine("Завершить покупку и узнать цену");
            Console.WriteLine("Убрать товары , просмотрев список?");
            string z = Console.ReadLine();
            switch (z)
            {
                case "1":
                    Console.WriteLine();
                    Shop.listofproducts(productschoose, priceproducts);
                    break;
                case "2":
                    Console.WriteLine();
                    Shop.cheque(productschoose, priceproducts);
                    break;
                case "3":
                    Console.WriteLine();
                    Shop.listofproducts(productschoose, priceproducts);
                    break;
                default:
                    Console.Write(1);
                    break;


            }
        }
        public static void listofproducts(int[] productschoose, int[] priceproducts)
        {
            if (productschoose[0] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во хлеба - {productschoose[0]}");
            }
            if (productschoose[1] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм гречки - {productschoose[1]}");
            }
            if (productschoose[2] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во бутылок лимонада - {productschoose[2]}");
            }
            if (productschoose[3] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм вырезки - {productschoose[3]}");
            }
            if (productschoose[4] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во упаковок чая - {productschoose[4]}");
            }
            if (productschoose[5] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм сыра - {productschoose[5]}");
            }
            if (productschoose[6] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во пачек жевательной резинки - {productschoose[6]}");
            }
            if (productschoose[6] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во пачек жевательной резинки - {productschoose[6]}");
            }
            if (productschoose[7] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм апельсинов - {productschoose[7]}");
            }
            if (productschoose[8] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм ореха - {productschoose[8]}");
            }
            if (productschoose[9] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во упаковок сока - {productschoose[9]}");
            }
            Shop.cheque2(productschoose, priceproducts);
        }
        public static void cheque(int[] priceproducts, int[] productschoose)
        {
            int a0 = priceproducts[0] * productschoose[0];
            int a1 = priceproducts[1] * productschoose[1];
            int a2 = priceproducts[2] * productschoose[2];
            int a3 = priceproducts[3] * productschoose[3];
            int a4 = priceproducts[4] * productschoose[4];
            int a5 = priceproducts[5] * productschoose[5];
            int a6 = priceproducts[6] * productschoose[6];
            int a7 = priceproducts[7] * productschoose[7];
            int a8 = priceproducts[8] * productschoose[8];
            int a9 = priceproducts[9] * productschoose[9];
            if (a0 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во хлеба {a0} р.");
            }
            if (a1 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во сотен грамм гречки {a1} р.");
            }
            if (a2 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во бутылок лимонада {a2} р.");
            }
            if (a3 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во сотен грамм говяжьей вырезки {a3} р.");
            }
            if (a4 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во упаковок чая индийского {a4} р.");
            }
            if (a5 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во сотен грамм российского сыра {a5} р.");
            }
            if (a6 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во пачек жевательной резинки {a6} р.");
            }
            if (a7 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во сотен грамм апельсинов {a7} р.");
            }
            if (a8 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во сотен грамм грецкого ореха {a8} р.");
            }
            if (a9 == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Цена за выбранное кол-во упаковок яблочного сока {a9} р.");
            }
            Console.WriteLine("");
            Console.WriteLine($"Итоговая цена за покупку равна {a0 + a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9} р. Досвидания!");
        }

        public static void Delete(int[] priceproducts, int[] productschoose)
        {
            Console.WriteLine("Вы хотите удалить продукт (Да/Нет)");
            string answer = Console.ReadLine();
            while (answer == "Да")
            {
                int a0 = priceproducts[0] * productschoose[0];
                int a1 = priceproducts[1] * productschoose[1];
                int a2 = priceproducts[2] * productschoose[2];
                int a3 = priceproducts[3] * productschoose[3];
                int a4 = priceproducts[4] * productschoose[4];
                int a5 = priceproducts[5] * productschoose[5];
                int a6 = priceproducts[6] * productschoose[6];
                int a7 = priceproducts[7] * productschoose[7];
                int a8 = priceproducts[8] * productschoose[8];
                int a9 = priceproducts[9] * productschoose[9];
                if (productschoose[0] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(0.) Кол-во хлеба - {productschoose[0]}");
                }
                if (productschoose[1] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(1.) Кол-во сотен грамм гречки - {productschoose[1]}");
                }
                if (productschoose[2] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(2.) Кол-во бутылок лимонада - {productschoose[2]}");
                }
                if (productschoose[3] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(3.)  Кол-во сотен грамм вырезки - {productschoose[3]}");
                }
                if (productschoose[4] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(4.) Кол-во упаковок чая - {productschoose[4]}");
                }
                if (productschoose[5] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(5.) Кол-во сотен грамм сыра - {productschoose[5]}");
                }
                if (productschoose[6] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(6.) Кол-во пачек жевательной резинки - {productschoose[6]}");
                }

                if (productschoose[7] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(7.) Кол-во сотен грамм апельсинов - {productschoose[7]}");
                }
                if (productschoose[8] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(8.) Кол-во сотен грамм ореха - {productschoose[8]}");
                }
                if (productschoose[9] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"(9.)Кол-во упаковок сока - {productschoose[9]}");
                }
                Console.WriteLine("Введите кодовый номер товара");
                int nn = int.Parse(Console.ReadLine());
                productschoose[nn] = 0;
                Console.WriteLine("Проверьте список ваших продуктов");
                if (productschoose[0] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во хлеба - {productschoose[0]}");
                }
                if (productschoose[1] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во сотен грамм гречки - {productschoose[1]}");
                }
                if (productschoose[2] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во бутылок лимонада - {productschoose[2]}");
                }
                if (productschoose[3] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во сотен грамм вырезки - {productschoose[3]}");
                }
                if (productschoose[4] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во упаковок чая - {productschoose[4]}");
                }
                if (productschoose[5] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во сотен грамм сыра - {productschoose[5]}");
                }
                if (productschoose[6] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во пачек жевательной резинки - {productschoose[6]}");
                }
                if (productschoose[6] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во пачек жевательной резинки - {productschoose[6]}");
                }
                if (productschoose[7] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во сотен грамм апельсинов - {productschoose[7]}");
                }
                if (productschoose[8] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во сотен грамм ореха - {productschoose[8]}");
                }
                if (productschoose[9] == 0)
                {
                    Console.Write("");
                }
                else
                {
                    Console.WriteLine($"Кол-во упаковок сока - {productschoose[9]}");
                }
                Console.WriteLine("Вы хотите изменить количество или удалить продукт (Да/Нет)");

                answer = Console.ReadLine();
            }
        }
        public static void cheque2(int[] priceproducts, int[] productschoose)
        {
            Console.WriteLine("Вы хотите завершить покупку и узнать итоговую цену?(Да/Нет)");
            string a = Console.ReadLine();
            if (a == "Да")
            {
                Console.WriteLine();
                Shop.cheque(productschoose, priceproducts);
            }
            else
            {
                Shop.Delete(priceproducts, productschoose);
                Console.WriteLine();
                Shop.cheque(productschoose, priceproducts);
            }
        }
    }
}

