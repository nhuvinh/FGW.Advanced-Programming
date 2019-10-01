using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSequence
{
    class Program
    {
        class Customer {

            public Customer()
            {

            }
            public void InsertCard(Card card, ATM atm)
            {
                atm.RequestPIN();
                int PIN = EnterPIN();

                if (!atm.VerifyPIN(PIN, card)) { 
                    Console.WriteLine("PIN Not Accepted ...");
                } else
                {
                    Console.WriteLine("PIN Accepted ...");
                    Console.WriteLine("Please choose options");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                }
                
            }

            public void SelectOption(int option)
            {
                // To be implemented
            }

            int EnterPIN()
            {
                int PIN = Convert.ToInt32(Console.ReadLine());
                return PIN;
            }
        }

        class ATM {

            public ATM()
            {

            }
            public void RequestPIN()
            {
                Console.WriteLine("Please Enter Your PIN");
                
            }

            public bool VerifyPIN (int pin, Card card)
            {


                return pin == card.GetAccount().GetPIN();
            }
        }

        class Account {
            int PIN;
            public Account(int pin)
            {
                PIN = pin;
            }
            public int GetPIN()
            {
                return PIN;
            }
        }

        class CheckAccount { }

        class Card {

            Account Account;
            public Card()
            {
                Account = new Account(1234);
            }


            public Account GetAccount()
            {
                return Account;
            }
        }
        static void Main(string[] args)
        {
            Card myCard = new Card();
            ATM myATM = new ATM();
            Customer myCustomer = new Customer();

            myCustomer.InsertCard(myCard, myATM);

            Console.ReadKey();
        }
    }
}
