using System;
using Labs215Y2K;

namespace Units
{
    public  class Unit
    {
        public string name;
        public int CurrentHealth;
        public int MaxHealth;
        public int MinDamage;
        public int MaxDamage;
        public int CurrentArrows;
        public int Healing;
        public int range;
        public int armor;
        public int speed;
        public int atackspeed;
        public int workspeed;
        public int MinRangeDamage;
        public int MaxRangeDamage;

    }
    class Peacful : Unit
    {
        public Peacful(string namec, int MaxHealthc,int MinDamagec, int MaxDamagec, int armorc, int speedc, int workspeedc)
        {
            name = namec;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            speed = speedc;
            workspeed = workspeedc;
        }
        public static void Moving(string namec)
        {
            Console.WriteLine($"{namec} идёт");
        }

    }
    class Warior: Unit
    {
        public Warior(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int atackspeedc)
        {
            name = namec;
            CurrentHealth = CurrentHealthc;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
        }
        public static void Damage(string namec, int MinDamagec, int MaxDamagec)
        {
            int damage = new Random().Next(MinDamagec, MaxDamagec);
            Console.WriteLine($"{namec} нанёс {damage} урона");
        }

    }
    class Healer : Unit
    {
        public Healer(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec, int armorc, int speedc, int atackspeedc,int Healingc)
        {
            name = namec;
            CurrentHealth = CurrentHealthc;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            speed = speedc;
            atackspeed = atackspeedc;
            Healing = Healingc;
        }
        public static void Damage(string namec, int MinDamagec, int MaxDamagec)
        {
            int damage = new Random().Next(MinDamagec, MaxDamagec);
            Console.WriteLine($"{namec} нанёс {damage} урона");
        }

    }
    class Figters : Unit
    {
        public Figters(string namec, int MaxHealthc, int CurrentHealthc, int MinDamagec, int MaxDamagec, int MinRangeDamagec, int MaxRangeDamagec, int armorc, int rangec, int speedc, int atackspeedc)
        {
            name = namec;
            CurrentHealth = CurrentHealthc;
            MaxHealth = MaxHealthc;
            MinDamage = MinDamagec;
            MaxDamage = MaxDamagec;
            armor = armorc;
            range = rangec;
            speed = speedc;
            atackspeed = atackspeedc;
            MinRangeDamage = MinRangeDamagec;
            MaxRangeDamage = MaxRangeDamagec;
        }

        public static void Moving(string namec)
        {
            Console.WriteLine($"{namec} идёт");
        }
        public static void Damage(string namec, int MinDamagec, int MaxDamagec)
        {
            int damage = new Random().Next(MinDamagec, MaxDamagec);
            Console.WriteLine($"{namec} нанёс {damage} урона");
        }
        public static void ArcherDamage(string namec, int MinRanageDamagec, int MaxRangeDamagec,string MobName,int CurrentHealth,int CurrentArrows)
        {
            int damage = new Random().Next(MinRanageDamagec, MaxRangeDamagec);
            Console.WriteLine($"{namec} нанёс {damage} урона в дальнем бою {MobName}");
            CurrentHealth -= damage;
            Console.WriteLine(CurrentHealth);
            CurrentArrows--;
            Console.WriteLine(CurrentArrows);
        }
        public static void Heal(string namec, int MinRanageDamagec, int MaxRangeDamagec)
        {

        }
    }
}    
