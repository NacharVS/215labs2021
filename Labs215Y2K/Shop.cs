﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Shop
    {
        public static void Catalog()
        {
            Console.WriteLine("Добро пожаловать в наш магазин!!");
            Console.WriteLine("Что хотите купить?");
            Console.WriteLine("Выбирайте:");
            string[] Catalog = new string[] { "1 Хлеб", "2 Мороженное", "3 Шоколад", "4 Ружье", "5 Дошик", "6 Мука", "7 Гречка", "8 Сахар", "9 Сало", "10 Соль" };
            int[] Price = new int[] { 20, 30, 50, 5000, 15, 60, 45, 60, 169, 20 };
            string PriceTeg = "rub.";
            for (int i = 0; i < Catalog.Length; i++)
            {
                Console.Write($" {Catalog[i]}");
                if (i > 4)
                {
                    Console.Write($"-Товар на развес");
                }
                Console.Write($" = {Price[i]} " + PriceTeg);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("выберите номер товара");
            int NumProduct = int.Parse(Console.ReadLine());

        }
    }
}
