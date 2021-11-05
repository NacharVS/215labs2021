using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Shop
    {
        private string _name;
        private double _quantity;
        private double _price;
        private double _discount;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
               _price = value;
            }
        }
        public double Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }
        public void price()
        {
            double quantity1;
            if (Quantity > 1000)
            {
                quantity1 = Quantity / 1000;
                Console.Write($" Цена = {Price} руб. за 100 Гр.   Наличие = {quantity1} кг. или {Quantity} гр.");
                Console.WriteLine();
            }
            else
            {
                Console.Write($" Цена = {Price} руб. за 1 шт.");
                Console.Write($"     Наличие = {Quantity} шт.");
                Console.WriteLine();
            }
        }
    }
}
