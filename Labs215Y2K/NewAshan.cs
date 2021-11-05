using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class NewAshan
    {
        private string _names;
        private double _price;
        private int _quantity;
        private string _pieceOrWeight;
        private double _sumPrice;
        private int _numberOfProduct;
        private double _nds;
        private int _discount;
        public NewAshan(int numberOfProduct, string names, double price, string pieceOrWeight, int quantity)
        {
            _numberOfProduct = numberOfProduct;
            _names = names;
            _price = price;
            _quantity = quantity;
            _pieceOrWeight = pieceOrWeight;
            _nds = _price * 0.19;
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
        public int Count { get => _quantity; set => _quantity = value; }
        public double SumPrice { get => _sumPrice; set => _sumPrice = value; }
        public int NumberOfProduct { get => _numberOfProduct; set => _numberOfProduct = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public string PieceOrWeight { get => _pieceOrWeight; set => _pieceOrWeight = value; }
        public double Nds
        {
            get
            {
                return _nds;
            }

            set
            {
                if (value > _price * 0.19)
                    _nds = _price * 0.19;
                else
                    _nds = value;
            }
        }

        internal void Products()
        {
            Console.WriteLine("Введите кол-во видов товаров: ");
            int QuantityOfGoods = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите номер товара: ");
            NumberOfProduct = int.Parse(Console.ReadLine());

            Console.WriteLine("Кол-во товара (товары на развес указывать в граммах с шагом в 100): ");
            Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Для продолжения введите - 1, для завершения - 0");
            int yesno = int.Parse(Console.ReadLine());

            if (yesno == 1)
            {

            }
            else
            {

            }
        }
    }
}
