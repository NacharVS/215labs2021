using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class market : marketnew
    {
        static string a11 = "1 - Просмотреть список товаров";
        static string a22 = "2 - Перейти в корзину";
        protected static void productcheck()
        {
            Console.WriteLine("Добро пожаловать в магазин. Что вы хотите сделать?");
            Console.WriteLine(a11);
            Console.WriteLine(a22);
            int otvet = int.Parse(Console.ReadLine());
            switch (otvet)
            {
                case 1:
                    market.listproducts();
                    break;
                case 2:
                    market.selectedProducts();
                    break;
                default:
                    market.selectedProducts();
                    break;
            }
        }
        public static void selectedProducts()
        {
            if (_listOfProducts[0] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во хлеба - {_listOfProducts[0]}");
            }
            if (_listOfProducts[1] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм гречки - {_listOfProducts[1]}");
            }
            if (_listOfProducts[2] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во бутылок лимонада - {_listOfProducts[2]}");
            }
            if (_listOfProducts[3] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм вырезки - {_listOfProducts[3]}");
            }
            if (_listOfProducts[4] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во упаковок чая - {_listOfProducts[4]}");
            }
            if (_listOfProducts[5] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм сыра - {_listOfProducts[5]}");
            }
            if (_listOfProducts[6] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во пачек жевательной резинки - {_listOfProducts[6]}");
            }
            if (_listOfProducts[6] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во пачек жевательной резинки - {_listOfProducts[6]}");
            }
            if (_listOfProducts[7] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм апельсинов - {_listOfProducts[7]}");
            }
            if (_listOfProducts[8] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во сотен грамм ореха - {_listOfProducts[8]}");
            }
            if (_listOfProducts[9] == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"Кол-во упаковок сока - {_listOfProducts[9]}");
            }
        }
            public market(string Name1, long Quantity1, double Price1, double Discount1)
            {
                Name = Name1;
                Quantity = Quantity1;
                Price = Price1;
                Discount = Discount1;
            }
        private static string[] _listOfProducts = new string[10];
        private static market prod1 = new market("Буханка хлеба 1 шт.", 30 , 30 , 0);
        private static market prod2 = new market("Гречневая крупа 100 гр.",100000, 8, 0);
        private static market prod3 = new market("Лимонад Грушевый 1 бутылка",20, 40, 0);
        private static market prod4 = new market("Вырезка говяжья 100 гр.", 2000, 250, 0);
        private static market prod5 = new market("Индийский чай 1 шт.", 20 , 50 , 0);
        private static market prod6 = new market("Сыр российский 100 гр.", 0, 70, 0);
        private static market prod7 = new market("Резинка жевательная мятная 1 пачка", 30, 36, 0);
        private static market prod8 = new market("Апельсины 100 гр.", 30000, 13, 0);
        private static market prod9 = new market("Орех грецкий 100 гр.", 5000, 75, 0);
        private static market prod10 = new market("Сок Яблочный 2 л.", 15, 150, 0);
        protected static void listproducts()
        {
            _listOfProducts[0] = prod1.Name;
            _listOfProducts[1] = prod2.Name;
            _listOfProducts[2] = prod3.Name;
            _listOfProducts[3] = prod4.Name;
            _listOfProducts[4] = prod5.Name;
            _listOfProducts[5] = prod6.Name;
            _listOfProducts[6] = prod7.Name;
            _listOfProducts[7] = prod8.Name; 
            _listOfProducts[8] = prod9.Name;
            _listOfProducts[9] = prod10.Name;
            for (int i = 0; i<_listOfProducts.Length;i++)
            {
                Console.Write(_listOfProducts);
            }
        }
    }
}
