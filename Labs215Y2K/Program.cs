﻿using Labs215Y2K.Bank;
using Labs215Y2K.MongoExamples;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labs215Y2K
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Extensions.EditDocument("Ivan", new Person("Ivan", 99, "9687698476"));
        }

        static void Show(double a, double b)
        {
            Console.WriteLine($"balancr changed with {a}, new balance ={b}");
        }
    }
}
