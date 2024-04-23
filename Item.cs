using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    abstract class Item
    {
        string id, name;
        double price;
        int quantity;

        public Item(string id, string name, double price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        // interface methods-
        public abstract void marketingDiscount();
        public abstract void shippingDiscount();
    }
}
