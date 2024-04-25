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
        public Shipping(string id, string name, decimal price, int quantity, int tier1, int tier2, 
            int tier3, int volume1, int volume2, int volume3, int distance)
            : base (id, name, price, quantity, tier1, tier2, tier3, volume1, volume2, volume3)
        {
            this.distance = distance;
        }
        // interface methods
        public decimal shippingDiscount(int discount)
        {
            return 2;
        }
        public void shippingDiscount()
        {

        }
    }
}
