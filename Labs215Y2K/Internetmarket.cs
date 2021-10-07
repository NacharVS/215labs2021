using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Internetmarket
    {
        public static void catalog1()
        {
            Console.WriteLine("Добро пожаловать в магазин.Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть список товаров");
            Console.WriteLine("2 - Перейти в корзину");
            Console.WriteLine("3 - Завершить покупку");
            int solution = int.Parse(Console.ReadLine());
            switch (solution)
            {
                case "1":
                    Internetmarket.catalog

            }

        }
        public static void catalog(string[] a )
        {
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
                Console.Write(a[j]);
                Console.WriteLine();
            }
        }
    }
}
