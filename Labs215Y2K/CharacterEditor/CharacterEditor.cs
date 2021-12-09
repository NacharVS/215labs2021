using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.EditorCharacter
{

    class CharacterEditor : Test
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

        public CharacterEditor(string name, int strength, int dexterity, int intelligence, int constitution, int health, int physicalAttack, int magicAttack, int mana, int physicalDefence, int magicDefence, int physicalCriticalDamage, int magicCriticalDamage, int physicalCriticalChanse, int magicCriticalChanse)
        {
            _name = name;
            _health = health;
            _strength = strength;
            _physicalCriticalDamage = physicalCriticalDamage;
            _magicCriticalDamage = magicCriticalDamage;
            _magicAttack = magicAttack;
            _dexterity = dexterity;
            _intelligence = intelligence;
            _constitution = constitution;
            _mana = mana;
            _physicalAttack = physicalAttack;
            _physicalDefence = physicalDefence;
            _magicDefence = magicDefence;
            _physicalCriticalChanse = physicalCriticalChanse;
            _magicCriticalChanse = magicCriticalChanse;
        }

        public string Name { get => _name; set => _name = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
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
                if (_health < (0.5 * _health))
                {
                    _strength = _strength * 1 / 10;
                    _dexterity = _dexterity * 1 / 10;
                    _intelligence = _intelligence * 1 / 10;
                    _constitution = _constitution * 1 / 10;
                }

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
            get => _physicalAttack;

            set
            {
                //_physicalAttack = _physicalAttack * (_physicalAttack / _physicalDefence);
                _physicalAttack = value;
            }
        }
        public int MagicAttack
        {
            get => _magicAttack;

            set
            {
                //_magicAttack = _magicAttack * (_magicAttack / _magicDefence);
                _magicAttack = value;
            }
        }
        public int MagicCriticalDamage
        {
            get => _magicCriticalDamage;

            set
            {
                //_magicCriticalDamage = _magicCriticalDamage * (_magicCriticalDamage / _magicDefence);
                _magicCriticalDamage = value;
            }
        }//Урон равен p.attack*(p.attak/p.Defence)
        public int PhysicalCriticalDamage
        {
            get => _physicalCriticalDamage;

            set
            {
                //_physicalCriticalDamage = _physicalCriticalDamage * (_physicalCriticalDamage / _physicalDefence);
                _physicalCriticalDamage = value;
            }
        }
        public int PhysicalCriticalChanse { get => _physicalCriticalChanse; set => _physicalCriticalChanse = value; }
        public int MagicCriticalChanse { get => _magicCriticalChanse; set => _magicCriticalChanse = value; }



        public delegate void HealthChangeDelegate(int OldHealth, int NewHealth);
        public event HealthChangeDelegate HealtheChangeEvent;
        public delegate void CriricalChanceDelegate(int CriticalChance, string NewValue);
        public event CriricalChanceDelegate CricticalChanceEvent;
    }

}
