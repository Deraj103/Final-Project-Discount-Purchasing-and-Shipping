using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Final_Project_Discount_Purchasing_and_Shipping
{
    public abstract class Item : ICostInterface
    {
        string id, name;
        decimal price;
        int quantity;
        public int[] tiers = new int[3];
        public int[] rates = new int[3];

        public Item(string id, string name, decimal price, int quantity, int tier1, int tier2, 
            int tier3, int rate1, int rate2, int rate3)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            tiers[0] = tier1;
            tiers[1] = tier2;
            tiers[2] = tier3;
            rates[0] = rate1;
            rates[1] = rate2;
            rates[2] = rate3;
        }
        public int getQuantity() { return quantity; }
        public string getName() { return name; }
        public decimal getPrice() { return price; }
        // ToString method
        public override string ToString()
        {
            return $"{id} {name}:";
        }
        // interface methods
        public abstract void discountMethod();
        public abstract void summaryMethod();
    }
}
