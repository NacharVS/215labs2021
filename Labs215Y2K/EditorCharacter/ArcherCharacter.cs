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
                return _currentHealth = 2 * Constitution + (5 / 10 * Strength);
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

            //set => _physicalDefence = value;
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
