using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class NewAshan
    {
        private string _names;
        private double _price;
        private int _count;
        private double _sumPrice;
        private int _numberOfProduct;
        private double _nds;
        private int _discount;
        public NewAshan(string names, double price, int count, double sumPrice, int numberOfProduct, double nds, int discount)
        {
            _names = names;
            _price = price;
            _count = count;
            _sumPrice = sumPrice;
            _numberOfProduct = numberOfProduct;
            _nds = price * 0.19;
            _discount = discount;
        }

        public string Names
        {
            get
            {
                return _names;
            }

            set
            {
                _names = value;
            }
        }
        public double Price { get => _price; set => _price = value; }
        public int Count { get => _count; set => _count = value; }
        public double SumPrice { get => _sumPrice; set => _sumPrice = value; }
        public int NumberOfProduct1 { get => _numberOfProduct; set => _numberOfProduct = value; }

        internal void Products()
        {
            Console.WriteLine("Введите номер товара, который вам нужен");
            _numberOfProduct = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во товара");
            _count = int.Parse(Console.ReadLine());
        }
    }
}
