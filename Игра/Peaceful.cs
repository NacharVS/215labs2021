using System;
using System.Collections.Generic;
using System.Text;


namespace Игра
{
    class Peaceful
    {

        private string _name;
        private string _profecia;
        private int _max_hp = 50;
        private int _new_hp ;
        private int _speed; 
        private int _damage;

        public string Change_Name
        { 
            get => _name;
            set => _name = value;
        }
        public string Change_Profecia
        {
            get => _profecia; 
            set => _profecia = value; 
        }
        public int Change_New_hp
        { 
           get => _new_hp;
           set 
           {
                if (value > 0)
                    _new_hp = value;
                else
                    Death_Unit();
           } 
        }

        public int Change_Damage
        { 
            get => _damage; 
            set => _damage = value; 
        }

        public void GetDamage(int damage) 
        {
            Change_New_hp = Change_New_hp - damage;
        }
        public int SetDamage()
        {
            return _damage;
        }
        public void Moving()
        {
            Console.WriteLine($"{_name}is moving");
        }
        public void Death_Unit()
        {
            Console.WriteLine($"{_name}is death");
        }
    }
  
  
} 

    
