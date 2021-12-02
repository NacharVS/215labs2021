using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class program
    {
        public static void Main()
        {
        
            Account acc1 = new Account("Ivan", 5000 , new Random().Next(1234, 9876));
            Account acc2 = new Account("Fedor", 6000, new Random().Next(1234, 9876));
            Account acc3 = new Account("Elena", 3000, new Random().Next(1234, 9876));
            acc1.ShowInfo(acc1);
            acc2.ShowInfo(acc2);
            acc3.ShowInfo(acc3);
            Console.WriteLine();
            Account.rate = 0.06;
            Console.WriteLine();
            Console.WriteLine("Введите количество месяцев");
            int mouth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Через {mouth} меся(ц/ца/цев) Ваш баланс с коэффицентом {Account.rate} будет составлять:");
            acc1.ShowProfit(acc1, mouth);
            acc2.ShowProfit(acc2, mouth);
            acc3.ShowProfit(acc3, mouth);
            acc1.ShowInfo(acc1);
            acc2.ShowInfo(acc2);
            acc3.ShowInfo(acc3);
            acc1.Deposit(acc1);

        }
    }
}





    
                                                                                                                                                                                                                                                                                                                                                                                                                                                
                                                                      
                 
     
     
     
     
     
     
                                                                                                                                                                                          
                   
     
     
     

      

     
     
     
     
     
     
     
     
     

      
      

      

     
     
     
     
     
     
     
     
     
     
     

     
                                                                                                                                                                                                                                                                                                                                                                                                                                         
     
     
     
     
     
     

     
     
     

     
      
     
     
      
     
     
     

      
     
     
        

     
     
     
     
      
      

     
     

     
     
     
     

     
      
     
     
     
       
     
     

     
     
     
     
     

     
     
     
     
     
     

     
     
     
     

     

     
     