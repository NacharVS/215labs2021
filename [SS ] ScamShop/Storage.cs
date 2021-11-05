using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScamShop
{
    class Storage
    {
            private string _name;
            private double _prices;
            private double _quantity;

        public Storage(double prices, double quantity, string name)
        {
            Prices = prices;
            Quantity = quantity;
            Name = name;

        }


        public double Prices
        {
            get
            {
                return _prices;
            }

            set
            {
                _prices = value;
            }
        }

        public string Name { get => _name; set => _name = value; }
        public double Quantity { get => _quantity; set => _quantity = value; }
    }


}
