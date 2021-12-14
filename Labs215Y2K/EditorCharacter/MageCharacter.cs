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
        private int _health;

        private int _strength;
        private int _dexterity;
        private int _intelligence;
        private int _constitution;

        public int Health
        {
            get
            {
                return 2 * Constitution + (5 / 10 * Strength);
            }
            set
            {
                _health = value;
            }
        }
        public int PhysicalAttack
        {
            get
            {
                return Strength * 3 + (5 / 10 * Dexterity);
            }

        }

        public int MagicAttack
        {
            get
            {
                return Intelligence * 4;
            }
        }
        public int PhysicalCriticalDamage
        {
            get
            {
                return PhysicalAttack * (2 + Dexterity * 5 / 100);
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
        public int MagicCriticalDamage
        {
            get
            {
                return MagicAttack * (2 + Intelligence * 15 / 1000);
            }
        }
        public int PhysicalDefence
        {
            get
            {
                return Constitution * 5 / 10 + Dexterity * 3;
            }

            //set => _physicalDefence = value;
        }
        public int MagicDefence
        {
            get
            {
                return Intelligence * 2;
            }
        }
        public int PhysicalCriticalChanse { get => _physicalCriticalChanse; set => _physicalCriticalChanse = value; }
        public int MagicCriticalChanse { get => _magicCriticalChanse; set => _magicCriticalChanse = value; }
        public int Strength
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
                int OldStrength = _strength;
                _strength = value;
                StrengthChangeEvent?.Invoke(OldStrength, value);
            }
        }
        public int Dexterity
        {
            get
            {
                return _dexterity;
            }

            set
            {
                int OldDexterity = _dexterity;
                _dexterity = value;
                DexterityChangeEvent?.Invoke(OldDexterity, value);
            }
        }
        public int Intelligence
        {
            get
            {
                return _intelligence;
            }

            set
            {
                int OldIntelligence = _intelligence;
                _intelligence = value;
                IntelligenceChangeEvent?.Invoke(OldIntelligence, value);
            }
        }
        public int Constitution
        {
            get
            {
                return _constitution;
            }

            set
            {
                int OldConstitution = _constitution;
                _constitution = value;
                ConstitutionChangeEvent?.Invoke(OldConstitution, value);
            }
        }


        public delegate void HealthChangeDelegate(int OldHealth, int NewHealth);
        public event HealthChangeDelegate HealtheChangeEvent;

        public delegate void CriricalChanceDelegate(int CriticalChance, string NewValue);
        public event CriricalChanceDelegate CricticalChanceEvent;

        public delegate void DexterityChangeDelegate(int OldDexterity, int NewDexterity);
        public event DexterityChangeDelegate DexterityChangeEvent;

        public delegate void IntelligenceChangeDelegate(int OldIntelligence, int NewIntelligence);
        public event IntelligenceChangeDelegate IntelligenceChangeEvent;

        public delegate void ConstitutionChangeDelegate(int OldConstitution, int NewConstitution);
        public event ConstitutionChangeDelegate ConstitutionChangeEvent;

        public delegate void StrengthChangeDelegate(int OldStrength, int NewStrength);
        public event StrengthChangeDelegate StrengthChangeEvent;
    }
}
