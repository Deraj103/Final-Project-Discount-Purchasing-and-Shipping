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
            WriteLine("Final Console Project Discount Purchasing and Shipping by Jared Tims\n");

            ArrayList itemArray = new ArrayList();
            itemArray.Add(new Marketing("P123", "coffee mug", 12.29, 100, 20, 10, 5, 50, 30, 15, 10));
            itemArray.Add(new Marketing("P987", "magnet, large", 3.29, 100, 20, 10, 5, 50, 30, 15, 10));
            itemArray.Add(new Marketing("P547", "stuffed bear", 11.99, 30, 12, 8, 3, 20, 10, 5, 10));
            itemArray.Add(new Marketing("P879", "note cube", 2.50, 100, 20, 10, 5, 150, 100, 50, 10));
            itemArray.Add(new Shipping("S678", "Miami FL", 2000, 10, 50, 35, 20, 1000, 500, 100, 35));
            itemArray.Add(new Shipping("S449", "Chicago IL", 800, 25, 50, 35, 20, 1000, 500, 100, 35));
            itemArray.Add(new Shipping("S721", "Denver CO", 150, 30, 50, 35, 20, 1000, 500, 100, 35));
            itemArray.Add(new Shipping("S678", "SLC UT", 30, 50, 50, 35, 20, 1000, 500, 100, 35));

            WriteLine("Part A: Purchasing Products\n");

            foreach (Item item in itemArray)
            {
                WriteLine($"{item.ToString()}");
                WriteLine("Discount options:");
                if (item is Marketing)
                {
                    WriteLine($"\t{item.getVolume1()} at {item.getTier1():N} %, {item.getVolume2()} at {item.getTier2():N} %, " +
                        $"{item.getVolume3()} at {item.getTier3():N} %");
                    WriteLine(Marketing.marketingDiscount());
                }
                else if (item is Shipping)
                {

                }
            }

            WriteLine("Part B: Shipping");

            WriteLine("Press any key to continue...");
            ReadKey();
        }
    }
}
