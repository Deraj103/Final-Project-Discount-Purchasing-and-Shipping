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
        decimal cartDiscount = 0;
        decimal wholeCartDiscount = 0;
        decimal totalCartDiscount = 0;
        decimal straightCost = 0;
        decimal totalVolumeDiscount = 0;
        // constructor
        public Marketing(string id, string name, decimal price, int quantity, int tier1, int tier2, int tier3,
            int volume1, int volume2, int volume3, decimal cartDiscount)
            : base(id, name, price, quantity, tier1, tier2, tier3, volume1, volume2, volume3)
        {
            this.cartDiscount = cartDiscount;
        }
        // getters
        public decimal GetTotalCartDiscount() { return totalCartDiscount; }
        public decimal GetTotalVolumeDiscount() { return totalVolumeDiscount; }
        public decimal GetStrightCostCost() { return straightCost; }
        // interface methods
        public void marketingDiscount()
        {
            decimal volumeDiscount;
            decimal appliedDiscount;
            decimal noDiscount = getQuantity() * getPrice();
            WriteLine($"Cost with no discount: {noDiscount:C}");
            // tier calculation
            if (getQuantity() > getVolume1())
            {
                volumeDiscount = (decimal)getTier1() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                wholeCartDiscount = noDiscount * 0.1m;
                cartDiscount = noDiscount - wholeCartDiscount;
                WriteLine($"Volume rate: {getTier1():N} %, discount: {volumeDiscount:C}");
                appliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {appliedDiscount:C}");
                // calculations for summary report
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + volumeDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;

            }
            else if (getQuantity() > getVolume2())
            {
                volumeDiscount = (decimal)getTier2() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                wholeCartDiscount = noDiscount * 0.1m;
                cartDiscount = noDiscount - wholeCartDiscount;
                WriteLine($"Volume rate: {getTier2():N} %, discount: {volumeDiscount:C}");
                appliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {appliedDiscount:C}");
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + volumeDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;
            }
            else if (getQuantity() > getVolume3())
            {
                volumeDiscount = (decimal)getTier3() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                wholeCartDiscount = noDiscount * 0.1m;
                cartDiscount = noDiscount - wholeCartDiscount;
                WriteLine($"Volume rate: {getTier3():N} %, discount: {volumeDiscount:C}");
                appliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {appliedDiscount:C}");
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + volumeDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;
            }
            else
            {
                WriteLine("Not enough volume was purchased. No discount.");
            }
            WriteLine($"Whole cart discount: {wholeCartDiscount:C}");
            WriteLine($"Cost after cart discount: {cartDiscount:C}\n");
        }
        // whole cart discount
        public void shippingDiscount()
        {
            WriteLine("Part A Summary:");
            WriteLine($"Straight Cost: {straightCost:C}");
            WriteLine($"Volume Discount: {totalVolumeDiscount:C}");
            WriteLine($"Cart Discount: {totalCartDiscount:C}\n");
        }
    }
}
