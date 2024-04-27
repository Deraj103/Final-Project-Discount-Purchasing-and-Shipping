using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    interface ICostInterface
    {
        // interface methods - both can be used between the two classes of Marketing and Shipping.
        // the marketing method will determine the discounts (tier or whole cart) and subtract that from the cost.
        void marketingDiscount();
        // the shipping method will determine the cost to ship in the zone method or the flat rate method.
        void shippingDiscount();
    }
}
