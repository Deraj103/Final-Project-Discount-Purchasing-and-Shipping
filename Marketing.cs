using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    internal class Marketing : Item
    {
        decimal discount;
        // constructor
        public Marketing(string id, string name, double price, int quantity, decimal discount)
            : base (id, name, price, quantity)
        {
            this.discount = discount;
        }
        // interface methods
        public override void marketingDiscount()
        {

        }
        public override void shippingDiscount()
        {
            
        }

    }
}
