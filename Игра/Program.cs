using System;
using Игра;



namespace Игра
{
    class Program
    {
        static void Main()
        {
            Peaceful p1 = new Peaceful(); 
            Peaceful p2 = new Peaceful();
            p1.Change_Name = "Валера";
            p1.Change_New_hp = 100;
            p2.Change_Name = "Данил";
            p2.Change_New_hp = 100;
            p1.Change_Damage = 20; 
            p2.Change_Damage = 20;

            for (int i = 0; i < 5; i++)
            {
                Action.Figth(p1, p2);
                Console.WriteLine(p1.Change_New_hp);
                Console.WriteLine(p2.Change_New_hp);
            }
            
        }
    }
    
}
