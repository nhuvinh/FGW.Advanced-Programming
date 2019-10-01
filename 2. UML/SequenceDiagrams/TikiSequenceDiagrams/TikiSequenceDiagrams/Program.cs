using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikiSequenceDiagrams
{
    class StoreFront {
        public void AddItem(Item item, Cart cart)
        {
            cart.AddItem(item);
        }

        public bool Checkout(Cart cart, Inventory inventory)
        {
            cart.ProcessOrder(inventory);
            return true;
        }
    }

    class Cart {
        List<Item> CartItems;

        public void AddItem(Item item)
        {
            CartItems.Add(item);
        }

        public void ReserveItem(Inventory inventory)
        {
            inventory.ReserveItem(CartItems[CartItems.Count - 1]);
        }

        public void ProcessOrder(Inventory inventory)
        {
            foreach (var item in CartItems)
            {
                Console.WriteLine(item.ToString());
            }

            if (ConfirmOrder())
            {
                PlaceOrder(inventory);
            }

            else return;

        }

        public void PlaceOrder(Inventory inventory)
        {
            inventory.PlaceOrder(CartItems);
        }

        public bool ConfirmOrder()
        {
            return true;
        }
    }

    class Inventory
    {
        List<Item> InventoryItems;

        public bool ReserveItem(Item item)
        {
            

            if (InventoryItems.Find(r => r.ID == item.ID) != null)
            {
                InventoryItems.Find(r => r.ID == item.ID).Reserved();

                return true;
            }
            else return false;
        }

        public bool PlaceOrder(List<Item> items)
        {
            return true;
        }
    }

    class Item {
        public int ID;
        double price;
        bool IsReserved = false;

        public void Reserved()
        {
            IsReserved = true;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
