using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            int counter = 0;

            WriteLine("Final Console Project Discount Purchasing and Shipping by Jared Tims\n");

            ArrayList marketingArray = new ArrayList();
            marketingArray.Add(new Marketing("P123", "coffee mug", 12.29m, 100, 20, 10, 5, 50, 30, 15, 10));
            marketingArray.Add(new Marketing("P987", "magnet, large", 3.29m, 100, 20, 10, 5, 50, 30, 15, 10));
            marketingArray.Add(new Marketing("P547", "stuffed bear", 11.99m, 30, 12, 8, 3, 20, 10, 5, 10));
            marketingArray.Add(new Marketing("P879", "note cube", 2.50m, 100, 20, 10, 5, 150, 100, 50, 10));
            ArrayList shippingArray = new ArrayList();
            shippingArray.Add(new Shipping("S678", "Miami FL", 2000, 10, 50, 35, 20, 1000, 500, 100, 35));
            shippingArray.Add(new Shipping("S449", "Chicago IL", 800, 25, 50, 35, 20, 1000, 500, 100, 35));
            shippingArray.Add(new Shipping("S721", "Denver CO", 150, 30, 50, 35, 20, 1000, 500, 100, 35));
            shippingArray.Add(new Shipping("S678", "SLC UT", 30, 50, 50, 35, 20, 1000, 500, 100, 35));


            // instantiates the Marketing and Shipping class object to enable access to methods and variables within
            Marketing temp1 = (Marketing)marketingArray[counter];
            Shipping shippingItem = (Shipping)shippingArray[counter];

            WriteLine("Part A: Purchasing Products\n");
            //for (int i = 0; i < 1; i++)
            //{

            foreach (Item item in marketingArray)
            {
                // instantiates the Marketing class object to enable access to methods and variables within
                Marketing temp2 = (Marketing)marketingArray[counter];
                WriteLine($"{item.ToString()}");
                WriteLine("Discount options:");
                WriteLine($"\t{item.getVolume1()} at {item.getTier1():N} %, {item.getVolume2()} at {item.getTier2():N} %, " +
                          $"{item.getVolume3()} at {item.getTier3():N} %");
                temp2.marketingDiscount();
                counter++;
            }
            temp1.shippingDiscount();
            //}

            WriteLine("Part B: Shipping");

            WriteLine("Press any key to continue...");
            ReadKey();
        }
    }
}
