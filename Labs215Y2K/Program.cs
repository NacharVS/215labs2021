using System;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Peasant p1 = new Peasant("peasant1", 20, 10, 30);
            Console.WriteLine(p1.name);
            p1 = new Peasant("peasant1", 20, 10, 30);

        }       
    }
}
