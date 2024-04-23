using System;
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

            WriteLine("First Part: Purchasing Products");

            // marketing tier information array
            int[,] marketingTiers =
            { // cart discount is 10%. Cart discount is defined as everything within the cart will receive a 10% discount
                { 20, 10, 5 }, // average products
                { 12, 8, 3 }, // expensive products
                { 20, 10, 5 } // cheap products
            };
            // zone shipping tier information array
            int[] shippingTiers = new int[4]{ /*distance > */ 1000, /*distance > */ 500, /*distance > */ 100, /*distance <*/ 100 };
            // flat rate distance is $35/box for any distance



            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}
