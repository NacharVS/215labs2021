using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs215Y2K
{
    class LADA
    {
        private string _name;
        private int _maxspeed;
        private string _colour;

        public LADA(string name, int maxspeed, string colour)
        {
            _name = name;
            _maxspeed = maxspeed;
            _colour = colour;
        }

        public string Name { get => _name; set => _name = value; }
        public int Maxspeed { get => _maxspeed; set => _maxspeed = value; }
        public string Colour { get => _colour; set => _colour = value; }
    }
}
