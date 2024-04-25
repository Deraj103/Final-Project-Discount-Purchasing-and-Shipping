using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    public class Item
    {
        string id, name;
        decimal price;
        int quantity, tier1, tier2, tier3, volume1, volume2, volume3;

        public Item(string id, string name, decimal price, int quantity, int tier1, int tier2, 
            int tier3, int volume1, int volume2, int volume3)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.tier1 = tier1;
            this.tier2 = tier2;
            this.tier3 = tier3;
            this.volume1 = volume1;
            this.volume2 = volume2;
            this.volume3 = volume3;
        }
        // getter
        public int getQuantity() { return quantity; }
        public decimal getPrice() { return price; }
        public int getTier1() { return tier1; }
        public int getTier2() { return tier2; }
        public int getTier3() { return tier3; }
        public int getVolume1() { return volume1; }
        public int getVolume2() { return volume2; }
        public int getVolume3() { return volume3; }
        // ToString method
        public override string ToString()
        {
            return $"{id} {name}: cost {price:C} quantity {quantity}";
        }
    }
}
