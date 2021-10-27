using System;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Peasant p1 = new Peasant();
            Peasant p2 = new Peasant();
            p1.Name = "Valera"; p2.Name = "Danila";
            p1.MinDamage = 15;
            p1.MaxDamage = 20;
            p2.MinDamage = 15;
            p2.MaxDamage = 20;
            p1.Health = 50;
            p2.Health = 50;
            Actions.Fight(p1, p2);
            Actions.Fight(p1, p2);
            Actions.Fight(p1, p2);

        }       
    }
}
