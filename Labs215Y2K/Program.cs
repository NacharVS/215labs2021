using System;

namespace Labs215Y2K
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                string Vvod = Console.ReadLine();
                
                if (Vvod == "Sgrt")
                {
                    Cycle.Cycles.Sgrt();
                }
                if (Vvod == "revers")
                {
                    Cycle.Cycles.Reversenubmer();

                }
                if (Vvod == "HackDoor")
                {
                    Cycle.Cycles.HackDoor();
                }
                if (Vvod == "clear")
                {
                    Console.Clear();

                }
                if(Vvod == "ОдинаковыеЦифры") 
                {
                    Cycle.Cycles.ReversoNumber();

                }
            }
        }
       
    }
}
    
    
 