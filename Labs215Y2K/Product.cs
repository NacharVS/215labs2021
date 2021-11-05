using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Product
    {

        // скидка 20% но не больше 500 у.е. 
        private double _price;
        private double _quantity;
        private string _nameOfProduct;
        private double _nds;

        public Product(double price, double quantity, string nameOfProduct)
        {
            _price = price;
            _quantity = quantity;
            _nameOfProduct = nameOfProduct;
            _nds = _price * 0.19;
        }

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
    }
}
