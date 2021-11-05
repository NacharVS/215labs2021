using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class market : marketnew
    {
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
