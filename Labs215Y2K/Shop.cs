﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Shop
    {
        public static void store()
        {
            Console.WriteLine("Продукты");
            Console.WriteLine();
            int Хлеб = 51;
            int Молоко = 55;
            int Сыр = 150;
            int Кефир = 73;
            int Колбаса = 175;
            int Гречка = 43;
            int Бананы = 75;
            int Конфеты = 80;
            int Пшеница = 34;
            int Макароны = 70;
            
            string[] products = new string[10];
            {
                products[0] = "Хлеб цена:" + Хлеб;
                products[1] = "Молоко цена:" + Молоко;
                products[2] = "Сыр цена:" + Сыр;
                products[3] = "Кефир цена:" + Кефир;
                products[4] = "Колбаса цена:" + Колбаса;
                products[5] = "Гречка цена за 100 грамм:" + Гречка;
                products[6] = "Бананы цена за 100 грамм:" + Бананы;
                products[7] = "Конфеты цена за 100 грамм:" + Конфеты;
                products[8] = "Пшеница цена за 100 грамм:" + Пшеница;
                products[9] = "Макароны цена за 100 грамм:" + Макароны;

            }
            string[] Продукты = new string[10];
            {
                Продукты[0] = "Хлеб";
                Продукты[1] = "Молоко";
                Продукты[2] = "Сыр";
                Продукты[3] = "Кефир";
                Продукты[4] = "Колбаса";
                Продукты[5] = "Гречка";
                Продукты[6] = "Бананы";
                Продукты[7] = "Конфеты";
                Продукты[8] = "Пшеница";
                Продукты[9] = "Макароны";

            }
            int summ = 0;
            int cc = 1;
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i]);
            }
            while (Хлеб > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Выберите товар. Например: Хлеб ");
                String a = Console.ReadLine();
                Console.WriteLine($"Наберите стоимость товара");
                int aa = int.Parse(Console.ReadLine());
                Console.WriteLine($"Выберите количество. Например: 5 ");
                int bb = int.Parse(Console.ReadLine());
                if (cc == 1)
                {
                    summ = summ + aa * bb;
                }    
                else
                {
                    summ = summ - aa * bb;
                }
                Console.WriteLine($"Цена покупки:" + summ);
                Console.WriteLine(a );
                Console.WriteLine($"Завершить покупку(0),Добавить продукт(1),Убрать продукт(2),Отменить покупку(3).");
                cc = int.Parse(Console.ReadLine());
                if (cc == 1)
                {
                    continue;
                }
                if (cc == 2)
                {
                  
                    continue;
                }
                if (cc== 3)
                {
                    Console.WriteLine($"Покупка отменена.");
                }
                else
                {
                    Console.WriteLine($"Покупка завершена.");
                }
            }
        }
    }
}
