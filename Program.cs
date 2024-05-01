using System;
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
            int counter = 0;

            WriteLine("Final Console Project Discount Purchasing and Shipping by Jared Tims\n");

            ArrayList marketingArray = new ArrayList();
            marketingArray.Add(new Marketing("P123", "coffee mug", 12.29m, 100, 20, 10, 5, 50, 30, 15, 10));
            marketingArray.Add(new Marketing("P987", "magnet, large", 3.29m, 100, 20, 10, 5, 50, 30, 15, 10));
            marketingArray.Add(new Marketing("P547", "stuffed bear", 11.99m, 30, 12, 8, 3, 20, 10, 5, 10));
            marketingArray.Add(new Marketing("P879", "note cube", 2.50m, 100, 20, 10, 5, 150, 100, 50, 10));
            ArrayList shippingArray = new ArrayList();
            shippingArray.Add(new Shipping("S678", "Miami FL", 2000, 10, 50, 35, 20, 1000, 500, 100, 35m));
            shippingArray.Add(new Shipping("S449", "Chicago IL", 800, 25, 50, 35, 20, 1000, 500, 100, 35m));
            shippingArray.Add(new Shipping("S721", "Denver CO", 150, 30, 50, 35, 20, 1000, 500, 100, 35m));
            shippingArray.Add(new Shipping("S678", "SLC UT", 30, 50, 50, 35, 20, 1000, 500, 100, 35m));

            WriteLine("Part A: Purchasing Products\n");
            foreach (Item item in marketingArray)
            {
                // instantiates the Marketing class object to enable access to methods and variables within
                Marketing temp = (Marketing)marketingArray[counter];
                WriteLine($"{item.ToString()}");
                temp.discountMethod();
                counter++;
                if (counter == marketingArray.Count)
                {
                    temp.summaryMethod();
                }
            }
            // reset counter
            counter = 0;
            WriteLine("Part B: Shipping\n");
            foreach (Item item in shippingArray)
            {
                // instantiates the Marketing class object to enable access to methods and variables within
                Shipping temp = (Shipping)shippingArray[counter];
                WriteLine($"{item.ToString()}");
                if (item.getName() == "Miami FL")
                {
                    WriteLine("Size: 11.5 x 8.5 x 4, weight: 5.2");
                }
                else if (item.getName() == "Chicago IL")
                {
                    WriteLine("Size: 5 x 5 x 5, weight: 12.3");
                }
                else if (item.getName() == "Denver CO")
                {
                    WriteLine("Size: 6.5 x 6.5 x 3, weight: 2.5");
                }
                else
                {
                    WriteLine("Size: 14 x 8 x 1, weight: 1.5");
                }
                temp.discountMethod();
                counter++;
                if (counter == shippingArray.Count)
                {
                    temp.summaryMethod();
                }
            }

            WriteLine("Press any key to continue...");
            ReadKey();
        }
    }
}
