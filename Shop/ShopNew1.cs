using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    class ShopNew1 : ShopInfo
    {
        public ShopNew1(string name1, double quantity1, double price1, double discount1)
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
        private static double[] _choosenprice = new double[10];
        private static double[] _finallyprice = new double[10];
        private static ShopNew1 prod1 = new ShopNew1("Буханка хлеба            ", 25, 30, 0);
        private static ShopNew1 prod2 = new ShopNew1("Гречневая крупа 100 гр.  ", 15000, 8, 0);
        private static ShopNew1 prod3 = new ShopNew1("Лимонад грушевый 1,5 л   ", 20, 50, 0);
        private static ShopNew1 prod4 = new ShopNew1("Вырезка говяжья 100 гр.  ", 5000, 250, 0);
        private static ShopNew1 prod5 = new ShopNew1("Индийский чай -          ", 20, 50, 0);
        private static ShopNew1 prod6 = new ShopNew1("Сыр российский 100 гр.   ", 10000, 70, 0);
        private static ShopNew1 prod7 = new ShopNew1("Жевательная резинка -    ", 20, 36, 0);
        private static ShopNew1 prod8 = new ShopNew1("Апельсины 100 гр.        ", 30000, 13, 0);
        private static ShopNew1 prod9 = new ShopNew1("Орех грецкий 100 гр.     ", 5000, 75, 0);
        private static ShopNew1 prod10 = new ShopNew1("Сок яблочный 2 л. -     ", 10, 150, 0);

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
                    ShopNew1.Listproducts();
                    ShopNew1.productschoose();
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
            ShopNew1.productschoose2();
        }
        protected static void question()
        {
            Console.WriteLine();
            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1 - Просмотреть корзину");
            Console.WriteLine("2 - Добавить продукты в корзину");
            Console.WriteLine("3 - Убрать продукты из корзины");
            Console.WriteLine("4 - Завершить покупки и оплатить");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine();
                    ShopNew1.bucketproducts();
                    ShopNew1.question();
                    break;
                case 2:
                    Console.WriteLine();
                    ShopNew1.productsaddsecond();
                    break;
                case 3:
                    Console.WriteLine();
                    ShopNew1.productsdelete();
                    break;
                case 4:
                    Console.WriteLine();
                    ShopNew1.cheque();
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    ShopNew1.question();
                    break;
            }
        }
        protected static void cheque()
        {
            double sum = 0;
            double discount;
            double totalsum;
            double totaldiscount;
            double discount1;
            for (int i = 0; i < _productsprice.Length; i++)
            {
                _finallyprice[i] = _choosenprice[i] * _productsprice[i];
            }
            for (int i = 0; i < _productsnumber.Length; i++)
            {
                sum += _finallyprice[i];
            }
            for (int i = 0; i < _productsnumber.Length; i++)
            {
                if (_productschoose[i] > 0)
                {
                    Console.WriteLine($"{_productsnumber[i]} {_listofproducts[i]} Выбрано - {_productschoose[i]} у.е. ; Цена - {_finallyprice[i]} руб");
                }
                else if (_productschoose[i] <= 0)
                {
                    continue;
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Итого к оплате = {sum} рублей.");
            if (sum <= 3500)
            {
                discount = 100;
                totalsum = sum - discount;
                discount1 = (discount * 100) / sum;
                Console.WriteLine($"Ваша скидка 100 рублей - {Math.Round(discount1)} % ");
                Console.WriteLine($"Итого со скидкой = {totalsum} рублей");
                Console.WriteLine("Всего доброго. Досвидания!");
            }
            if (sum > 3500 & sum <= 6500)
            {
                discount = 200;
                totalsum = sum - discount;
                discount1 = (discount * 100) / sum;
                Console.WriteLine($"Ваша скидка 200 рублей - {Math.Round(discount1)} % ");
                Console.WriteLine($"Итого со скидкой = {totalsum} рублей");
                Console.WriteLine("Всего доброго. Досвидания!");
            }
            if (sum > 6500 & sum <= 9500)
            {
                discount = 300;
                totalsum = sum - discount;
                discount1 = (discount * 100) / sum;
                Console.WriteLine($"Ваша скидка 300 рублей - {Math.Round(discount1)} % ");
                Console.WriteLine($"Итого со скидкой = {totalsum} рублей");
                Console.WriteLine("Всего доброго. Досвидания!");
            }
            if (sum > 9500 & sum <= 12500)
            {
                discount = 400;
                totalsum = sum - discount;
                discount1 = (discount * 100) / sum;
                Console.WriteLine($"Ваша скидка 400 рублей - {Math.Round(discount1)} % ");
                Console.WriteLine($"Итого со скидкой = {totalsum} рублей");
                Console.WriteLine("Всего доброго. Досвидания!");
            }
            if (sum > 12500)
            {
                discount = 500;
                totalsum = sum - discount;
                discount1 = (discount * 100) / sum;
                Console.WriteLine($"Ваша скидка 500 рублей - {Math.Round(discount1)} % ");
                Console.WriteLine($"Итого со скидкой = {totalsum} рублей");
                Console.WriteLine("Всего доброго. Досвидания!");
            }
        }
        protected static void bucketproducts()
        {
            for (int i = 0; i < _productsprice.Length;i++)
            {
                _finallyprice[i] = _choosenprice[i] * _productsprice[i];
            }
            for (int i = 0; i < _productschoose.Length; i++)
            {
                if (_productschoose[i] > 0)
                {
                    Console.WriteLine($"{_productsnumber[i]} {_listofproducts[i]} Выбрано : {_productschoose[i]} у.е. Цена за 1 у.е. = {_productsprice[i]} р. Итого = {_finallyprice[i]} р.");
                    continue;
                }
                else if (_productschoose[i] == 0)
                {
                    continue;
                }
            }
        }
        protected static void productsdelete()
        {
            Console.WriteLine("Ваша корзина:");
            for (int i = 0; i < _productschoose.Length; i++)
            {
                if (_productschoose[i] > 0)
                {
                    Console.WriteLine($"{_productsnumber[i]} {_listofproducts[i]} Выбрано : {_productschoose[i]} у.е.");
                    continue;
                }
                else if (_productschoose[i] == 0)
                {
                    continue;
                }
            }
            ShopNew1.deletenext();
        }
        protected static void deletenext()
        {
            Console.Write("Введите номер товара - ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    if (_productschoose[0] <= 0)
                    {
                        Console.WriteLine("Хлеба нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ1 = int.Parse(Console.ReadLine());
                        switch (answ1)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во буханок хлеба - ");
                    int input1 = int.Parse(Console.ReadLine());
                    if (input1 > _productschoose[0])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input1 > _productschoose[0])
                        {
                            Console.Write($"Введите не нужное кол-во буханок хлеба - ");
                            input1 = int.Parse(Console.ReadLine());
                            if (input1 > _productschoose[0])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input1 <= _productschoose[0])
                            {
                                _choosenprice[0] -= input1;
                                _productschoose[0] -= input1;
                                _productsquantity[0] += input1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[0] -= input1;
                        _productschoose[0] -= input1;
                        _productsquantity[0] += input1;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer1 = int.Parse(Console.ReadLine());
                    switch (answer1)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 2:
                    if (_productschoose[1] <= 0)
                    {
                        Console.WriteLine("Гречки нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ2 = int.Parse(Console.ReadLine());
                        switch (answ2)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во гречки - ");
                    int input2 = int.Parse(Console.ReadLine());
                    if (input2 > _productschoose[1])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input2 > _productschoose[1])
                        {
                            Console.Write($"Введите не нужное кол-во гречки - ");
                            input2 = int.Parse(Console.ReadLine());
                            if (input2 > _productschoose[1])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input2 <= _productschoose[1])
                            {
                                _choosenprice[1] -= input2 / 100;
                                _productschoose[1] -= input2;
                                _productsquantity[1] += input2;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[1] -=  input2 / 100 ;
                        _productschoose[1] -= input2;
                        _productsquantity[1] += input2;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer2 = int.Parse(Console.ReadLine());
                    switch (answer2)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 3:
                    if (_productschoose[2] <= 0)
                    {
                        Console.WriteLine("Лимонада нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ3 = int.Parse(Console.ReadLine());
                        switch (answ3)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во лимонада - ");
                    int input3 = int.Parse(Console.ReadLine());
                    if (input3 > _productschoose[2])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input3 > _productschoose[2])
                        {
                            Console.Write($"Введите не нужное кол-во лимонада - ");
                            input3 = int.Parse(Console.ReadLine());
                            if (input3 > _productschoose[2])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input3 <= _productschoose[2])
                            {
                                _choosenprice[2] -= input3;
                                _productschoose[2] -= input3;
                                _productsquantity[2] += input3;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[2] -= input3;
                        _productschoose[2] -= input3;
                        _productsquantity[2] += input3;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer3 = int.Parse(Console.ReadLine());
                    switch (answer3)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 4:
                    if (_productschoose[3] <= 0)
                    {
                        Console.WriteLine("Вырезки нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ4 = int.Parse(Console.ReadLine());
                        switch (answ4)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во вырезки - ");
                    int input4 = int.Parse(Console.ReadLine());
                    if (input4 > _productschoose[3])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input4 > _productschoose[3])
                        {
                            Console.Write($"Введите не нужное кол-во вырезки - ");
                            input4 = int.Parse(Console.ReadLine());
                            if (input4 > _productschoose[3])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input4 <= _productschoose[3])
                            {
                                _choosenprice[3] -= input4 / 100;
                                _productschoose[3] -= input4;
                                _productsquantity[3] += input4;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[3] -= input4 / 100;
                        _productschoose[3] -= input4;
                        _productsquantity[3] += input4;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer4 = int.Parse(Console.ReadLine());
                    switch (answer4)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 5:
                    if (_productschoose[4] <= 0)
                    {
                        Console.WriteLine("Чая нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ5 = int.Parse(Console.ReadLine());
                        switch (answ5)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во чая - ");
                    int input5 = int.Parse(Console.ReadLine());
                    if (input5 > _productschoose[4])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input5 > _productschoose[4])
                        {
                            Console.Write($"Введите не нужное кол-во чая - ");
                            input5 = int.Parse(Console.ReadLine());
                            if (input5 > _productschoose[4])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input5 <= _productschoose[4])
                            {
                                _choosenprice[4] -= input5;
                                _productschoose[4] -= input5;
                                _productsquantity[4] += input5;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[4] -= input5;
                        _productschoose[4] -= input5;
                        _productsquantity[4] += input5;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer5 = int.Parse(Console.ReadLine());
                    switch (answer5)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 6:
                    if (_productschoose[5] <= 0)
                    {
                        Console.WriteLine("Сыра нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ6 = int.Parse(Console.ReadLine());
                        switch (answ6)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во сыра - ");
                    int input6 = int.Parse(Console.ReadLine());
                    if (input6 > _productschoose[5])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input6 > _productschoose[5])
                        {
                            Console.Write($"Введите не нужное кол-во сыра - ");
                            input6 = int.Parse(Console.ReadLine());
                            if (input6 > _productschoose[5])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input6 <= _productschoose[5])
                            {
                                _choosenprice[5] -= input6 / 100;
                                _productschoose[5] -= input6;
                                _productsquantity[5] += input6;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[5] -= input6 / 100;
                        _productschoose[5] -= input6;
                        _productsquantity[5] += input6;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer6 = int.Parse(Console.ReadLine());
                    switch (answer6)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 7:
                    if (_productschoose[6] <= 0)
                    {
                        Console.WriteLine("Жев.резинки нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ7 = int.Parse(Console.ReadLine());
                        switch (answ7)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во жев.резинки - ");
                    int input7 = int.Parse(Console.ReadLine());
                    if (input7 > _productschoose[6])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input7 > _productschoose[6])
                        {
                            Console.Write($"Введите не нужное кол-во жев.резинки - ");
                            input7 = int.Parse(Console.ReadLine());
                            if (input7 > _productschoose[6])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input7 <= _productschoose[6])
                            {
                                _choosenprice[6] -= input7;
                                _productschoose[6] -= input7;
                                _productsquantity[6] += input7;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[6] -= input7;
                        _productschoose[6] -= input7;
                        _productsquantity[6] += input7;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer7 = int.Parse(Console.ReadLine());
                    switch (answer7)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 8:
                    if (_productschoose[7] <= 0)
                    {
                        Console.WriteLine("Апельсинов нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ8 = int.Parse(Console.ReadLine());
                        switch (answ8)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во апельсинов - ");
                    int input8 = int.Parse(Console.ReadLine());
                    if (input8 > _productschoose[7])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input8 > _productschoose[7])
                        {
                            Console.Write($"Введите не нужное кол-во апельсинов - ");
                            input8 = int.Parse(Console.ReadLine());
                            if (input8 > _productschoose[7])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input8 <= _productschoose[7])
                            {
                                _choosenprice[7] -= input8 / 100;
                                _productschoose[7] -= input8;
                                _productsquantity[7] += input8;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[7] -= input8 / 100;
                        _productschoose[7] -= input8;
                        _productsquantity[7] += input8;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer8 = int.Parse(Console.ReadLine());
                    switch (answer8)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 9:
                    if (_productschoose[8] <= 0)
                    {
                        Console.WriteLine("Гр. ореха нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ9 = int.Parse(Console.ReadLine());
                        switch (answ9)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во ореха - ");
                    int input9 = int.Parse(Console.ReadLine());
                    if (input9 > _productschoose[8])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input9 > _productschoose[8])
                        {
                            Console.Write($"Введите не нужное кол-во ореха - ");
                            input9 = int.Parse(Console.ReadLine());
                            if (input9 > _productschoose[8])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input9 <= _productschoose[8])
                            {
                                _choosenprice[8] -= input9 / 100;
                                _productschoose[8] -= input9;
                                _productsquantity[8] += input9;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[8] -= input9 / 100;
                        _productschoose[8] -= input9;
                        _productsquantity[8] += input9;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer9 = int.Parse(Console.ReadLine());
                    switch (answer9)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 10:
                    if (_productschoose[9] <= 0)
                    {
                        Console.WriteLine("Сока нет в корзине!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ10 = int.Parse(Console.ReadLine());
                        switch (answ10)
                        {
                            case 1:
                                ShopNew1.deletenext();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.Write($"Введите не нужное кол-во сока - ");
                    int input10 = int.Parse(Console.ReadLine());
                    if (input10 > _productschoose[9])
                    {
                        Console.WriteLine("Данного количества нет в корзине!");
                        while (input10 > _productschoose[9])
                        {
                            Console.Write($"Введите не нужное кол-во сока - ");
                            input10 = int.Parse(Console.ReadLine());
                            if (input10 > _productschoose[9])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input10 <= _productschoose[9])
                            {
                                _choosenprice[9] -= input10;
                                _productschoose[9] -= input10;
                                _productsquantity[9] += input10;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[9] -= input10;
                        _productschoose[9] -= input10;
                        _productsquantity[9] += input10;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer10 = int.Parse(Console.ReadLine());
                    switch (answer10)
                    {
                        case 1:
                            ShopNew1.deletenext();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер товара");
                    ShopNew1.deletenext();
                    break;
            }
        }
        protected static void productsaddsecond()
        {
            Console.WriteLine("Доступные товары к добавлению:");
            for (int i = 0; i < _productschoose.Length; i++)
            {
                if (_productsquantity[i] > 0)
                {
                    Console.WriteLine($"{_productsnumber[i]} {_listofproducts[i]} Цена = {_productsprice[i]} р. Наличие {_productsquantity[i]} у.е.");
                }
                else if (_productsquantity[i] <= 0)
                {
                    continue;
                }
            }
            Console.WriteLine();
            ShopNew1.productschoose2();
        }
        protected static void productschoose2()
        {
            Console.Write("Введите номер товара - ");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    if (_productsquantity[0] <= 0)
                    {
                        Console.WriteLine("Хлеба больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ1 = int.Parse(Console.ReadLine());
                        switch (answ1)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }    
                    Console.Write($"Введите кол-во буханок хлеба - ");
                    int input1 = int.Parse(Console.ReadLine());
                    _productschoose[0] += input1;
                    if (input1 > _productsquantity[0])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input1 > _productsquantity[0])
                        {
                            _productschoose[0] -= input1;
                            Console.Write($"Введите кол-во буханок хлеба - ");
                            input1 = int.Parse(Console.ReadLine());
                            _productschoose[0] += input1;
                            if (input1 > _productsquantity[0])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input1 <= _productsquantity[0])
                            {
                                _choosenprice[0] += input1;
                                _productsquantity[0] -= input1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[0] += input1;
                        _productsquantity[0] -= input1;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer1 = int.Parse(Console.ReadLine());
                    switch (answer1)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 2:
                    if (_productsquantity[1] <= 0)
                    {
                        Console.WriteLine("Гречки больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ2 = int.Parse(Console.ReadLine());
                        switch (answ2)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите нужный вес гречки - ");
                    int input2 = int.Parse(Console.ReadLine());
                    _productschoose[1] += input2;
                    if (input2 > _productsquantity[1])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input2 > _productsquantity[1])
                        {
                            _productschoose[1] -= input2;
                            Console.Write($"Введите нужный вес гречки - ");
                            input2 = int.Parse(Console.ReadLine());
                            _productschoose[1] += input2;
                            if (input2 > _productsquantity[1])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input2 <= _productsquantity[1])
                            {
                                _choosenprice[1] += input2 / 100;
                                _productsquantity[1] -=  input2;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[1] += input2 / 100;
                        _productsquantity[1] -= input2;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer2 = int.Parse(Console.ReadLine());
                    switch (answer2)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 3:
                    if (_productsquantity[2] <= 0)
                    {
                        Console.WriteLine("Лимонада больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ3 = int.Parse(Console.ReadLine());
                        switch (answ3)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите кол-во лимонада - ");
                    int input3 = int.Parse(Console.ReadLine());
                    _productschoose[2] += input3;
                    if (input3 > _productsquantity[2])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input3 > _productsquantity[2])
                        {
                            _productschoose[2] -= input3;
                            Console.Write($"Введите кол-во лимонада - ");
                            input3 = int.Parse(Console.ReadLine());
                            _productschoose[2] += input3;
                            if (input3 > _productsquantity[2])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input3 <= _productsquantity[2])
                            {
                                _choosenprice[2] += input3;
                                _productsquantity[2] -= input3;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[2] += input3;
                        _productsquantity[2] -= input3;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer3 = int.Parse(Console.ReadLine());
                    switch (answer3)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 4:
                    if (_productsquantity[3] <= 0)
                    {
                        Console.WriteLine("Вырезки больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ4 = int.Parse(Console.ReadLine());
                        switch (answ4)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите кол-во говяжьей вырезки - ");
                    int input4 = int.Parse(Console.ReadLine());
                    _productschoose[3] += input4;
                    if (input4 > _productsquantity[3])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input4 > _productsquantity[3])
                        {
                            _productschoose[3] -= input4;
                            Console.Write($"Введите кол-во говяжьей вырезки - ");
                            input4 = int.Parse(Console.ReadLine());
                            _productschoose[3] += input4;
                            if (input4 > _productsquantity[3])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input4 <= _productsquantity[3])
                            {
                                _choosenprice[3] += input4 / 100;
                                _productsquantity[3] -= input4;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[3] += input4 / 100;
                        _productsquantity[3] -= input4;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer4 = int.Parse(Console.ReadLine());
                    switch (answer4)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 5:
                    if (_productsquantity[4] <= 0)
                    {
                        Console.WriteLine("Чая больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ5 = int.Parse(Console.ReadLine());
                        switch (answ5)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите кол-во чая - ");
                    int input5 = int.Parse(Console.ReadLine());
                    _productschoose[4] += input5;
                    if (input5 > _productsquantity[4])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input5 > _productsquantity[4])
                        {
                            _productschoose[4] -= input5;
                            Console.Write($"Введите кол-во чая - ");
                            input5 = int.Parse(Console.ReadLine());
                            _productschoose[4] += input5;
                            if (input5 > _productsquantity[4])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input5 <= _productsquantity[4])
                            {
                                _choosenprice[4] += input5;
                                _productsquantity[4] -= input5;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[4] += input5;
                        _productsquantity[4] -= input5;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer5 = int.Parse(Console.ReadLine());
                    switch (answer5)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 6:
                    if (_productsquantity[5] <= 0)
                    {
                        Console.WriteLine("Сыра больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ6 = int.Parse(Console.ReadLine());
                        switch (answ6)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите кол-во сыра  - ");
                    int input6 = int.Parse(Console.ReadLine());
                    _productschoose[5] += input6;
                    if (input6 > _productsquantity[5])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input6 > _productsquantity[5])
                        {
                            _productschoose[5] -= input6;
                            Console.Write($"Введите кол-во сыра - ");
                            input6 = int.Parse(Console.ReadLine());
                            _productschoose[5] += input6;
                            if (input6 > _productsquantity[5])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input6 <= _productsquantity[5])
                            {
                                _choosenprice[5] += input6 / 100;
                                _productsquantity[5] -= input6;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[5] += input6 / 100;
                        _productsquantity[5] -= input6;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer6 = int.Parse(Console.ReadLine());
                    switch (answer6)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 7:
                    if (_productsquantity[6] <= 0)
                    {
                        Console.WriteLine("Жев. резинки больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ7 = int.Parse(Console.ReadLine());
                        switch (answ7)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите кол-во жев. резинки  - ");
                    int input7 = int.Parse(Console.ReadLine());
                    _productschoose[6] += input7;
                    if (input7 > _productsquantity[6])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input7 > _productsquantity[6])
                        {
                            _productschoose[6] -= input7;
                            Console.Write($"Введите кол-во жев. резинки - ");
                            input7 = int.Parse(Console.ReadLine());
                            _productschoose[6] += input7;
                            if (input7 > _productsquantity[6])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input7 <= _productsquantity[6])
                            {
                                _choosenprice[6] += input7;
                                _productsquantity[6] = _productsquantity[6] - input7;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[6] += input7;
                        _productsquantity[6] -= input7;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer7 = int.Parse(Console.ReadLine());
                    switch (answer7)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 8:
                    if (_productsquantity[7] <= 0)
                    {
                        Console.WriteLine("Апельсинов больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ8 = int.Parse(Console.ReadLine());
                        switch (answ8)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите кол-во апельсинов  - ");
                    int input8 = int.Parse(Console.ReadLine());
                    _productschoose[7] += input8;
                    if (input8 > _productsquantity[7])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input8 > _productsquantity[7])
                        {
                            _productschoose[7] -= input8;
                            Console.Write($"Введите кол-во апельсинов - ");
                            input8 = int.Parse(Console.ReadLine());
                            _productschoose[7] += input8;
                            if (input8 > _productsquantity[7])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input8 <= _productsquantity[7])
                            {
                                _choosenprice[7] += input8 / 100;
                                _productsquantity[7] -= input8;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[7] += input8 / 100;
                        _productsquantity[7] -= input8;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer8 = int.Parse(Console.ReadLine());
                    switch (answer8)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 9:
                    if (_productsquantity[8] <= 0)
                    {
                        Console.WriteLine("Гр. ореха больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ9 = int.Parse(Console.ReadLine());
                        switch (answ9)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите кол-во гр. ореха  - ");
                    int input9 = int.Parse(Console.ReadLine());
                    _productschoose[8] += input9;
                    if (input9 > _productsquantity[8])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input9 > _productsquantity[8])
                        {
                            _productschoose[8] -= input9;
                            Console.Write($"Введите кол-во гр. ореха - ");
                            input9 = int.Parse(Console.ReadLine());
                            _productschoose[8] += input9;
                            if (input9 > _productsquantity[8])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input9 <= _productsquantity[8])
                            {
                                _choosenprice[8] += input9 / 100;
                                _productsquantity[8] -= input9;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[8] += input9 / 100;
                        _productsquantity[8] -= input9;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer9 = int.Parse(Console.ReadLine());
                    switch (answer9)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                case 10:
                    if (_productsquantity[9] <= 0)
                    {
                        Console.WriteLine("Сока больше нет в наличии!");
                        Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                        int answ10 = int.Parse(Console.ReadLine());
                        switch (answ10)
                        {
                            case 1:
                                ShopNew1.productschoose2();
                                break;
                            case 2:
                                ShopNew1.question();
                                break;
                            default:
                                ShopNew1.question();
                                break;
                        }
                    }
                    Console.WriteLine();
                    Console.Write($"Введите кол-во сока  - ");
                    int input10 = int.Parse(Console.ReadLine());
                    _productschoose[9] += input10;
                    if (input10 > _productsquantity[9])
                    {
                        Console.WriteLine("Данного количества нет в наличии!");
                        while (input10 > _productsquantity[5])
                        {
                            _productschoose[9] -= input10;
                            Console.Write($"Введите кол-во сока - ");
                            input10 = int.Parse(Console.ReadLine());
                            _productschoose[9] += input10;
                            if (input10 > _productsquantity[9])
                            {
                                Console.WriteLine("Данного количества нет в наличии!");
                                continue;
                            }
                            else if (input10 <= _productsquantity[9])
                            {
                                _choosenprice[9] += input10;
                                _productsquantity[9] -= input10;
                                break;
                            }
                        }
                    }
                    else
                    {
                        _choosenprice[9] += input10;
                        _productsquantity[9] -= input10;
                    }
                    Console.WriteLine("Желаете продолжить? 1 - Да; 2 - Нет");
                    int answer10 = int.Parse(Console.ReadLine());
                    switch (answer10)
                    {
                        case 1:
                            ShopNew1.productschoose2();
                            break;
                        case 2:
                            ShopNew1.question();
                            break;
                        default:
                            ShopNew1.question();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный номер товара!");
                    ShopNew1.productschoose2();
                    break;
            }
        }
    }
}

