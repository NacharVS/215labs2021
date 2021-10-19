using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Peasant : Unit
    {
        public Peasant(string namec, int speedc, int damagec, int healthc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            speed = speedc;
        }

        public void Work()
        {
            Console.WriteLine($"{name} is working");
        }
    }
}
