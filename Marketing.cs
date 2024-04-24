using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    internal class Marketing : Item, ICostInterface
    {
        decimal discount;
        // constructor
        public Marketing(string id, string name, decimal price, int quantity, decimal discount)
            : base (id, name, price, quantity)
        {
            this.discount = discount;
        }
        // interface methods
        public string marketingDiscount(int row)
        {
            //return $"\t50 at {marketingTiers[row,0]:N}%, 30 at {marketingTiers[row, 1]:N}%, 15 at {marketingTiers[row, 2]:N}%";
            return "test";
        }
        public void shippingDiscount()
        {
            
        }
    }
}
