using System;
using Игра;
 


namespace Игра
{
    class Program
    {
        static void Show( string a, string B)
        {
            Console.WriteLine($"{a},{B}");
            
        }
        static void Main()
        {
            Client client = new Client();
            client.NameEvent += Show;
            client.Name = " Борис ";
        }
    }
}



