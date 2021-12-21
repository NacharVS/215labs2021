using System;
using System.Collections.Generic;

namespace New_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Work();
            Console.ReadKey(); 
            
        }

       

        public static void Work()
        {

            Unit dualunit = new Unit(0, 0, 0, 0, "");
            Warrior war = new Warrior(30, 15, 10, 85, "воин1");
            Warrior war2 = new Warrior(50, 35, 30, 45, "воин2");
            war.testevent += Unit.DeBuff;

            List<Unit> Chaptres = new List<Unit>();

            Chaptres.Add(war);
            Chaptres.Add(war2);
            for (int i = 0; i < Chaptres.Count; i++)
            {
                Chaptres[i].CurrencyHealth = Chaptres[i].MaxHealth;
                Chaptres[i].CurrencyMana = Chaptres[i].MaxMana;
                Console.WriteLine($"Магический Урон - {Chaptres[i].M_Attack} - Шанс магического крита. Урона-  {Chaptres[i].M_CritChance} % Крит. урон магический - {Chaptres[i].M_CritDamage}");
                Console.WriteLine($"Характеристика вашего персонажа: ХП- {Chaptres[i].CurrencyHealth} Мана- {Chaptres[i].CurrencyMana} Физ.Дамаг- {Chaptres[i].P_Attack} Физ.Защита - {Chaptres[i].P_Defense} Шанс Крита {Chaptres[i].P_CritChance} % Крит Урон - {Chaptres[i].P_CritDamage}");
                Console.WriteLine($"Маг.Защита - {Chaptres[i].M_Defense}");
                

                if (Chaptres[i] is Warrior)
                {
                    Console.WriteLine("Ваш персонаж - Воин. Берите меч и идите в бой");
                }
                if (Chaptres[i] is Mage)
                {
                    Console.WriteLine("Вы - МАГомед, сошедший с пути становления в Подземелье ЛЮБЛИНО, отправились в дальний путь");
                }
                if (Chaptres[i] is Archer)
                {
                    Console.WriteLine("Охотник, которому прострелили колено , открывает для себя дорогу авантюриста.");
                }
                Unit.PAttack(war, Chaptres);
                Chaptres[i].CurrencyHealth = Chaptres[i].MaxHealth = 120;
                Unit.PAttack(war, Chaptres);
                Console.WriteLine(war.P_Defense); 



            }
        
             
          
  
        }


    }
}
