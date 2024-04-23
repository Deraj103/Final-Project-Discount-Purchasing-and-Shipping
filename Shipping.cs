using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    internal class Shipping : Item
    {
        int distance;
        //contructor
        public Shipping(string id, string name, double price, int quantity, int distance)
            : base (id, name, price, quantity)
        {
            this.distance = distance;
        }
    }
}
