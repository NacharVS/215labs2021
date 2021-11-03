using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class NewAshan
    {
        private string _Names;
        private int _Price;
        private int _Count;
        private int _SumPrice;
        private int _NumberOfProduct;

        public string Names
        {
            get
            {
                return _Names;
            }

            set
            {
                _Names = value;
            }
        }
        public int Price { get => _Price; set => _Price = value; }
        public int Count { get => _Count; set => _Count = value; }
        public int SumPrice { get => _SumPrice; set => _SumPrice = value; }
        public int NumberOfProduct1 { get => _NumberOfProduct; set => _NumberOfProduct = value; }

        internal void Products()
        {
            Console.WriteLine("Введите номер товара, который вам нужен");
            _NumberOfProduct = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во товара");
            _Count = int.Parse(Console.ReadLine());
        }
    }
}
