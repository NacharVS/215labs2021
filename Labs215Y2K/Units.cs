using System;

namespace Units
{
    class Unit
    {
        public string name;
        public int health;
        public int damage;
        public int armor;
        public int speed;
        public int atackspeed;

      

        public void Work()
        {
            Console.WriteLine($"{name} is working");
        }
    }
    class Work : Unit
    {
        public Unit(string name, int health, int damage, int armor, int speed, int atackspeed)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.armor = armor;
            this.speed = speed;
            this.atackspeed = atackspeed;
        }
    }
}