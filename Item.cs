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
        int quantity;

        public Item(string id, string name, decimal price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        // getter
        public int getQuantity() { return quantity; }
        // ToString method
        public override string ToString()
        {
            return $"{id} {name}: cost {price:C} quantity {quantity}";
        }
    }
}
