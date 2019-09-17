using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();

        void SendMoney(string customerID, string bankDestination, int amount);

        
    }

    public class ATMTransaction : ITransactions
    {
        public void showTransaction()
        {
            Console.WriteLine("ATM Transaction");
        }

        public void SendMoney(string customerID, string bankDestination, int amount)
        {
            // Liên ngân hàng
        }

        public void SendMoney(string customerID, int amount)
        {
            // Chuyển nội bộ
        }

        public double getAmount()
        {
            return 0;
        }
    }

    public class TPBankTransaction : Transaction
    {
        private double balance;
        public void showTransaction()
        {
            Console.WriteLine("Welcome to TPBank");
            Console.WriteLine("Thank you for using our services");

        }

        public void setAmount(double bal)
        {
            balance = bal;
        }

        public double getAmount()
        {
            return 0;
        }

        public void SendMoney(string customerName, string bankDestination, int amount)
        {

        }
    }

    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }
        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }

        public void SendMoney(string customerName, string bankDestination, int amount)
        {

        }
    }
    class Tester
    {

        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }
    }
}
