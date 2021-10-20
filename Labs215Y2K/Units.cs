using System;

namespace Units
{
    public class Unit
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
    class Builder : Unit
    {
        public Builder(string namec, int healthc, int damagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public void Build()
        {
            Console.WriteLine($"{name} is building");
        }
    }
    class Woodman : Unit
    {
        public Woodman(string namec, int healthc, int damagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public void Build()
        {
            Console.WriteLine($"{name} is minig loag");
        }
    }
    class Miners : Unit
    {
        public Miners(string namec, int healthc, int damagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public void Build()
        {
            Console.WriteLine($"{name} is mining ore");
        }
    }
    class Wariors : Unit
    {
        public Wariors(string namec, int healthc, int damagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public void Build()
        {
            Console.WriteLine($"{name} is attack");
        }
    }
    public class Archers : Unit
    {
        public Archers(string namec, int healthc, int damagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public void Build()
        {
            Console.WriteLine($"{name} is attack");
        }
    }
    class Mages : Unit
    {
        public Mages(string namec, int healthc, int damagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public void Build()
        {
            Console.WriteLine($"{name} is healing");
        }
    }
}