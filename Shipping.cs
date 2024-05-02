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
    internal class Shipping : Item, ICostInterface
    {
        static decimal totalZoneRateCost;
        static decimal totalFlatRateCost;
        decimal zoneRate;
        decimal zoneRateShipCost;
        decimal flatRate;
        //contructor
        // price = miles, quantity = boxes
        public Shipping(string id, string stateName, decimal miles, int boxQuantity, int tier1, int tier2, 
            int tier3, int volume1, int volume2, int volume3, decimal flatRate)
            : base (id, stateName, miles, boxQuantity, tier1, tier2, tier3, volume1, volume2, volume3)
        {
            this.flatRate = flatRate;
        }
        // ToString method
        public override string ToString()
        {
            return $"{base.ToString()} {getQuantity()} boxes, distance {getPrice()} miles";
        }
        // interface methods
        public void discountMethod()
        {
            WriteLine("Zone Rates:");
            WriteLine($"\t{getVolume1()} mi at {getTier1():C}, {getVolume2()} mi at {getTier2():C}, " +
                      $"{getVolume3()} mi at {getTier3():C}");
            // tier calculation
            // price = miles, quantity = boxes
            if (getPrice() > getVolume1())
            {
                zoneRate = getTier1();
                zoneRateShipCost = zoneRate * getQuantity();
                flatRate = getQuantity() * flatRate;
                WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneRateShipCost:C}");
                WriteLine($"Flat rate cost: {flatRate:C}\n");
                // calculations for summary report
                totalZoneRateCost = totalZoneRateCost + zoneRateShipCost;
                totalFlatRateCost = totalFlatRateCost + flatRate;

            }
            // price = miles, quantity = boxes
            else if (getPrice() > getVolume2())
            {
                zoneRate = getTier2();
                zoneRateShipCost = zoneRate * getQuantity();
                flatRate = getQuantity() * flatRate;
                WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneRateShipCost:C}");
                WriteLine($"Flat rate cost: {flatRate:C}\n");
                // calculations for summary report
                totalZoneRateCost = totalZoneRateCost + zoneRateShipCost;
                totalFlatRateCost = totalFlatRateCost + flatRate;
            }
            // price = miles, quantity = boxes
            else if (getPrice() > getVolume3())
            {
                zoneRate = getTier3();
                zoneRateShipCost = zoneRate * getQuantity();
                flatRate = getQuantity() * flatRate;
                WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneRateShipCost:C}");
                WriteLine($"Flat rate cost: {flatRate:C}\n");
                // calculations for summary report
                totalZoneRateCost = totalZoneRateCost + zoneRateShipCost;
                totalFlatRateCost = totalFlatRateCost + flatRate;
            }
            else // if distance < 100 mi = $10/box
            { 
                zoneRate = 10;
                zoneRateShipCost = zoneRate * getQuantity();
                flatRate = getQuantity() * flatRate;
                WriteLine($"Zone rate: {zoneRate:C}, ship cost: {zoneRateShipCost:C}");
                WriteLine($"Flat rate cost: {flatRate:C}\n");
                // calculations for summary report
                totalZoneRateCost = totalZoneRateCost + zoneRateShipCost;
                totalFlatRateCost = totalFlatRateCost + flatRate;
            }
        }
        // whole cart discount
        public void summaryMethod()
        {
            WriteLine("Part B Summary:");
            WriteLine($"Zone Shipping Costs: {totalZoneRateCost:C}");
            WriteLine($"     Flat Rate Cost: {totalFlatRateCost:C}\n");
        }
    }
}
