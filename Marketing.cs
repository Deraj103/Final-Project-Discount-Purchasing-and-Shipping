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
        decimal cartDiscount;
        // constructor
        public Marketing(string id, string name, decimal price, int quantity, int tier1, int tier2, int tier3, 
            int volume1, int volume2, int volume3, int cartDiscount)
            : base (id, name, price, quantity, tier1, tier2, tier3, volume1, volume2, volume3)
        {
            this.cartDiscount = cartDiscount;
        }
        // interface methods
        public void marketingDiscount()
        {
            decimal totalCost = getQuantity() * getPrice();
            //decimal discountCalc = marketingDiscountArray[0, 0] / 100;
            //totalCost = totalCost * discountCalc;
            //if (quantity > 50)
            //{
            //    int discount = MarketingDiscount[0,0];
            //}
            //return totalCost;
        }
        public void shippingDiscount()
        {
            
        }
    }
}
