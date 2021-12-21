using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Unit
    {
        private string _class;
        private int _strength;
        private int _dextericy;
        private int _intelegent;
        private int _constitution;

        private static int _maxMana;
        private static int _maxHealth;
        private int _currentMana;
        private int _currentHealth;

        private int _P_Attack;
        private int _P_Defense;
        private int _M_Attack;
        private int _M_Defense;

        private int _P_CriticalChance;
        private int _M_CriticalChance;
        private int _P_CriticalDamage;
        private int _M_CriticalDamage;

        public string Class { get => _class; set => _class = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Dextericy { get => _dextericy; set => _dextericy = value; }
        public int Intelegent { get => _intelegent; set => _intelegent = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }


        
        public int MaxMana
        { 
            get => _maxMana;
            set => _maxMana = value;
        }
        public int MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }
        public int CurrentMana
        { 
            get => _currentMana;
            set => _currentMana = value;
        }
        public int CurrentHealth
        {
            get => _currentHealth;
            set => _currentHealth = value;
        }

        public int P_Attack { get => _P_Attack; set => _P_Attack = value; }
        public int P_Defense { get => _P_Defense; set => _P_Defense = value; }
        public int M_Attack { get => _M_Attack; set => _M_Attack = value; }
        public int M_Defense { get => _M_Defense; set => _M_Defense = value; }
        public int P_CriticalChance { get => _P_CriticalChance; set => _P_CriticalChance = value; }
        public int M_CriticalChance { get => _M_CriticalChance; set => _M_CriticalChance = value; }
        public int P_CriticalDamage { get => _P_CriticalDamage; set => _P_CriticalDamage = value; }
        public int M_CriticalDamage { get => _M_CriticalDamage; set => _M_CriticalDamage = value; }


        public static void Battle(int un1, int un2, List<Unit> characters)
        {
            int damage_a = characters[un1].P_Attack * (characters[un1].P_Attack / characters[un2].P_Defense);
            int crit_damage_a = characters[un1].P_CriticalDamage;
            int Mage_damage = characters[un1].M_Attack * (characters[un1].M_Attack / characters[un2].M_Defense);
            int Crit_Mage_damage = characters[un1].M_CriticalDamage;

            if (un1 == un2)
            {

            }
            else
            {
                Console.WriteLine($"{characters[un1].Class} наносит удар");

                if (characters[un1] is Mage)
                {
                    if(characters[un1].CurrentMana>0)
                    {
                        int a4 = new Random().Next(0, 100);
                        if (a4 < characters[un1].P_CriticalChance)
                        {
                            Console.WriteLine($"{characters[un1].Class}: Мана:{characters[un1].CurrentMana = characters[un1].CurrentMana - 40}/{characters[un1].MaxMana}");

                            Console.WriteLine($"{characters[un2].Class} получил {Crit_Mage_damage} единиц критического урона");
                            Console.WriteLine($"{characters[un2].Class}: Здоровье:{characters[un2].CurrentHealth = characters[un2].CurrentHealth - Crit_Mage_damage}/{characters[un2].MaxHealth}");
                        }
                        else
                        {
                            Console.WriteLine($"{characters[un1].Class}: Мана:{characters[un1].CurrentMana = characters[un1].CurrentMana - 20}");

                            Console.WriteLine($"{characters[un2].Class} получил {Mage_damage} единиц урона");
                            Console.WriteLine($"{characters[un2].Class}: Здоровье:{characters[un2].CurrentHealth = characters[un2].CurrentHealth - Mage_damage}/{characters[un2].MaxHealth}");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        int a4 = new Random().Next(0, 100);
                        if (a4 < characters[un1].P_CriticalChance)
                        {
                            Console.WriteLine($"{characters[un2].Class} получил {crit_damage_a} единиц критического урона");
                            Console.WriteLine($"{characters[un2].Class}: Здоровье:{characters[un2].CurrentHealth = characters[un2].CurrentHealth - crit_damage_a}/{characters[un2].MaxHealth}");
                        }
                        else
                        {
                            Console.WriteLine($"{characters[un2].Class} получил {damage_a} единиц урона");
                            Console.WriteLine($"{characters[un2].Class}: Здоровье:{characters[un2].CurrentHealth = characters[un2].CurrentHealth - damage_a}/{characters[un2].MaxHealth}");
                        }
                        Console.WriteLine();
                    }
                    
                }
                else
                {
                    int a4 = new Random().Next(0, 100);
                    if (a4 < characters[un1].P_CriticalChance)
                    {
                        Console.WriteLine($"{characters[un2].Class} получил {crit_damage_a} единиц критического урона");
                        Console.WriteLine($"{characters[un2].Class}: Здоровье:{characters[un2].CurrentHealth = characters[un2].CurrentHealth - crit_damage_a}/{characters[un2].MaxHealth}");
                    }
                    else
                    {
                        Console.WriteLine($"{characters[un2].Class} получил {damage_a} единиц урона");
                        Console.WriteLine($"{characters[un2].Class}: Здоровье:{characters[un2].CurrentHealth = characters[un2].CurrentHealth - damage_a}/{characters[un2].MaxHealth}");
                    }                   
                    Console.WriteLine();
                }
                if (characters[un2].CurrentHealth <= 0)
                {
                    
                    Console.WriteLine();
                    Console.WriteLine($"{characters[un2].Class} мертв.");
                    characters.Remove(characters[un2]);

                }
            }
        }
    }
}
