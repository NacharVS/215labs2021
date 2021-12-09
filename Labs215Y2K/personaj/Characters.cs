using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Characters
    {
        public delegate void HealthValueChangeDelagate(int health, int Oldhealth);
        public event HealthValueChangeDelagate HealthChangeEvent;
        private string _name;
        private int _strenght;
        private int _dexterity;
        private int _intelgence;
        private int _consitution;
        private int _health;
        private int _mana;
        private int _pattack;
        private int _pdefense;
        private int _mattack;
        private int _mdefense;
        private int _pcchanse;
        private int _pcdamage;
        private int _mcchanse;
        private int _mcdamage;

       

        public  Characters(string name, int strenght, int dexterity, int intelgence, int consitution, int health, int mana, int pattack, int pdefense, int mattack, int mdefense, int pcchanse, int pcdamage, int mcchanse, int mcdamage)
        {
            _name = name;
            _strenght = strenght;
            _dexterity = dexterity;
            _intelgence = intelgence;
            _consitution = consitution;
            _health = health;
            _mana = mana;
            _pattack = pattack;
            _pdefense = pdefense;
            _mattack = mattack;
            _mdefense = mdefense;
            _pcchanse = pcchanse;
            _pcdamage = pcdamage;
            _mcchanse = mcchanse;
            _mcdamage = mcdamage;
        }

        public string Name { get => _name; set => _name = value; }
        public int Strenght { get => _strenght; set => _strenght = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public int Intelgence { get => _intelgence; set => _intelgence = value; }
        public int Consitution { get => _consitution; set => _consitution = value; }
        public int Health
        {
            get => _health; 
            set
            {
                int oldhealth = _health;
                _health = value;
                HealthChangeEvent?.Invoke(_health, oldhealth);



            }
                

        }
        public int Mana { get => _mana; set => _mana = value; }
        public int Pattack { get => _pattack; set => _pattack = value; }
        public int Pdefense { get => _pdefense; set => _pdefense = value; }
        public int Mattack { get => _mattack; set => _mattack = value; }
        public int Mdefense { get => _mdefense; set => _mdefense = value; }
        public int Pcchanse { get => _pcchanse; set => _pcchanse = value; }
        public int Pcdamage { get => _pcdamage; set => _pcdamage = value; }
        public int Mcchanse { get => _mcchanse; set => _mcchanse = value; }
        public int Mcdamage { get => _mcdamage; set => _mcdamage = value; }
        
    }
   
}
