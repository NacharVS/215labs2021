using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{

    class CharacterEditor
    {
        private string _name;
        private int _health;
        private int _physicalCriticalDamage;
        private int _magicCriticalDamage;
        private int _magicAttack;
        private int _strength;
        private int _dexterity;
        private int _intelligence;
        private int _constitution;
        private int _mana;
        private int _physicalAttack;
        private int _physicalDefence;
        private int _magicDefence;
        private int _physicalCriticalChanse;
        private int _magicCriticalChanse;

        //public CharacterEditor(string name, int strength, int dexterity, int intelligence, int constitution, int health, int physicalAttack, int magicAttack, int mana, int physicalDefence, int magicDefence, int physicalCriticalDamage, int magicCriticalDamage, int physicalCriticalChanse, int magicCriticalChanse)
        //{
        //    _name = name;
        //    _health = health;
        //    _strength = strength;
        //    _physicalCriticalDamage = physicalCriticalDamage;
        //    _magicCriticalDamage = magicCriticalDamage;
        //    _magicAttack = magicAttack;
        //    _dexterity = dexterity;
        //    _intelligence = intelligence;
        //    _constitution = constitution;
        //    _mana = mana;
        //    _physicalAttack = physicalAttack;
        //    _physicalDefence = physicalDefence;
        //    _magicDefence = magicDefence;
        //    _physicalCriticalChanse = physicalCriticalChanse;
        //    _magicCriticalChanse = magicCriticalChanse;
        //}

        public string Name { get => _name; set => _name = value; }
        //public int Strength
        //{
        //    get
        //    {
        //        return _strength;
        //    }

        //    set
        //    {
        //        //if (value > 45)
        //        //{
        //        //    value = 45;
        //        //    _strength = 45;
        //        //    Console.WriteLine($"Сила больше 45 быть не может");    ЭТО ТОЛЬКО ДЛЯ МАГА РАБОТАЕТ
        //        //}
        //        //if (value < 15)
        //        //{
        //        //    value = 15;
        //        //    _strength = 15;
        //        //    Console.WriteLine($"Сила меньше 15 быть не может");
        //        //}
        //        int OldStrength = _strength;
        //        _strength = value;
        //        StrengthChangeEvent?.Invoke(OldStrength, value);
        //    }
        //}
        //public int Dexterity
        //{
        //    get
        //    {
        //        return _dexterity;
        //    }

        //    set
        //    {
        //        int OldDexterity = _dexterity;
        //        _dexterity = value;
        //        DexterityChangeEvent?.Invoke(OldDexterity, value);
        //    }
        //}
        //public int Intelligence
        //{
        //    get
        //    {
        //        return _intelligence;
        //    }

        //    set
        //    {
        //        int OldIntelligence = _intelligence;
        //        _intelligence = value;
        //        IntelligenceChangeEvent?.Invoke(OldIntelligence, value);
        //    }
        //}
        //public int Constitution
        //{
        //    get
        //    {
        //        return _constitution;
        //    }

        //    set
        //    {
        //        int OldConstitution = _constitution;
        //        _constitution = value;
        //        ConstitutionChangeEvent?.Invoke(OldConstitution, value);
        //    }
        //}
        public int Mana
        {
            get
            {
                return _mana;
            }

            set
            {
                _mana = value;
            }
        }
        public int PhysicalDefence { get => _physicalDefence; set => _physicalDefence = value; }
        public int MagicDefence { get => _magicDefence; set => _magicDefence = value; }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {

                int OldHealth = _health;
                _health = value;
                HealtheChangeEvent?.Invoke(OldHealth, value);

                if (value < 0)
                {
                    value = 0;
                    HealtheChangeEvent?.Invoke(_health, value);
                }
            }
        }
        public int PhysicalAttack
        {
            get
            {
                return _strength * 3 + (5 / 10 * _dexterity);
            }
        }

        public int MagicAttack
        {
            get
            {
                return _intelligence * 4;
            }
        }
        public int PhysicalCriticalDamage1
        {
            get
            {
                return _physicalAttack * (2 + _dexterity * 5 / 100);
            }
        }
        public int MagicCriticalDamage1
        {
            get
            {
                return _magicAttack * (2 + _intelligence * 15 / 1000);
            }
        }
        public int PhysicalCriticalChanse { get => _physicalCriticalChanse; set => _physicalCriticalChanse = value; }
        public int MagicCriticalChanse { get => _magicCriticalChanse; set => _magicCriticalChanse = value; }

        public delegate void HealthChangeDelegate(int OldHealth, int NewHealth);
        public event HealthChangeDelegate HealtheChangeEvent;

        public delegate void CriricalChanceDelegate(int CriticalChance, string NewValue);
        public event CriricalChanceDelegate CricticalChanceEvent;

        public delegate void StrengthChangeDelegate(int OldStrength, int NewStrength);
        public event StrengthChangeDelegate StrengthChangeEvent;

        public delegate void DexterityChangeDelegate(int OldDexterity, int NewDexterity);
        public event DexterityChangeDelegate DexterityChangeEvent;

        public delegate void IntelligenceChangeDelegate(int OldIntelligence, int NewIntelligence);
        public event IntelligenceChangeDelegate IntelligenceChangeEvent;

        public delegate void ConstitutionChangeDelegate(int OldConstitution, int NewConstitution);
        public event ConstitutionChangeDelegate ConstitutionChangeEvent;
    }

}
