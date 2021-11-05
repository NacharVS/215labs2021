using System;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Product prod1 = new Product(55.59, 100, "Banana");
            prod1.Nds = 10;
            Console.WriteLine(prod1.Nds);



        }
    }
}
