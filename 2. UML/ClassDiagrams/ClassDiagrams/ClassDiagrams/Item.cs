using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams
{
    class Item
    {
        string description;
        double shippingWeight;

        public Item()
        {
            description = "Item description";
            shippingWeight = 10.00;
        }
        public void getPriceForQuantity()
        {

        }

        public void getTax()
        {

        }

        public Boolean InStock()
        {
            return true;
        }
    }
}
