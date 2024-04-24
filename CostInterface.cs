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
        // interface methods
        string marketingDiscount(int row);
        void shippingDiscount();
    }
}
