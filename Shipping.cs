using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    internal class Shipping : Item
    {
        static decimal totalZoneRateCost;
        static decimal totalFlatRateCost;
        decimal zoneRate;
        decimal zoneRateShipCost;
        decimal flatRate;
        float d1, d2, d3, weight;
        //contructor
        // price = miles, quantity = boxes
        public Shipping(string id, string stateName, decimal miles, int boxQuantity, int tier1, int tier2,
            int tier3, int rate1, int rate2, int rate3, decimal flatRate, float d1, float d2, float d3, float weight)
            : base(id, stateName, miles, boxQuantity, tier1, tier2, tier3, rate1, rate2, rate3)
        {
            this.flatRate = flatRate;
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
            this.weight = weight;
        }
        // ToString method
        public override string ToString()
        {
            return $"{base.ToString()} {getQuantity()} boxes, distance {getPrice()} miles";
        }
        // interface methods
        public override void discountMethod()
        {
            WriteLine($"Size: {d1} x {d2} x {d3}, weight: {weight}");
            WriteLine("Zone Rates:");
            WriteLine($"\t{rates[0]} mi at {tiers[0]:C}, {rates[1]} mi at {tiers[1]:C}, " +
                      $"{rates[2]} mi at {tiers[2]:C}");
            // tier calculation
            // price = miles, quantity = boxes
            if (getPrice() > rates[0])
            {
                zoneRate = tiers[0];
                zoneRateShipCost = zoneRate * getQuantity();
                flatRate = getQuantity() * flatRate;
                WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneRateShipCost:C}");
                WriteLine($"Flat rate cost: {flatRate:C}\n");
            }
            // price = miles, quantity = boxes
            else if (getPrice() > rates[1])
            {
                zoneRate = tiers[1];
                zoneRateShipCost = zoneRate * getQuantity();
                flatRate = getQuantity() * flatRate;
                WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneRateShipCost:C}");
                WriteLine($"Flat rate cost: {flatRate:C}\n");
            }
            // price = miles, quantity = boxes
            else if (getPrice() > rates[2])
            {
                zoneRate = tiers[2];
                zoneRateShipCost = zoneRate * getQuantity();
                flatRate = getQuantity() * flatRate;
                WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneRateShipCost:C}");
                WriteLine($"Flat rate cost: {flatRate:C}\n");
            }
            else // if distance < 100 mi = $10/box
            {
                zoneRate = 10;
                zoneRateShipCost = zoneRate * getQuantity();
                flatRate = getQuantity() * flatRate;
                WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneRateShipCost:C}");
                WriteLine($"Flat rate cost: {flatRate:C}\n");
            }
            // calculations for summary report
            totalZoneRateCost = totalZoneRateCost + zoneRateShipCost;
            totalFlatRateCost = totalFlatRateCost + flatRate;
        }
        // whole cart discount
        public override void summaryMethod()
        {
            WriteLine("Part B Summary:");
            WriteLine($"Zone Shipping Costs: {totalZoneRateCost:C}");
            WriteLine($"     Flat Rate Cost: {totalFlatRateCost:C}\n");
        }
    }
}
