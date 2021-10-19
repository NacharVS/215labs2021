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
            //StudentsInfo16.studentslist();
            Mover mover = new Mover("Косарь", "Мирный", "Косит траву", 40, 80, 0);
            Mover.MoverInfo(mover.name, mover.speed, mover.role, mover.health, mover.damage);
        } 
    }
}
