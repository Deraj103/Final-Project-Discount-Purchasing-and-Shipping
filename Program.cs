﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Final Console Project Discount Purchasing and Shipping by Jared Tims\n");

            ArrayList marketingArray = new ArrayList();
            marketingArray.Add(new Marketing("P123", "coffee mug", 12.29m, 100, 20, 10, 5, 50, 30, 15, 10));
            marketingArray.Add(new Marketing("P987", "magnet, large", 3.29m, 100, 20, 10, 5, 50, 30, 15, 10));
            marketingArray.Add(new Marketing("P547", "stuffed bear", 11.99m, 30, 12, 8, 3, 20, 10, 5, 10));
            marketingArray.Add(new Marketing("P879", "note cube", 2.50m, 100, 20, 10, 5, 150, 100, 50, 10));
            ArrayList shippingArray = new ArrayList();
            shippingArray.Add(new Shipping("S678", "Miami FL", 2000, 10, 50, 35, 20, 1000, 500, 100, 35m, 11.5f, 8.5f, 4f, 5.2f));
            shippingArray.Add(new Shipping("S449", "Chicago IL", 800, 25, 50, 35, 20, 1000, 500, 100, 35m, 5f, 5f, 5f, 12.3f));
            shippingArray.Add(new Shipping("S721", "Denver CO", 150, 30, 50, 35, 20, 1000, 500, 100, 35m, 6.5f, 6.5f, 3f, 2.5f));
            shippingArray.Add(new Shipping("S678", "SLC UT", 30, 50, 50, 35, 20, 1000, 500, 100, 35m, 14f, 8f, 1f, 1.5f));

            WriteLine("Part A: Purchasing Products\n");
            for (int i = 0; i < marketingArray.Count; i++)
            {
                // instantiates the Marketing class object to enable access to methods and variables within
                Marketing temp = (Marketing)marketingArray[i];
                WriteLine($"{temp.ToString()}");
                temp.discountMethod();
                if (i + 1 == marketingArray.Count)
                {
                    temp.summaryMethod();
                }
            }
            WriteLine("Part B: Shipping\n");
            for (int i = 0; i < shippingArray.Count; i++)
            {
                // instantiates the Marketing class object to enable access to methods and variables within
                Shipping temp = (Shipping)shippingArray[i];
                WriteLine($"{temp.ToString()}");
                temp.discountMethod();
                if (i + 1 == shippingArray.Count)
                {
                    temp.summaryMethod();
                }
            }
            WriteLine("Press any key to continue...");
            ReadKey();
        }
    }
}
