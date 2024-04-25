using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Final Console Project Discount Purchasing and Shipping by Jared Tims\n");

            ArrayList itemArray = new ArrayList();
            itemArray.Add(new Marketing("P123", "coffee mug", 12.29m, 100, 20, 10, 5, 50, 30, 15, 10));
            itemArray.Add(new Marketing("P987", "magnet, large", 3.29m, 100, 20, 10, 5, 50, 30, 15, 10));
            itemArray.Add(new Marketing("P547", "stuffed bear", 11.99m, 30, 12, 8, 3, 20, 10, 5, 10));
            itemArray.Add(new Marketing("P879", "note cube", 2.50m, 100, 20, 10, 5, 150, 100, 50, 10));

            WriteLine("First Part: Purchasing Products");

            foreach (Marketing item in itemArray)
            {
                decimal discount = 0;
                WriteLine($"{item.ToString()}");
                WriteLine("Discount options:");
                if (item is Marketing)
                {
                    WriteLine($"\t{item.getVolume1()} at {item.getTier1():N}%, {item.getVolume2()} at {item.getTier2():N}%, " +
                        $"{item.getVolume3()} at {item.getTier3():N}%");
                    //string noDiscount = Item.discountMethod();
                    //WriteLine($"Cost with no discount: {item.discountMethod(marketingDiscountsArray):C}");
                    WriteLine($"{discount}");
                }
            }

            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}
