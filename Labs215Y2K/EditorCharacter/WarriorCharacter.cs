using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{
    class WarriorCharacter : CharacterEditor
    {
        private int _physicalAttack;
        private int _physicalDefence;
        private int _magicAttack;
        private int _magicDefence;
        private int _physicalCriticalDamage;
        private int _magicCriticalDamage;
        private int _physicalCriticalChanse;
        private int _magicCriticalChanse;
        private int _health;
        private double _currentHealth;

        private double _strength;
        private double _dexterity;
        private double _intelligence;
        private double _constitution;

        public double Health
        {
            get
            {
                return _currentHealth = 10 * Constitution + (0.5 * Strength);
            }
            set
            {
                double OldHealth = _currentHealth;
                _currentHealth = value;
                HealtheChangeEvent?.Invoke(OldHealth, value);
            }
        }

        public double PhysicalAttack
        {
            get
            {
                return Strength * 2 + (0.5 * Dexterity);
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
                return 20 + Dexterity * 3 / 10;
            }
        }
        public double MagicCriticalChanse
        {
            get
            {
                return 20 + Intelligence * 1 / 10;
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
                if (value > 250)
                {
                    value = 250;
                    _strength = 250;
                    Console.WriteLine($"Сила больше 250 быть не может");
                }
                if (value < 30)
                {
                    value = 30;
                    _strength = 30;
                    Console.WriteLine($"Сила меньше 30 быть не может");
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
                if (value > 80)
                {
                    value = 80;
                    _dexterity = 80;
                    Console.WriteLine($"Ловкость больше 80 быть не может");
                }
                if (value < 15)
                {
                    value = 15;
                    _dexterity = 15;
                    Console.WriteLine($"Ловкость меньше 15 быть не может");
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
                if (value > 50)
                {
                    value = 50;
                    _intelligence = 50;
                    Console.WriteLine($"Интеллект больше 50 быть не может");
                }
                if (value < 10)
                {
                    value = 10;
                    _intelligence = 10;
                    Console.WriteLine($"Интеллект меньше 10 быть не может");
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
                if (value > 100)
                {
                    value = 100;
                    _constitution = 100;
                    Console.WriteLine($"Телосложение больше 100 быть не может");
                }
                if (value < 25)
                {
                    value = 25;
                    _constitution = 25;
                    Console.WriteLine($"Телосложение меньше 25 быть не может");
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
