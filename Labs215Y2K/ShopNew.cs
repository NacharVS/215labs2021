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
            Console.WriteLine("Кол-во товара на развес измеряется следующим образом: 1кг гречки = 1000 гр. Введите вес в граммах.");
            Console.WriteLine("Если товар не нужен, введите 0");
            Console.WriteLine();
            ShopNew.productschoose2();
        }
        protected static void question()
        {
            Console.WriteLine("Aboba");
        }
        protected static void productschoose2()
        {
            Console.Write("Введите номер товара - ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write($"Введите кол-во буханок хлеба - ");
                    _productschoose[0] = int.Parse(Console.ReadLine());
                    if (_productschoose[0] > _productsquantity[0])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[0] > _productsquantity[0])
                        {
                            Console.Write($"Введите кол-во буханок хлеба - ");
                            _productschoose[0] = int.Parse(Console.ReadLine());
                            if (_productschoose[0] > _productsquantity[0])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[0] <= _productsquantity[0])
                            {
                                _productschoose[0] = _productschoose[0] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer1 = int.Parse(Console.ReadLine());
                    switch (answer1)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine();
                    Console.Write($"Введите нужный вес гречки - ");
                    _productschoose[1] = int.Parse(Console.ReadLine());
                    if (_productschoose[1] > _productsquantity[1])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[1] > _productsquantity[1])
                        {
                            Console.Write($"Введите нужный вес гречки - ");
                            _productschoose[1] = int.Parse(Console.ReadLine());
                            if (_productschoose[1] > _productsquantity[1])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[1] <= _productsquantity[1])
                            {
                                _productschoose[1] = _productschoose[1] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer2 = int.Parse(Console.ReadLine());
                    switch (answer2)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine();
                    Console.Write($"Введите кол-во лимонада - ");
                    _productschoose[2] = int.Parse(Console.ReadLine());
                    if (_productschoose[2] > _productsquantity[2])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[2] > _productsquantity[2])
                        {
                            Console.Write($"Введите кол-во лимонада - ");
                            _productschoose[2] = int.Parse(Console.ReadLine());
                            if (_productschoose[2] > _productsquantity[2])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[2] <= _productsquantity[2])
                            {
                                _productschoose[2] = _productschoose[2] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer3 = int.Parse(Console.ReadLine());
                    switch (answer3)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine();
                    Console.Write($"Введите кол-во говяжьей вырезки - ");
                    _productschoose[3] = int.Parse(Console.ReadLine());
                    if (_productschoose[3] > _productsquantity[3])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[3] > _productsquantity[3])
                        {
                            Console.Write($"Введите кол-во говяжьей вырезки - ");
                            _productschoose[3] = int.Parse(Console.ReadLine());
                            if (_productschoose[3] > _productsquantity[3])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[3] <= _productsquantity[3])
                            {
                                _productschoose[3] = _productschoose[3] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer4 = int.Parse(Console.ReadLine());
                    switch (answer4)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine();
                    Console.Write($"Введите кол-во чая - ");
                    _productschoose[4] = int.Parse(Console.ReadLine());
                    if (_productschoose[4] > _productsquantity[4])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[4] > _productsquantity[4])
                        {
                            Console.Write($"Введите кол-во чая - ");
                            _productschoose[4] = int.Parse(Console.ReadLine());
                            if (_productschoose[4] > _productsquantity[4])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[4] <= _productsquantity[4])
                            {
                                _productschoose[4] = _productschoose[4] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer5 = int.Parse(Console.ReadLine());
                    switch (answer5)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine();
                    Console.Write($"Введите кол-во сыра  - ");
                    _productschoose[5] = int.Parse(Console.ReadLine());
                    if (_productschoose[5] > _productsquantity[5])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[5] > _productsquantity[5])
                        {
                            Console.Write($"Введите кол-во сыра - ");
                            _productschoose[5] = int.Parse(Console.ReadLine());
                            if (_productschoose[5] > _productsquantity[5])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[5] <= _productsquantity[5])
                            {
                                _productschoose[5] = _productschoose[5] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer6 = int.Parse(Console.ReadLine());
                    switch (answer6)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 7:
                    Console.WriteLine();
                    Console.Write($"Введите кол-во жев. резинки  - ");
                    _productschoose[6] = int.Parse(Console.ReadLine());
                    if (_productschoose[6] > _productsquantity[6])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[6] > _productsquantity[6])
                        {
                            Console.Write($"Введите кол-во жев. резинки - ");
                            _productschoose[6] = int.Parse(Console.ReadLine());
                            if (_productschoose[6] > _productsquantity[6])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[6] <= _productsquantity[6])
                            {
                                _productschoose[6] = _productschoose[6] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer7 = int.Parse(Console.ReadLine());
                    switch (answer7)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 8:
                    Console.WriteLine();
                    Console.Write($"Введите кол-во апельсинов  - ");
                    _productschoose[7] = int.Parse(Console.ReadLine());
                    if (_productschoose[7] > _productsquantity[7])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[7] > _productsquantity[7])
                        {
                            Console.Write($"Введите кол-во апельсинов - ");
                            _productschoose[7] = int.Parse(Console.ReadLine());
                            if (_productschoose[7] > _productsquantity[7])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[7] <= _productsquantity[7])
                            {
                                _productschoose[7] = _productschoose[7] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer8 = int.Parse(Console.ReadLine());
                    switch (answer8)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 9:
                    Console.WriteLine();
                    Console.Write($"Введите кол-во гр. ореха  - ");
                    _productschoose[8] = int.Parse(Console.ReadLine());
                    if (_productschoose[8] > _productsquantity[8])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[8] > _productsquantity[8])
                        {
                            Console.Write($"Введите кол-во гр. ореха - ");
                            _productschoose[8] = int.Parse(Console.ReadLine());
                            if (_productschoose[8] > _productsquantity[8])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[8] <= _productsquantity[8])
                            {
                                _productschoose[8] = _productschoose[8] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer9 = int.Parse(Console.ReadLine());
                    switch (answer9)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine();
                    Console.Write($"Введите кол-во сока  - ");
                    _productschoose[9] = int.Parse(Console.ReadLine());
                    if (_productschoose[9] > _productsquantity[9])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (_productschoose[5] > _productsquantity[5])
                        {
                            Console.Write($"Введите кол-во сока - ");
                            _productschoose[9] = int.Parse(Console.ReadLine());
                            if (_productschoose[9] > _productsquantity[9])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (_productschoose[9] <= _productsquantity[9])
                            {
                                _productschoose[9] = _productschoose[0] / 100;
                                break;
                            }
                        }
                    }
                    else
                    {

                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer10 = int.Parse(Console.ReadLine());
                    switch (answer10)
                    {
                        case 1:
                            ShopNew.productschoose2();
                            break;
                        case 2:
                            ShopNew.question();
                            break;
                        default:
                            ShopNew.question();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер товара!");
                    ShopNew.productschoose2();
                    break;
            }
        }
    }
}
        
    

