using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{
    class ArcherCharacter : CharacterEditor
    {
        private int _physicalAttack;
        private int _physicalDefence;
        private int _magicAttack;
        private int _magicDefence;
        private int _physicalCriticalDamage;
        private int _magicCriticalDamage;
        private double _physicalCriticalChanse;
        private double _magicCriticalChanse;
        private double _health;
        private double _currentHealth;


        private double _strength;
        private double _dexterity;
        private double _intelligence;
        private double _constitution;


        public double Health
        {
            get
            {
                return _health;
            }
            set
            {
                //if (_health < 0.5 * _health)
                //{
                //    Console.WriteLine($"Здоровье {Name} меньше 50%, поэтому все характеристики снижены на 10%");
                //    Strength -= Strength * 0.1;
                //    Dexterity -= Dexterity * 0.1;
                //    Intelligence -= Intelligence * 0.1;
                //    Constitution -= Constitution * 0.1;
                //    Console.WriteLine();
                //}
                //else if (_health == 0)
                //{
                //    Console.WriteLine($"Здоровье {Name} 0%");
                //}
                double OldHealth = _health;
                _health = value;
                HealtheChangeEvent?.Invoke(OldHealth, value);
            }
        }

        public double PhysicalAttack
        {
            get
            {
                return Strength * 3 + (5 / 10 * Dexterity);
            }

        }

        public double MagicAttack
        {
            get
            {
                return Intelligence * 4;
            }
        }
        public double PhysicalCriticalDamage
        {
            get
            {
                return PhysicalAttack * (2 + Dexterity * 5 / 100);
            }
        }
        public double MagicCriticalDamage
        {
            get
            {
                return MagicAttack * (2 + Intelligence * 15 / 1000);
            }
        }
        public double PhysicalDefence
        { 
            get
            {
                return Constitution * 5 / 10 + Dexterity * 3;
            }
        }
        public double MagicDefence
        {
            get
            {
                return Intelligence * 2;
            }
        }
        public double PhysicalCriticalChanse { get => _physicalCriticalChanse; set => _physicalCriticalChanse = value; }
        public double MagicCriticalChanse { get => _magicCriticalChanse; set => _magicCriticalChanse = value; }
        public double Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                if (value > 55)
                {
                    value = 55;
                    _strength = 55;
                    Console.WriteLine($"Сила больше 55 быть не может");
                }
                if (value < 20)
                {
                    value = 20;
                    _strength = 20;
                    Console.WriteLine($"Сила меньше 20 быть не может");
                }
                double OldStrength = _strength;
                _strength = value;
                StrengthChangeEvent?.Invoke(OldStrength, value);
            }
        }
        public double Dexterity
        {
            get
            {
                return _dexterity;
            }

            set
            {
                if (value > 250)
                {
                    value = 250;
                    _dexterity = 250;
                    Console.WriteLine($"Ловкость больше 250 быть не может");
                }
                if (value < 30)
                {
                    value = 30;
                    _dexterity = 30;
                    Console.WriteLine($"Ловкость меньше 30 быть не может");
                }
                double OldDexterity = _dexterity;
                _dexterity = value;
                DexterityChangeEvent?.Invoke(OldDexterity, value);
            }
        }
        public double Intelligence
        {
            get
            {
                return _intelligence;
            }

            set
            {
                if (value > 70)
                {
                    value = 70;
                    _intelligence = 70;
                    Console.WriteLine($"Интеллект больше 70 быть не может");
                }
                if (value < 15)
                {
                    value = 15;
                    _intelligence = 15;
                    Console.WriteLine($"Интеллект меньше 15 быть не может");
                }
                double OldIntelligence = _intelligence;
                _intelligence = value;
                IntelligenceChangeEvent?.Invoke(OldIntelligence, value);
            }
        }
        public double Constitution
        {
            get
            {
                return _constitution;
            }

            set
            {
                if (value > 70)
                {
                    value = 70;
                    _constitution = 70;
                    Console.WriteLine($"Телосложение больше 70 быть не может");
                }
                if (value < 20)
                {
                    value = 20;
                    _constitution = 20;
                    Console.WriteLine($"Телосложение меньше 20 быть не может");
                }
                double OldConstitution = _constitution;
                _constitution = value;
                ConstitutionChangeEvent?.Invoke(OldConstitution, value);
            }
        }


        public delegate void HealthChangeDelegate(double OldHealth, double NewHealth);
        public event HealthChangeDelegate HealtheChangeEvent;

        public delegate void CriricalChanceDelegate(double CriticalChance, string NewValue);
        public event CriricalChanceDelegate CricticalChanceEvent;

        public delegate void DexterityChangeDelegate(double OldDexterity, double NewDexterity);
        public event DexterityChangeDelegate DexterityChangeEvent;

        public delegate void IntelligenceChangeDelegate(double OldIntelligence, double NewIntelligence);
        public event IntelligenceChangeDelegate IntelligenceChangeEvent;

        public delegate void ConstitutionChangeDelegate(double OldConstitution, double NewConstitution);
        public event ConstitutionChangeDelegate ConstitutionChangeEvent;

        public delegate void StrengthChangeDelegate(double OldStrength, double NewStrength);
        public event StrengthChangeDelegate StrengthChangeEvent;
    }
}
