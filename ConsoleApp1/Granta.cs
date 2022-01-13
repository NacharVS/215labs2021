using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs215Y2K
{
    class Granta:LADA
    {
        private string _spoiler;
        public string Spoiler { get => _spoiler; set => _spoiler = value; }
        public Granta(string name, int maxspeed, string colour, string spoiler) : base(name, maxspeed, colour)
        {
            Name = name;
            Maxspeed = maxspeed;
            Colour = colour;
            Spoiler = spoiler;
            

        }

        
    }
}
