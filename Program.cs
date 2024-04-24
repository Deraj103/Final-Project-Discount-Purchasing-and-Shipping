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

            Marketing[] itemArray = new Marketing[4];
            itemArray[0] = new Marketing("P123", "coffee mug", 12.29m, 100, 0);
            itemArray[1] = new Marketing("P987", "magnet, large", 3.29m, 100, 0);
            itemArray[2] = new Marketing("P547", "stuffed bear", 11.99m, 30, 0);
            itemArray[3] = new Marketing("P879", "note cube", 2.50m, 100, 0);

            // marketing tier information array
            int[,] marketingTiers =
            { // cart discount is 10%. Cart discount is defined as everything within the cart will receive a 10% discount
                { 20, 10, 5 }, // average products
                { 12, 8, 3 }, // expensive products
                { 20, 10, 5 } // cheap products
            };
            // zone shipping tier information array
            int[] shippingTiers = new int[4] { /*distance > */ 1000, /*distance > */ 500, /*distance > */ 100, /*distance <*/ 100 };
            // flat rate distance is $35/box for any distance

            WriteLine("First Part: Purchasing Products");

            foreach (Marketing item in itemArray)
            {
                int column = 0;
                WriteLine($"{item.ToString()}");
                WriteLine("Discount options:");
                //itemArray[row].marketingDiscount(row);
                WriteLine($"\t{Item.getQuantity()} at {marketingTiers[column, 0]:N}%, 30 at {marketingTiers[column, 1]:N}%, 15 at {marketingTiers[column, 2]:N}%");
                column++;
            }

            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}
