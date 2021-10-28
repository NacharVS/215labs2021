using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class UnitInfo
    {
        private string _name;
        private string _role;
        private string _action;
        private int _speed;
        private int _currentHealth;
        private int _maxhealth;
        private int _mindamage;
        private int _maxdamage;
        private int _attackSpeed;
        private int _number;
        private int _amountofArrows;
        private int _healammount;
        private int _manna;
        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                _name = value;
            }
        }
        public string Role
        {
            get
            {
                return _role;

            }
            set
            {
                _role = value;
            }
        }
        public string Action
        {
            get
            {
                return _action;

            }
            set
            {
                _action = value;
            }
        }
        public int Speed
        {
            get
            {
                return _speed;

            }
            set
            {
                _speed = value;
            }
        }
        public int CurrentHealth
        {
            get
            {
                return _currentHealth;

            }
            set
            {
                _currentHealth = value;
            }
        }
        public int Maxhealth
        {
            get
            {
                return _maxhealth;

            }
            set
            {
                _maxhealth = value;
            }
        }
        public int Mindamage
        {
            get
            {
                return _mindamage;

            }
            set
            {
                _mindamage = value;
            }
        }
        public int Maxdamage
        {
            get
            {
                return _maxdamage;

            }
            set
            {
                _maxdamage = value;
            }
        }
        public int AttackSpeed
        {
            get
            {
                return _attackSpeed;

            }
            set
            {
                _attackSpeed = value;
            }
        }
        public int Number
        {
            get
            {
                return _number;

            }
            set
            {
                _number = value;
            }
        }
        public int AmountofArrows
        {
            get
            {
                return _amountofArrows;

            }
            set
            {
                _amountofArrows = value;
            }
        }
        public int Healammount
        {
            get
            {
                return _healammount;

            }
            set
            {
                _healammount = value;
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
        protected void infounit()
        {
            Console.WriteLine();
            Console.WriteLine($"{_number} Gaming NPC - {_name}; his role - {_role};");
            Console.WriteLine($"His specifications:");
            Console.WriteLine($"movements speed - {_speed}");
            Console.WriteLine($"attack speed - {_attackSpeed}");
            Console.WriteLine($"current health - {_currentHealth}");
            Console.WriteLine($"minimum damage - {_mindamage}");
            Console.WriteLine($"maximum damage - {_maxdamage}");
            if (_amountofArrows == 0)
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine($"ammount of arrows - {_amountofArrows}");
            }
        }
        protected void unitaction()
        {
            Console.Write($"{_number} {_name} - {_action}");
            Console.WriteLine();
        }
        protected void unitattack()
        {
            int attackdamage = new Random().Next(_mindamage, _maxdamage);
            Console.WriteLine($"{_number} {_name} attacking with {attackdamage} damage");
        }
        protected void unitattackprocces()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                int healthdamage = new Random().Next(40,180);
                int attackdamage = new Random().Next(_mindamage,_maxdamage);
                Console.WriteLine($"{_number} {_name} attacking with {attackdamage} damage; his current health = {_currentHealth}");
                _currentHealth = _currentHealth - healthdamage;
                Console.WriteLine($"{_name} Loses {healthdamage} health units; his current health = {_currentHealth};");
                if (_currentHealth <= 0)
                {
                  Console.WriteLine();
                  Console.WriteLine($"{_name} died due to loss of health while fighting in battle");
                  break;
                }
                if (_currentHealth > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{_name} did not die in battle;his current health = {_currentHealth}");
                    break;
                }
            }
        }
        protected void unitlive()
        {
            if (_currentHealth > 0)
            {
                Console.WriteLine($"{_number} {_name} is alive with current health = {_currentHealth}");
            }
            else
            {
                Console.Write("");
            }
        }
        protected void archerattackprocces()
        {
            Console.WriteLine();
            Console.WriteLine($"{_name} attacks with arrows in ranged combat; his current health = {_currentHealth}");
            for (int i = 0; i < 100; i++)
            {
                int healthdamage = new Random().Next(1, 20);
                int arrowsnumber = new Random().Next(1, 4);
                _currentHealth = _currentHealth - healthdamage;
                _amountofArrows = _amountofArrows - arrowsnumber;
                if (_amountofArrows > 0 )
                {
                    Console.WriteLine($"{_name} lost {arrowsnumber} arrows and lost {healthdamage} health; his current health = {_currentHealth}; current arrows - {_amountofArrows}");
                }
                if (_amountofArrows <= 0)
                {
                    Console.WriteLine($"{_name}  lost all the arrows and went into melee with {_currentHealth} health");
                    break;
                }
            }
            for (int i = 0; i < 3;i++)
            {
                int meleedamage = new Random().Next(_mindamage, _maxdamage);
                int healthdamage1 = new Random().Next(10, 40);
                _currentHealth = _currentHealth - healthdamage1;
                if (_currentHealth > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{_name} attacking with {meleedamage} damage;{_name} loses {healthdamage1} health units; his current health = {_currentHealth}");
                    
                }
                if (_currentHealth < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{_name} died due to loss of health while fighting in melee battle");
                    break;
                }
            }
            if (_currentHealth > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{_name} survived the melee his current health = {_currentHealth}");
            }
            else
            {
                Console.Write("");
            }
        }
        protected void unithealth()
        {
            if (_currentHealth <= 0)
            {
                _currentHealth = 0;
                Console.WriteLine($"{_number} {_name} is dead; max health is {_maxhealth}");
            }
            else if (_currentHealth > 0)
            {
                Console.WriteLine($"{_number} {_name} is alive with current health = {_currentHealth}; max health is {_maxhealth}");
            }
        }
        protected void healtunitdone()
        {
            if (_currentHealth == _maxhealth)
            {
                Console.WriteLine($"{_number} {_name} current health {_currentHealth} = max health");
            }
            else if (_currentHealth == 0)
            {
                Console.WriteLine($"{_number} {_name} current health {_currentHealth} died");
            }
            else
            {
                Console.WriteLine($"{_number} {_name} current health {_currentHealth} - alive;");
            }
        }
        protected void magicianattack()
        {
            Console.WriteLine();
            Console.WriteLine($"{_number} {_name} will use a spell;amount of mana = {_manna}; {_name} have 3 spells:");
            Console.WriteLine($"1 - The Magic Arrow; ranged combat; damage in the range from 70 to 120");
            Console.WriteLine($"2 - The Magic Shield; melee combat; damage in the range from 10 to 45");
            Console.WriteLine($"3 - The Magic Staff; melee combat; damage in the range from 50 to 95");
            while (_manna > 0)
            {
                Console.WriteLine("Enter the spell number to use it");

                int spell1damage = new Random().Next(70, 120);
                int spell2damage = new Random().Next(10, 45);
                int spell3damage = new Random().Next(50, 95);
                int spell1healthdamage = new Random().Next(10, 30);
                int spell2healthdamage = new Random().Next(10, 25);
                int spell3healthdamage = new Random().Next(20, 50);
                int spell1manna = 75;
                int spell2manna = 50;
                int spell3manna = 90;
                int speelnumber = int.Parse(Console.ReadLine());
                switch (speelnumber)
                {
                    case 1:
                        Console.WriteLine($"{_name} uses 1 spell; damage done = {spell1damage}; lost manna = {spell1manna} ");
                        _manna = _manna - spell1manna;
                        _currentHealth = _currentHealth - spell1healthdamage;
                        Console.WriteLine($"{_name} has {_currentHealth} health; current manna amount = {_manna}");
                        if (_manna <= 0)
                        {
                            Console.WriteLine($"{_name} lost all manna; his current health = {_currentHealth}");
                        }
                        break;
                    case 2:
                        Console.WriteLine($"{_name} uses 2 spell; damage done = {spell2damage}; lost manna = {spell2manna} ");
                        _manna = _manna - spell2manna;
                        _currentHealth = _currentHealth - spell2healthdamage;
                        Console.WriteLine($"{_name} has {_currentHealth} health; current manna amount = {_manna}");
                        if (_manna <= 0)
                        {
                            Console.WriteLine($"{_name} lost all manna; his current health = {_currentHealth}");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"{_name} uses 3 spell; damage done = {spell3damage}; lost manna = {spell3manna} ");
                        _manna = _manna - spell3manna;
                        _currentHealth = _currentHealth - spell3healthdamage;
                        Console.WriteLine($"{_name} has {_currentHealth} health; current manna amount = {_manna}");
                        if (_manna <= 0)
                        {
                            Console.WriteLine($"{_name} lost all manna; his current health = {_currentHealth}");
                        }
                        break;
                }
            }
            if (_currentHealth > 0)
            {
                Console.WriteLine($"{_number} {_name} survived in battle; his current health = {_currentHealth} ");
            }
            else if (_currentHealth < 0)
            {
                Console.WriteLine($"{_number} {_name} died in battle;");
            }
            else
            {
                Console.WriteLine();
            }
                    

        }
        
    }
}
