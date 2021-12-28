using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Auto
    {
        private string _brand;
        private string _mark;
        private double _engineVol;
        private int _year;
        private int _price;

        

        public string Brand { get => _brand; set => _brand = value; }
        public string Mark { get => _mark; set => _mark = value; }
        public double EngineVol { get => _engineVol; set => _engineVol = value; }
        public int Year { get => _year; set => _year = value; }
        public int Price { get => _price; set => _price = value; }
    }
}
