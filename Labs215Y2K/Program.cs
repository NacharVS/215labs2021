using System;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Peasant p1 = new Peasant();
            Console.WriteLine(p1.Health);
            p1.Health = 20;
            Console.WriteLine(p1.Health);

        }       
    }
}
