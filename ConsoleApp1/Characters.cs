using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Character
    {
        private double _strenght;
        private double _dexterity;
        private double _intelligence;
        private double _constitution;
        private string _name;

        public delegate void HealthValueChangedDelegate();
        private double _currentHealth;
        private double _maxHealth;
        private bool _isWeaken;

        private double _currentMana;
        private double _maxMana;


        private double _p_Defense;
        private double _p_Attack;
        private double _m_Defense;
        private double _p_CrtitChanse;
        private double _p_CritDamage;
        private double _m_Attack;
        private double _m_CritChanse;
        private double _m_CritDamage;

        public bool IsWeaken { get => _isWeaken; }

        public event HealthValueChangedDelegate HealthChangedEvent;

        public Character(double strenght, double dexterity, double intelligence, double constitution, string name)
        {
            Strenght = strenght;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitution = constitution;
            Name = name;

        }

        public virtual double Strenght { get => _strenght; set => _strenght = value; }
        public virtual double Dexterity { get => _dexterity; set => _dexterity = value; }
        public virtual double Intelligence { get => _intelligence; set => _intelligence = value; }
        public virtual double Constitution { get => _constitution; set => _constitution = value; }
        public virtual string Name { get => _name; set => _name = value; }

        public void Health(int maxHealth)
        {
            _currentHealth = maxHealth;
            _maxHealth = maxHealth;

        }


        public double MaxHealth
        {
            get { return _maxHealth; }
            set
            {
                if (_isWeaken)
                {
                    _maxHealth -= _maxHealth * 0.1;
                }
                else
                    _maxHealth = value;
            }
        }
        public double CurrentHealth
        {
            get { return _currentHealth; }
            set
            {
                if (_currentHealth + value > MaxHealth)
                {
                    _currentHealth = MaxHealth;
                }
                if (_currentHealth + value <= 0)
                {
                    _currentHealth = 0;
                    Console.WriteLine("You died");
                }
                else
                    _currentHealth = value;
            }
        }
        public double CurrentMana
        {
            get => _currentMana;
            set
            {
                if (value <= MaxMana)
                {

                    if (value >= 0)
                        _currentMana = value;
                    if (value <= MaxMana * 0.2)
                    {
                        MaxHealth -= MaxHealth * 0.2;
                        _currentMana = value;
                    }
                    if (value < 0)
                    {
                        _currentMana = 0;
                        Console.WriteLine("Недостаточно маны");
                    }
                }
            }
        }
        public void Mana(int maxMana)
        {
            _currentMana = maxMana;
            _maxMana = maxMana;
        }

        public double MaxMana
        {
            get { return _maxMana; }
            set
            {
                    _maxMana = value;
            }

        }
        public double PDefense
        {
            get
            {
                return Constitution * 0.5 + Dexterity * 3;
            }
        }

        public static void Buff(Character unit)
        {
            Console.WriteLine("улучшение произойдет с вероятностью 50%");
            Random z = new Random();
            if (z.Next(0, 1) == 1)
            {
                unit.Constitution += z.Next(10, 30);
                unit.Strenght += z.Next(10, 30);
                unit.Intelligence += z.Next(10, 30);
                unit.Dexterity += z.Next(10, 30);
                Console.WriteLine("произошло улучшение всех персонажей");
                Console.WriteLine(unit.Constitution + " - Constitution");
                Console.WriteLine(unit.Strenght + " - Strength");
                Console.WriteLine(unit.Intelligence + " - Intelligence");
                Console.WriteLine(unit.Dexterity + " - Dexterity");
            }
            else
                Console.WriteLine("Улучшения не произошло. Персонажи не изменились");
        }
            public static void PAttack(Character attunit, List<Character> Chaptres)
        {
            Random z = new Random();
            Console.WriteLine("Выберите атакуемого персонажа");
            for (int i = 0; i < Chaptres.Count; i++)
            {
                Console.WriteLine($"({i + 1}) {Chaptres[i].Name}");
            }
            int choice = int.Parse(Console.ReadLine());
            if (attunit.PCritChance >= z.Next(0, 100))
            {
                Chaptres[choice - 1].CurrentHealth -= attunit.PCritDamage * (attunit.PCritDamage / Chaptres[choice - 1].PDefense);
                Console.WriteLine($"У {Chaptres[choice - 1].Name} осталось  {Chaptres[choice - 1].CurrentHealth} hp после атаки {attunit.Name} в размере {attunit.PCritDamage * (attunit.PCritDamage / Chaptres[choice - 1].PDefense)} получаемого урона");
                if (Chaptres[choice - 1].CurrentHealth > 0)
                {
                    Chaptres[choice - 1].MaxHealth = 0.5 * Chaptres[choice - 1].Strenght + 2 * Chaptres[choice - 1].Constitution;
                }

                if (Chaptres[choice - 1].CurrentHealth <= 0)
                {
                    Chaptres.Remove(Chaptres[choice - 1]);
                }
            }
            else
            {


                Chaptres[choice - 1].CurrentHealth -= attunit.P_Attack * (attunit.P_Attack / Chaptres[choice - 1].M_Defense);
                Console.WriteLine($"У {Chaptres[choice - 1].Name} осталось  {Chaptres[choice - 1].CurrentHealth} hp после атаки {attunit.Name} в размере урона {attunit.P_Attack * (attunit.P_Attack / Chaptres[choice - 1].M_Defense)}");
                if (Chaptres[choice - 1].CurrentHealth > 0)
                {
                    Chaptres[choice - 1].MaxHealth = 0.5 * Chaptres[choice - 1].Strenght + 2 * Chaptres[choice - 1].Constitution;
                }

                if (Chaptres[choice - 1].CurrentHealth <= 0)
                {
                    Chaptres.Remove(Chaptres[choice - 1]);
                }
            }
        }

        public static void DeBuff(string message)
        {
            Console.WriteLine(message);

        }

        public static Character operator +(Character objectOne, Character object2)
        {
            return new Character(objectOne.Strenght + object2.Strenght, objectOne.Dexterity + object2.Dexterity, objectOne.Intelligence + object2.Intelligence, objectOne.Constitution + object2.Constitution, "Парный юнит (ПАРНАЯ АТАКА)");

        }
        public double MDefense

        {
            get
            {
                return Intelligence * 2;
            }
        }
        public double PCritChance
        {
            get
            {
                return 20 + Dexterity * 0.3;
            }
            set
            {
                _p_CrtitChanse = value;
            }
        }
        public double P_Attack
        {
            get
            {
                return Strenght * 3 + Dexterity * 0.5;
            }
            private set
            {
                _p_Attack = value;
            }
        }
        public double PCritDamage
        {
            get
            {
                return P_Attack * (2 + Dexterity * 0.05);
            }
            set
            {
                _p_CritDamage = value;
            }
        }
        public double MAttack
        {
            get
            {
                return Intelligence * 4;
            }
        }
        public double MCritChance
        {
            get
            {
                return 20 + Intelligence * 0.1;
            }
        }
        public double MCritDamage
        {
            get
            {
                return MAttack * (2 + Intelligence * 0.15);
            }
        }
        public double M_Defense

        {
            get
            {
                return Intelligence * 2;
            }
        }
    }
}
