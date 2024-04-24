using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    internal class Shipping : Item, ICostInterface
    {
        int distance;
        //contructor
        public Shipping(string id, string name, decimal price, int quantity, int distance)
            : base (id, name, price, quantity)
        {
            this.distance = distance;
        }
        // interface methods
        public string marketingDiscount(int row)
        {
            return "test";
        }
        public void shippingDiscount()
        {

        }
    }
}
