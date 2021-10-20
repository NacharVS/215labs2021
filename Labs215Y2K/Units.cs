using System;

namespace Units
{
    public  class Unit
    {
        public string name;
        public int health;
        public int damage;
        public int armor;
        public int speed;
        public int atackspeed;
        public int workspeed;



    }
    class Peacful : Unit
    {
        public Peacful(string namec, int healthc, int damagec, int armorc, int speedc, int workspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            armor = armorc;
            speed = speedc;
            workspeed = workspeedc;
        }
        public static void Moving(string namec)
        {
            Console.WriteLine($"{namec} идёт");
        }

    }
    class Figters : Unit
    {
        public Figters(string namec, int healthc, int damagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            health = healthc;
            damage = damagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public static void Moving(string namec)
        {
            Console.WriteLine($"{namec} идёт");
        }
        public static void Arche(string namec,int damagec,int atackspeedc)
        {
            Console.WriteLine($"{namec} атакует, урон {damagec}");
        }
    }
    
}