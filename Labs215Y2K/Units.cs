using System;

namespace Units
{
    public class Unit
    {
        private string _name;
        private int _CurrentHealth;
        private int _MaxHealth;
        private int _MinDamage;
        private int _MaxDamage;
        private int _armor;
        private int _speed;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public int Health
        {
            get => _CurrentHealth;
            set
            {
                if (value > 0)
                {
                    _CurrentHealth = value;
                }
                else
                {
                    _CurrentHealth = 0;
                    Console.WriteLine();
                    Death();
                }
            }
        }
        internal void GetDamage(int damage)
        {
            Health = Health - damage;
        }
        internal void GetHeal(int Healing)
        {
            Health = Health + Healing;
        }

        internal int InflictDamage()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }

        public int MinDamage { get => _MinDamage; set => _MinDamage = value; }
        public int MaxDamage { get => _MaxDamage; set => _MaxDamage = value; }

        private void Death()
        {
            Console.WriteLine($"{_name} умер");
        }
    }
    class Warrior : Unit
    {

    }
    class Archer : Unit
    {
        private int _CurrentArrows;
        private int _Range;

        public int CurrentArrows { get => _CurrentArrows; set => _CurrentArrows = value; }
        public int Range { get => _Range; set => _Range = value; }
    }
    class Mage : Unit
    {
        private int _Mana;

        public int Mana { get => Mana; set => Mana = value; }
    }
    class Healer : Unit
    {
        private int _Healing;

        public int Healing { get => _Healing; set => _Healing = value; }
    }
    class Builder : Unit
    {
        internal void build()
        {
            Console.WriteLine("Строит здания");
        }
    }
    class Farmer : Unit
    {
        internal void Farming()
        {
            Console.WriteLine("Собирает урожай");
        }
    }
    class Miner : Unit
    {
        internal void Mining()
        {
            Console.WriteLine("Копает камень");
        }
    }
}
