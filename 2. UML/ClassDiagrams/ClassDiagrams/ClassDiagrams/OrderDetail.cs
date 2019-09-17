using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams
{
    class OrderDetail
    {
        int quantity;
        Item item;
        string taxStatus;

        public OrderDetail(int quan, Item i)
        {
            quantity = quan;
            item = i;
            taxStatus = "N/A";
        }
        public void calcSubTotal()
        {

        }

        public void calcWeight()
        {

        }

        public void calcTax()
        {

        }
    }
}
