using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    internal class Marketing : Item, ICostInterface
    {
        decimal cartDiscount;
        decimal wholeCartDiscount;
        static decimal totalCartDiscount;
        static decimal straightCost;
        static decimal totalVolumeDiscount;
        decimal volumeDiscount;
        decimal afterAppliedDiscount;
        // constructor
        public Marketing(string id, string name, decimal price, int quantity, int tier1, int tier2, int tier3,
            int volume1, int volume2, int volume3, decimal cartDiscount)
            : base(id, name, price, quantity, tier1, tier2, tier3, volume1, volume2, volume3)
        {
            this.cartDiscount = cartDiscount;
        }
        // ToString method
        public override string ToString()
        {
            return $"{base.ToString()} cost {getPrice():C}, quantity {getQuantity()}";
        }
        // interface methods
        public void discountMethod()
        {
            decimal noDiscount = getQuantity() * getPrice();
            WriteLine("Discount options:");
            WriteLine($"\t{getVolume1()} at {getTier1():N} %, {getVolume2()} at {getTier2():N} %, " +
                      $"{getVolume3()} at {getTier3():N} %");
            WriteLine($"Cost with no discount: {noDiscount:C}");
            // tier calculation
            if (getQuantity() > getVolume1())
            {
                volumeDiscount = (decimal)getTier1() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                wholeCartDiscount = noDiscount * 0.1m;
                cartDiscount = noDiscount - wholeCartDiscount;
                WriteLine($"Volume rate: {getTier1():N} %, discount: {volumeDiscount:C}");
                afterAppliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {afterAppliedDiscount:C}");
                // calculations for summary report
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + afterAppliedDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;

            }
            else if (getQuantity() > getVolume2())
            {
                volumeDiscount = (decimal)getTier2() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                wholeCartDiscount = noDiscount * 0.1m;
                cartDiscount = noDiscount - wholeCartDiscount;
                WriteLine($"Volume rate: {getTier2():N} %, discount: {volumeDiscount:C}");
                afterAppliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {afterAppliedDiscount:C}");
                // calculations for summary report
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + afterAppliedDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;
            }
            else if (getQuantity() > getVolume3())
            {
                volumeDiscount = (decimal)getTier3() / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                wholeCartDiscount = noDiscount * 0.1m;
                cartDiscount = noDiscount - wholeCartDiscount;
                WriteLine($"Volume rate: {getTier3():N} %, discount: {volumeDiscount:C}");
                afterAppliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {afterAppliedDiscount:C}");
                // calculations for summary report
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + afterAppliedDiscount;
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
        public void summaryMethod()
        {
            WriteLine("Part A Summary:");
            WriteLine($"Straight Cost: {straightCost:C}");
            WriteLine($"Volume Discount: {totalVolumeDiscount:C}");
            WriteLine($"Cart Discount: {totalCartDiscount:C}\n");
        }
    }
}
