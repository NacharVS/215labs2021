using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class ShopNew : Shop
    {
        public ShopNew(string name1, double quantity1, double price1, double discount1)
        {
            Name = name1;
            Quantity = quantity1;
            Price = price1;
            Discount = discount1;
        }
        private static string[] _listofproducts = new string[10];
        private static int[] _productsnumber = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static double[] _productsprice = new double[10];
        private static double[] _productsquantity = new double[10];
        private static int[] _productschoose = new int[10];
        private static ShopNew prod1 = new ShopNew("Буханка хлеба 1 шт.          ", 25, 30, 0);
        private static ShopNew prod2 = new ShopNew("Гречневая крупа 100 гр.      ", 15000, 8, 0);
        private static ShopNew prod3 = new ShopNew("Лимонад грушевый 1,5 л - 1 шт", 20, 50, 0);
        private static ShopNew prod4 = new ShopNew("Вырезка говяжья 100 гр.      ", 5000, 250, 0);
        private static ShopNew prod5 = new ShopNew("Индийский чай - 1 уп.        ", 20, 50, 0);
        private static ShopNew prod6 = new ShopNew("Сыр российский 100 гр.       ", 10000, 70, 0);
        private static ShopNew prod7 = new ShopNew("Жевательная резинка - 1 уп.  ", 20, 36, 0);
        private static ShopNew prod8 = new ShopNew("Апельсины 100 гр.            ", 30000, 13, 0);
        private static ShopNew prod9 = new ShopNew("Орех грецкий 100 гр.         ", 5000, 75, 0);
        private static ShopNew prod10 = new ShopNew("Сок яблочный 2 л. - 1 шт.   ", 10, 150, 0);

        protected static void Listproducts()
        {
            _listofproducts[0] = prod1.Name;
            _listofproducts[1] = prod2.Name;
            _listofproducts[2] = prod3.Name;
            _listofproducts[3] = prod4.Name;
            _listofproducts[4] = prod5.Name;
            _listofproducts[5] = prod6.Name;
            _listofproducts[6] = prod7.Name;
            _listofproducts[7] = prod8.Name;
            _listofproducts[8] = prod9.Name;
            _listofproducts[9] = prod10.Name;
            _productsprice[0] = prod1.Price;
            _productsprice[1] = prod2.Price;
            _productsprice[2] = prod3.Price;
            _productsprice[3] = prod4.Price;
            _productsprice[4] = prod5.Price;
            _productsprice[5] = prod6.Price;
            _productsprice[6] = prod7.Price;
            _productsprice[7] = prod8.Price;
            _productsprice[8] = prod9.Price;
            _productsprice[9] = prod10.Price;
            _productsquantity[0] = prod1.Quantity;
            _productsquantity[1] = prod2.Quantity;
            _productsquantity[2] = prod3.Quantity;
            _productsquantity[3] = prod4.Quantity;
            _productsquantity[4] = prod5.Quantity;
            _productsquantity[5] = prod6.Quantity;
            _productsquantity[6] = prod7.Quantity;
            _productsquantity[7] = prod8.Quantity;
            _productsquantity[8] = prod9.Quantity;
            _productsquantity[9] = prod10.Quantity;
            Console.Write($"{_productsnumber[0]} {_listofproducts[0]}");
            prod1.price();
            Console.Write($"{_productsnumber[1]} {_listofproducts[1]}");
            prod2.price();
            Console.Write($"{_productsnumber[2]} {_listofproducts[2]}");
            prod3.price();
            Console.Write($"{_productsnumber[3]} {_listofproducts[3]}");
            prod4.price();
            Console.Write($"{_productsnumber[4]} {_listofproducts[4]}");
            prod5.price();
            Console.Write($"{_productsnumber[5]} {_listofproducts[5]}");
            prod6.price();
            Console.Write($"{_productsnumber[6]} {_listofproducts[6]}");
            prod7.price();
            Console.Write($"{_productsnumber[7]} {_listofproducts[7]}");
            prod8.price();
            Console.Write($"{_productsnumber[8]} {_listofproducts[8]}");
            prod9.price();
            Console.Write($"{_productsnumber[9]} {_listofproducts[9]}");
            prod10.price();
            Console.WriteLine();
        }
        internal static void start()
        {
            Console.WriteLine("Добро пожаловать в магазин!");
            Console.WriteLine("Вы хотите просмотреть список товаров и начать покупки? 1 - Да; 2 - Нет");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Список товаров: ");
                    Console.WriteLine();
                    ShopNew.Listproducts();
                    ShopNew.productschoose();
                    break;
                case 2:
                    Console.WriteLine("Досвидания!");
                    break;
                default:
                    Console.WriteLine("Неверная цифра!");
                    break;
            }    
        }
        protected static void productschoose()
        {
            Console.WriteLine("Введите поочерёдно кол-во нужного товара.");
            Console.WriteLine("Кол-во товара на развес измеряется следующим образом: 1кг гречки = 10 * 100 гр. Нужно ввести 10.");
            Console.WriteLine("Если товар не нужен, введите 0");
            Console.WriteLine();
            ShopNew.productschoose1();
        }
        protected static void productschoose1()
        {
            Console.Write($"Введите кол-во буханок хлеба - ");
            _productschoose[0] = int.Parse(Console.ReadLine());
            if (_productschoose[0] > _productsquantity[0])
            {
                Console.WriteLine("Неверное кол-во!");
                while (_productschoose[0] > _productsquantity[0])
                {
                    Console.Write($"Введите кол-во буханок хлеба - ");
                    _productschoose[0] = int.Parse(Console.ReadLine());
                    if (_productschoose[0] > _productsquantity[0])
                    {
                        Console.WriteLine("Неверное кол-во!");
                        continue;
                    }
                    else if (_productschoose[0] <= _productsquantity[0])
                    {
                        break;
                    }
                }
            }
            Console.Write($"Введите нужный вес гречки - ");
            _productschoose[1] = int.Parse(Console.ReadLine());
            if (_productschoose[1] > _productsquantity[1])
            {
                Console.WriteLine("Неверное кол-во!");
                while (_productschoose[1] > _productsquantity[1])
                {
                    Console.Write($"Введите нужный вес гречки - ");
                    _productschoose[1] = int.Parse(Console.ReadLine());
                    if (_productschoose[1] > _productsquantity[1])
                    {
                        Console.WriteLine("Неверное кол-во!");
                        continue;
                    }
                    else if (_productschoose[1] <= _productsquantity[1])
                    {
                        break;
                    }
                }
            }
         
        }
        
    }
}
