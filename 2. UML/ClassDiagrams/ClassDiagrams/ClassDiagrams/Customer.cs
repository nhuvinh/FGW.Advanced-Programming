using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams
{
    class Customer
    {
        string name;
        string address;
        List<Order> orders;

        public Customer(string n, string add)
        {
            name = n;
            address = add;
            orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }
    }
}
