using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Mover : UnitInfo
    {
        public  Mover(string name1, string role1, string action1, int speed1, int health1, int damage1)
        {
            name = name1;
            role = role1;
            action = action1;
            speed = speed1;
            health = health1;
            damage = damage1;
            
        }
        public void MoverInfo(string name1
        {
            Console.WriteLine($"Игровой NPC - {name}; Его роль - {role};");
            Console.WriteLine($"Его характеристики:");
            Console.WriteLine($"Его скорость - {speed}");
            Console.WriteLine($"Его здоровье - {health}");
            Console.WriteLine($"Его угор - {damage}");
        }
    }
}
