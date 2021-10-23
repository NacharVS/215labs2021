using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Unit
    {
        public string typeUnit;
        public static int currenthealth;
        public static int maxhealth;
        public int mindamage;
        public int maxdamage;
        public int speed;
        public int attackspeed;
        public void Move()
        {
            Console.WriteLine($" {typeUnit} is moving");
        }
    }
}
