using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K.Character
{
    class CharacterEditor
    {
        private string _name;
        private int _health;
        private int _criticalDamage;
        private int _magicAttack;
        private int _strength;
        private int _dexterity;
        private int _intelligence;
        private int _constitution;
        private int _mana;
        private int _physicalAttack;
        private int _physicalDefence;
        private int _magicDefence;
        private int _criticalChanse;

        public CharacterEditor(string name, int dexterity, int intelligence, int constitution, int health, int physicalAttack, int magicAttack, int criticalDamage, int mana, int physicalDefence, int magicDefence, int criticalChanse)
        {
            _name = name;
            _health = health;
            _criticalDamage = criticalDamage;
            _magicAttack = magicAttack;
            _dexterity = dexterity;
            _intelligence = intelligence;
            _constitution = constitution;
            _mana = mana;
            _physicalAttack = physicalAttack;
            _physicalDefence = physicalDefence;
            _magicDefence = magicDefence;
            _criticalChanse = criticalChanse;
        }

        public string Name { get => _name; set => _name = value; }

        public int CriticalDamage { get => _criticalDamage; set => _criticalDamage = value; }
        public int MagicAttack { get => _magicAttack; set => _magicAttack = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
        public int Mana 
        { 
            get => _mana;

            set
            {
                _mana = Intelligence * 3;
            }
        }
        public int PhysicalAttack { get => _physicalAttack; set => _physicalAttack = value; }
        public int PhysicalDefence { get => _physicalDefence; set => _physicalDefence = value; }
        public int MagicDefence { get => _magicDefence; set => _magicDefence = value; }
        public int CriticalChanse { get => _criticalChanse; set => _criticalChanse = value; }
        public int Health { get => _health; set => _health = value; }
    }
}
