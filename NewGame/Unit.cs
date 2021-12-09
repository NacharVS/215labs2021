using System;
using System.Collections.Generic;
using System.Text;

namespace New_Game
{
    class Unit:IGameInterface
    {
        private double _strength;
        private double _dexterity;
        private double _intelligence;
        private double _constitution;

        private string _name;

        private double _maxHealth;
        private double _maxMana;

        private double _p_Defense;
        private double _p_Attack;
        private double _m_Defense;
        private double _p_CrtitChanse;
        private double _p_CritDamage;
        private double _m_Attack;
        private double _m_CritChanse;
        private double _m_CritDamage;

        private double _currencyHealth;
        private double _currencyMana;

        public virtual double Strength { get => _strength; set => _strength = value; }
        public virtual double Dexterity { get => _dexterity; set => _dexterity = value; }
        public virtual double Intelligence { get => _intelligence; set => _intelligence = value; }
        public virtual double Constitution { get => _constitution; set => _constitution = value; }
        public double MaxHealth
        {
            get
            {
                return _maxHealth;
            }
            set
            {
                double oldvalue = _maxHealth;
                _maxHealth = value;

            }
        }
        public double MaxMana { get => _maxMana; set => _maxMana = value; }
        public double P_Defense { get => _p_Defense; set => _p_Defense = value; }
        public double P_Attack { get => _p_Attack; set => _p_Attack = value; }
        public double M_Defense { get => _m_Defense; set => _m_Defense = value; }
        public double P_CritChance { get => _p_CrtitChanse; set => _p_CrtitChanse = value; }
        public double P_CritDamage { get => _p_CritDamage; set => _p_CritDamage = value; }
        public double MagAttack { get => _m_Attack; set => _m_Attack = value; }
        public double MagCritChanse { get => _m_CritChanse; set => _m_CritChanse = value; }
        public double MagCritDamage { get => _m_CritDamage; set => _m_CritDamage = value; }
        public double CurrencyHealth { get => _currencyHealth; set
            {
                if (value > 0)
                    _currencyHealth = value;
                else
                {
                    _currencyHealth = 0;
                    Console.WriteLine($"{Name} мёртв.");
                }

                
            }
        }
        public double CurrencyMana { get => _currencyMana; set => _currencyMana = value; }
        public string Name { get => _name; set => _name = value; }

        delegate void CritValueHealth(double HP);
        event CritValueHealth Notify;
        public static void Buff(Unit unit)
        {
            Random z = new Random();
            if (z.Next(0, 1) == 1)
            {
                unit.Constitution += z.Next(10, 30);
                unit.Strength += z.Next(10, 30);
                unit.Intelligence += z.Next(10, 30);
                unit.Dexterity += z.Next(10, 30);
            }
        }
        public static void PAttack(Unit attunit, List <Unit> Chaptres)
        {
            Random z = new Random();
            Console.WriteLine("Выберите персонажа, которого хотите атаковать.");
            for (int i = 0; i<Chaptres.Count; i++)
            {
                Console.WriteLine($"({i+1}) {Chaptres[i].Name}");
            }
            int choice = int.Parse(Console.ReadLine());
            if (attunit.P_CritChance >= z.Next(0,100))
            {
                Chaptres[choice - 1].CurrencyHealth -= attunit.P_CritDamage * (attunit.P_CritDamage / Chaptres[choice - 1].P_Defense);
                Console.WriteLine($"У {Chaptres[choice - 1].Name} осталось  {Chaptres[choice - 1].CurrencyHealth} hp после КРИТИЧЕСКОЙ атаки {attunit.Name}");
            }
                else
            { 
                Chaptres[choice - 1].CurrencyHealth -= attunit.P_Attack * (attunit.P_Attack / Chaptres[choice - 1].P_Defense);
                Console.WriteLine($"У {Chaptres[choice-1].Name} осталось  {Chaptres[choice - 1].CurrencyHealth} hp после атаки {attunit.Name}");
            }

        }
    }
}
