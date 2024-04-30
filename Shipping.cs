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
        int flatRate;
        //contructor
        public Shipping(string id, string name, decimal price, int quantity, int tier1, int tier2, 
            int tier3, int volume1, int volume2, int volume3, int distance)
            : base (id, name, price, quantity, tier1, tier2, tier3, volume1, volume2, volume3)
        {
            this.flatRate = distance;
        }
        // interface methods
        public void martketingDiscount()
        {

        }
        public void shippingDiscount()
        {
            decimal volumeDiscount;
            decimal appliedDiscount;
            decimal noDiscount = getQuantity() * getPrice();
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
            //cartDiscount = noDiscount * 0.1;
            //WriteLine($"Whole cart discount: {cartDiscount:C}");
            //cartDiscount = noDiscount - cartDiscount;
            //WriteLine($"Cost after cart discount: {cartDiscount:C}\n");
        }
    }
}
