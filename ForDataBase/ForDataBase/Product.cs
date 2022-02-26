using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDataBase
{
    class Product
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        private string _name;
        private double _price;
        private int _quantity;

        public Product(int quantity, double price, string name)
        {

            Quantity = quantity;
            Price = price;
            Name = name;
        }

        public int Quantity { get => _quantity; set => _quantity = value; }
        public double Price { get => _price; set => _price = value; }
        public string Name { get => _name; set => _name = value; }

    }
}
