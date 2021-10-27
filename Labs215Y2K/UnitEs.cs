using System;

namespace Units
{
     class UnitEs
    {
        private string _name;
        private int _CurrentHealth;
        private int _MaxHealth;
        private int _MinDamage;
        private int _MaxDamage;
        private int _CurrentArrows;
        private int _Healing;
        private int _range;
        private int _armor;
        private int _speed;
        private int _atackspeed;
        private int _workspeed;

        public string Name { get => _name; set => _name = value; }
        public int CurrentHealth 
        { 
            get => _CurrentHealth; 
            set 
            {
                if (value > 0)
                
                    _CurrentHealth = value;
                
                else
                {
                    _CurrentHealth = 0;
                    Death();
                }
            }
        }
        internal void GetDamage(int damage)
        {
            _CurrentHealth = _CurrentHealth - damage;
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
    class Peasant : UnitEs
    {

    }
}
