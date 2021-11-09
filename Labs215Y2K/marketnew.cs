using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class marketnew 
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
    }
}
