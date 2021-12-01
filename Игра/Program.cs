using System;
using Игра;


namespace Игра
{
    class Program
    {
        static void Start()
        {
           
            Client client = new Client();
            while (true)
            {
                client.Popolnenue(client.BallansDollars, client.BallansRubles);
                Console.WriteLine(client.BallansDollars);
                Console.WriteLine(client.BallansRubles);

            }
        }
        static void Main()
        {
            Start();
        }
    }
}



