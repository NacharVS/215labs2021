using System;
using System.Collections.Generic;
using System.Text;

namespace MarketButNewVersion
{
    class InfoClass
    {
        private double _price;
        private double _quantity;
        private string _nameOfProduct;
        private double _nds;

        public InfoClass(double price, double quantity, string nameOfProduct)
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
