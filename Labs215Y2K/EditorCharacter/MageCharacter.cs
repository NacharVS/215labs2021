using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{
    class MageCharacter : CharacterEditor
    {
        private int _physicalAttack;
        private int _physicalDefence;
        private int _magicAttack;
        private int _magicDefence;
        private int _physicalCriticalDamage;
        private int _magicCriticalDamage;
        private int _physicalCriticalChanse;
        private int _magicCriticalChanse;
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
                double OldHealth = _health;
                _health = value;
                HealtheChangeEvent?.Invoke(OldHealth, value);
            }
        }

        public double PhysicalAttack
        {
            get
            {
                return Strength * 3 + (0.15 * Dexterity);
            }

        }

        public double MagicAttack
        {
            get
            {
                return Intelligence * 3;
            }
        }
        public double PhysicalCriticalDamage
        {
            get
            {
                return PhysicalAttack * (2 + Dexterity * 0.05);
            }
            //get
            //{
            //    return _physicalCriticalDamage;
            //}
            //set
            //{
            //    _physicalCriticalDamage = _physicalAttack * (2 + _dexterity * 5 / 100);
            //}
        }
        public double MagicCriticalDamage
        {
            get
            {
                return MagicAttack * (2 + Intelligence * 0.001);
            }
        }
        public double PhysicalDefence
        {
            get
            {
                return Constitution * 0.5 + Dexterity * 3;
            }

            //set => _physicalDefence = value;
        }
        public double MagicDefence
        {
            get
            {
                return Intelligence * 2;
            }
        }
        public double PhysicalCriticalChanse
        { 
            get
            {
                return 20 + Dexterity * 0.3;
            }
        }
        public double MagicCriticalChanse
        {
            get
            {
                return 20 + Intelligence * 0.3;
            }
        }
        public double Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                if (value > 45)
                {
                    value = 45;
                    _strength = 45;
                    Console.WriteLine($"Сила больше 45 быть не может");
                }
                if (value < 15)
                {
                    value = 15;
                    _strength = 15;
                    Console.WriteLine($"Сила меньше 15 быть не может");
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
                if (value > 70)
                {
                    value = 70;
                    _dexterity = 70;
                    Console.WriteLine($"Ловкость больше 70 быть не может");
                }
                if (value < 20)
                {
                    value = 20;
                    _dexterity = 20;
                    Console.WriteLine($"Ловкость меньше 20 быть не может");
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
                if (value > 250)
                {
                    value = 250;
                    _intelligence = 250;
                    Console.WriteLine($"Интеллект больше 250 быть не может");
                }
                if (value < 30)
                {
                    value = 30;
                    _intelligence = 30;
                    Console.WriteLine($"Интеллект меньше 30 быть не может");
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
                if (value > 65)
                {
                    value = 65;
                    _constitution = 65;
                    Console.WriteLine($"Телосложение больше 65 быть не может");
                }
                if (value < 15)
                {
                    value = 15;
                    _constitution = 15;
                    Console.WriteLine($"Телосложение меньше 15 быть не может");
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
