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

        private double _pcriticalchanse;
        private double _pcriticaldamage;
        private double _mcriticalchanse;
        private double _mcriticaldamage;

        
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
                return _intelligence;
            }
            set
            {
                _intelligence = value;
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
                _health = value;
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
                _manna = value;
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
                _pattack = value;
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
                _pdefence = value;
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
                _mattack = value;
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
                _mdefence = value;
            }
        }
        public double PCriticalchanse
        {
            get
            {
                return _pcriticalchanse;
            }
            set
            {
                _pcriticalchanse = value;
            }
        }
        public double PCriticaldamage
        {
            get
            {
                return _pcriticaldamage;
            }
            set
            {
                _pcriticaldamage = value;
            }
        }
        public double MCriticalchanse
        {
            get
            {
                return _mcriticalchanse;
            }
            set
            {
                _mcriticalchanse = value;
            }
        }
        public double MCriticaldamage
        {
            get
            {
                return _pcriticaldamage;
            }
            set
            {
                _pcriticaldamage = value;
            }
        }
    }
}
