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
    internal class Marketing : Item
    {
        decimal cartDiscount;
        decimal cartDiscountRate;
        static decimal totalCartDiscount;
        static decimal straightCost;
        static decimal totalVolumeDiscount;
        decimal volumeDiscount;
        decimal afterAppliedDiscount;
        // constructor
        public Marketing(string id, string name, decimal price, int quantity, int tier1, int tier2, int tier3,
            int rate1, int rate2, int rate3, decimal cartDiscount)
            : base(id, name, price, quantity, tier1, tier2, tier3, rate1, rate2, rate3)
        {
            this.cartDiscount = cartDiscount;
        }
        // ToString method
        public override string ToString()
        {
            return $"{base.ToString()} cost {getPrice():C}, quantity {getQuantity()}";
        }
        // interface methods
        public override void discountMethod()
        {
            decimal noDiscount = getQuantity() * getPrice();
            WriteLine("Discount options:");
            WriteLine($"\t{rates[0]} at {tiers[0]:N} %, {rates[1]} at {tiers[1]:N} %, " +
                      $"{rates[2]} at {tiers[2]:N} %");
            WriteLine($"Cost with no discount: {noDiscount:C}");
            // tier calculation
            if (getQuantity() > rates[0])
            {
                volumeDiscount = (decimal)tiers[0] / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                cartDiscountRate = noDiscount * 0.1m;
                cartDiscount = noDiscount - cartDiscountRate;
                WriteLine($"Volume rate: {tiers[0]:N} %, discount: {volumeDiscount:C}");
                afterAppliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {afterAppliedDiscount:C}");
                // calculations for summary report
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + afterAppliedDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;

            }
            else if (getQuantity() > rates[1])
            {
                volumeDiscount = (decimal)tiers[1] / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                cartDiscountRate = noDiscount * 0.1m;
                cartDiscount = noDiscount - cartDiscountRate;
                WriteLine($"Volume rate: {tiers[1]:N} %, discount: {volumeDiscount:C}");
                afterAppliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {afterAppliedDiscount:C}");
                // calculations for summary report
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + afterAppliedDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;
            }
            else if (getQuantity() > rates[2])
            {
                volumeDiscount = (decimal)tiers[2] / 100;
                volumeDiscount = volumeDiscount * noDiscount;
                cartDiscountRate = noDiscount * 0.1m;
                cartDiscount = noDiscount - cartDiscountRate;
                WriteLine($"Volume rate: {tiers[2]:N} %, discount: {volumeDiscount:C}");
                afterAppliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {afterAppliedDiscount:C}");
                // calculations for summary report
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + afterAppliedDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;
            }
            else // if volume < 15(coffee mugs/magnets) or 5(toys) or 50(note cubes) no discount
            {
                volumeDiscount = noDiscount;
                cartDiscountRate = noDiscount * 0.1m;
                cartDiscount = noDiscount - cartDiscountRate;
                WriteLine($"Volume rate: {0:N} %, discount: {0:C}");
                afterAppliedDiscount = noDiscount - volumeDiscount;
                WriteLine($"Cost after Volume discount: {afterAppliedDiscount:C}");
                // calculations for summary report
                straightCost = straightCost + noDiscount;
                totalVolumeDiscount = totalVolumeDiscount + afterAppliedDiscount;
                totalCartDiscount = totalCartDiscount + cartDiscount;
            }
            WriteLine($"Whole cart discount: {cartDiscountRate:C}");
            WriteLine($"Cost after cart discount: {cartDiscount:C}\n");
        }
        // whole cart discount
        public override void summaryMethod()
        {
            WriteLine("Part A Summary:");
            WriteLine($"   Straight Cost: {straightCost:C}");
            WriteLine($"Volume Discounts: {totalVolumeDiscount:C}");
            WriteLine($"   Cart Discount: {totalCartDiscount:C}\n");
        }
    }
}
