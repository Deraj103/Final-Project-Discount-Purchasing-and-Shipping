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
        double cartDiscount;
        // constructor
        public Marketing(string id, string name, double price, int quantity, int tier1, int tier2, int tier3,
            int volume1, int volume2, int volume3, double cartDiscount)
            : base(id, name, price, quantity, tier1, tier2, tier3, volume1, volume2, volume3)
        {
            this.cartDiscount = cartDiscount;
        }
        // interface methods
        public void marketingDiscount()
        {
            double volumeDiscount;
            double appliedDiscount;
            double noDiscount = getQuantity() * getPrice();
            WriteLine($"Cost with no discount: {noDiscount:C}");
            // tier calculation
            if (getQuantity() > getVolume1())
            {
                volumeDiscount = getTier1() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                WriteLine($"Volume rate: {getTier1():N} %, discount: {volumeDiscount:C}");
                appliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {appliedDiscount:C}");
            }
            else if (getQuantity() < getVolume2())
            {
                volumeDiscount = getTier2() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                WriteLine($"Volume rate: {getTier2():N} %, discount: {volumeDiscount:C}");
                appliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {appliedDiscount:C}");
            }
            else if (getQuantity() > getVolume3())
            {
                volumeDiscount = getTier3() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                WriteLine($"Volume rate: {getTier3():N} %, discount: {volumeDiscount:C}");
                appliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {appliedDiscount:C}");
            }
            else
            {
                WriteLine("Not enough volume was purchased. No discount.");
            }
            // whole cart discount
            cartDiscount = noDiscount * 0.1;
            WriteLine($"Whole cart discount: {cartDiscount:C}");
            cartDiscount = noDiscount - cartDiscount;
            WriteLine($"Cost after cart discount: {cartDiscount:C}\n");
        }
        public void shippingDiscount()
        {

        }
    }
}
