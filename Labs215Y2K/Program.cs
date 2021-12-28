using System;
using System.Collections.Generic;
using System.Text;

namespace Labs215Y2K
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] priceproducts = new int[10] { 30, 8, 40, 250, 50, 70, 36, 13, 75, 150 };
            //int[] productschoose = new int[10];
            //int[,] integersarray = new int[10, 10];
            //int[] integersarray2 = new int[10];
            //int[,] newidarray = new int[10, 10];
            //int sum = 0;
            //int a = 0;
            ////Start.StartProgramm();
            List<UsedAuto> listautos = new List<UsedAuto>();
            listautos.Add(new UsedAuto("Lada", "2106", 1.5, 2010, 25000));
            listautos.Add(new UsedAuto("Lada", "2109", 1.7, 2013, 29000));
            listautos.Add(new UsedAuto("Lada", "2103", 1, 2007, 10000));
            List<NewAuto> listauto = new List<NewAuto>();
            listauto.Add(new NewAuto("Lada", "Vesta", 2, 2018, 800000));
            listauto.Add(new NewAuto("Mercedes", "G-63", 4.0, 2021, 20400000));
            listauto.Add(new NewAuto("BMW", "M-4", 4.0, 2021, 15000000));
            NewAuto.Start(listautos, listauto);

        }
    }
            //Arrays14oc.arraygeneration(integersarray,sum,a,integersarray2);
            //Arrays14oc.arraygeneration(integersarray, sum, a, integersarray2, newidarray);
            //Arrays14oc.arraygeneration(integersarray, sum, a, integersarray2, newidarray);
            
            
        
    
}
