﻿using System;
using Bank;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<iClient> accounts = new List<iClient>();
            accounts.Add(new Info("Альфред", 2000, 100, 0, 0, 0));
            accounts.Add(new Info("Илья", 10000, 300, 1, 0, 0));
            accounts.Add(new Info("Александр", 15000, 750, 2, 0, 0));
            int id = 0;
            int newid = 3;
            Info.startbank(accounts,id,newid);
            
        }
        public static void boba()
        {
            List<Info> accounts = new List<Info>();
            accounts.Add(new Info("Альфред", 2000, 100, 195234, 0, 0));
            accounts.Add(new Info("Илья", 10000, 300, 300592, 0, 0));
            accounts.Add(new Info("Александр", 15000, 750, 666777, 0, 0));
            foreach(var item in accounts)
            {
                Console.WriteLine($"Id: {item.Id} Имя: {item.Name} Баланс (Руб.) = {item.RubBalance} р. Баланс (Долл.) =  {item.UsdBalance} $");
            }
            for (int i = 0;i < accounts.Count; i++)
            {
                i = int.Parse(Console.ReadLine());
                Console.WriteLine($"{accounts[i].Name} {accounts[i].Id}");
            }
            Console.WriteLine(accounts[0].Id);
        }
    }
}