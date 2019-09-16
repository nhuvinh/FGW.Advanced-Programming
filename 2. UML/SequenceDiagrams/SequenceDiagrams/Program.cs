using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceDiagrams
{

    public class Customer
    {
        public string Name;
        public int Age;
        public CreditCard CreditCard;
        public int Cash;

        public Customer (string name, int age, int money)
        {
            Name = name;
            Age = age;
            CreditCard = new CreditCard(money);
            Cash = 0;
        }

        public Boolean WithDraw(int withDrawMoney, ATM atm)
        {
            if (CreditCard.WithDraw(withDrawMoney, atm))
            {
                Console.WriteLine(Name + " withdraw: " + withDrawMoney + " : SUCESS");
                Cash = Cash + withDrawMoney;
                return true;
            }
            else
            {
                Console.WriteLine(Name + " withdraw: " + withDrawMoney + " : FAIL");
                return false;
            }
        }
    } 

    public class CreditCard
    {
        public int Money;
        
        public CreditCard (int money)
        {
            Money = money;
        }

        public Boolean WithDraw(int withDrawMoney, ATM atm)
        {
            
            if(withDrawMoney > Money)
            {
                return false;
            }
            else if (!atm.IsEnoughMoney(withDrawMoney))
            {
                return false;
            }
            else
            {
                Money = Money - withDrawMoney;
                atm.WithDraw(withDrawMoney);
                return true;
            }
        }
    }

    public class ATM
    {
        public int Money;
        public ATM (int money)
        {
            Money = money;
        }

        public Boolean IsEnoughMoney(int withDrawMoney)
        {
            return withDrawMoney <= Money;
        }

        public Boolean WithDraw(int withDrawMoney)
        {
            Money = Money - withDrawMoney;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ATM testATM = new ATM(1000);
            Customer testCustomer = new Customer("Vinh Hoang", 30, 3000);
            testCustomer.WithDraw(5000, testATM);
            Console.ReadKey();
        }
    }
}
