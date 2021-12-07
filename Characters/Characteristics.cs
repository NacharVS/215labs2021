using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    class Characteristics
    {
        private int _strentgh;
        private int _dexterity;
        private int _intelligence;
        private int _constitutions;

        private double _health;
        private int _manna;

        private double _pattack;
        private int _pdefence;

        private int _mattack;
        private int _mdefence;

        private int _criticalchanse;
        private int _criticaldamage;

        public Characteristics(int strentgh, int dexterity, int intelligence, int constitutions, int health, int manna, int pattack, int pdefence, int mattack, int mdefence, int criticalchanse, int criticaldamage)
        {
            Strentgh = strentgh;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Constitutions = constitutions;
            Health = health;
            _manna = manna;
            _pattack = pattack;
            _pdefence = pdefence;
            _mattack = mattack;
            _mdefence = mdefence;
            _criticalchanse = criticalchanse;
            _criticaldamage = criticaldamage;
        }
        public int Strentgh
        {
            get
            {
                return _strentgh;
            }
            set
            {
                _strentgh = value;
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
                _dexterity = value;
            }
        }
        public int Intelligence
        {
            get
            {
                return _dexterity;
            }
            set
            {
                _dexterity = value;
            }
        }
        public int Constitutions
        {
            get
            {
                return _constitutions;
            }
            set
            {
                _constitutions = value;
            }
        }
        public double Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = 2 * Constitutions + 0.5 * Strentgh;
            }
        }
        public int Manna
        {
            get
            {
                return _manna;
            }
            set
            {
                _manna = Intelligence * 3;
            }
        }
        public double Pattack
        {
            get
            {
                return _pattack;
            }
            set
            {
                _pattack = Strentgh * 3 + 0.5 * Dexterity;
            }
        }
        public double 
    }
}
