using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams
{
    class Order
    {
        DateTime date;
        string status;
        List<OrderDetail> orderDetails;
        List<Payment> payments;

        public Order(DateTime d, string stt)
        {
            date = d;
            status = stt;
            orderDetails = new List<OrderDetail>();
            payments = new List<Payment>();
        }

        public void AddOrderDetail(int quantity, Item item)
        {
            orderDetails.Add(new OrderDetail(quantity, item));
        }

        public void AddPayment(Payment payment)
        {
            payments.Add(payment);
        }
        
    }
}
