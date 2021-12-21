using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Charactergame
    {

        private double _strentgh;
        private double _dexterity;
        private double _intelligence;
        private double _constitutions;

        private double _health;
        private double _manna;

        private double _pattack;
        private double _pdefence;

        private double _mattack;
        private double _mdefence;

        private double _pcriticalchanse;
        private double _pcriticaldamage;
        private double _mcriticalchanse;
        private double _mcriticaldamage;
        private double _pdamage;
        private double _mdamage;


        public double Strentgh
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
        public double Dexterity
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
        public double Intelligence
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
        public double Constitutions
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
                return 2 * Constitutions + 0.5 * Strentgh;
            }
            set
            {
                _health = value;
            }
        }
        public double Manna
        {
            get
            {
                return 3 * Intelligence;
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
                return Strentgh * 3 + 0.5 * Dexterity;
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
                return Constitutions * 0.5 + Dexterity * 3;
            }
            set
            {
                _pdefence = value;
            }
        }
        public double Mattack
        {
            get
            {
                return Intelligence * 4;
            }
            set
            {
                _mattack = value;
            }
        }
        public double Mdefence
        {
            get
            {
                return Intelligence * 2;
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
                return 20 + Dexterity * 0.3;
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
                return Pdamage * (2 + Dexterity * 0.05);
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
                return 20 + Intelligence * 0.3;
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
                return Mdamage * (2 + Intelligence * 0.15);
            }
            set
            {
                _mcriticaldamage = value;
            }
        }
        public double Pdamage
        {
            get
            {
                return Pattack * (Pattack / Pdefence);
            }
            set
            {
                _pdamage = value;
            }
        }
        public double Mdamage
        {
            get
            {
                return Mattack * (Mattack / Mdefence);
            }
            set
            {
                _mdamage = value;
            }
        }

    }
}
