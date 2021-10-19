using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class UnitInfo
    {
        public string name;
        public string role;
        public string action;
        public int speed;
        public int health;
        public int damage;
        public void infounit()
        {
            Console.WriteLine($"Игровой NPC - {name}; Его роль - {role};");
            Console.WriteLine($"Его характеристики:");
            Console.WriteLine($"скорость - {speed}");
            Console.WriteLine($"здоровье - {health}");
            Console.WriteLine($"урон - {damage}");
        }
    }
}
