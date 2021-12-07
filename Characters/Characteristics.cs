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
        private double _pdefence;

        private int _mattack;
        private int _mdefence;

        private double _criticalchanse;
        private double _criticaldamage;

        
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
        public double Pdefence
        {
            get
            {
                return _pdefence;
            }
            set
            {
                _pdefence = Constitutions * 0.5 + Dexterity * 3;
            }
        }
        public int Mattack
        {
            get
            {
                return _mattack;
            }
            set
            {
                _mattack = 4 * Intelligence;
            }
        }
        public int Mdefence
        {
            get
            {
                return _mdefence;
            }
            set
            {
                _mdefence = Intelligence * 2;
            }
        }
        public double Criticalchanse
        {
            get
            {
                return _criticalchanse;
            }
            set
            {
                _criticalchanse = 20 + Dexterity * 0.3;
            }
        }
        public double Criticaldamage
        {
            get
            {
                return _criticaldamage;
            }
            set
            {
                _criticaldamage = 100 + Dexterity * 0.5;
            }
        }
    }
}
