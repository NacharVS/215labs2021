using System;

namespace Units
{
    public class UnitEs
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
        public void Attack()
        {
            Console.WriteLine($"{name} идёт");
        }
    }
}
