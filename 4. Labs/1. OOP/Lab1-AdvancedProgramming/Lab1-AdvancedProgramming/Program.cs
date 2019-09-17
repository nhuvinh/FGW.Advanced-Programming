using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_AdvancedProgramming
{
    class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id;
        public decimal Balance;

        public BankAccount()
        {

        }

        public BankAccount(int id)
        {
            Id = id;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Can't deposite Negative amount");
            } 
            else Balance = Balance + amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Can't withdraw");
            } else if (amount < 0)
            {
                Console.WriteLine("Can't withdraw negative amount");
            }
            else Balance = Balance - amount;
        }

        public override string ToString()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Balance: {0}", Balance);
            return base.ToString();
        }

        public void Print(int id)
        {

        }
    }
    class Program
    {
        List<BankAccount> accounts;
        public Program()
        {
            accounts = new List<BankAccount>();
        }

        public void ShowMenu()
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Print");
            Console.WriteLine("5. End");
            Console.WriteLine("=== END ===");


        }

        public bool IsIdExists(int id)
        {

            return accounts.Exists(x => x.Id == id);
        }

        public void AddBankAccount(int id)
        {
            accounts.Add(new BankAccount(id));
        }
        static void Main(string[] args)
        {
            //BankAccount acc = new BankAccount();

            //acc.Id = 1;
            //acc.Balance = 15;
            //acc.ToString();
            //Console.WriteLine("=========");
            //acc.Deposit(10);
            //acc.ToString();
            //Console.WriteLine("=========");
            //acc.Deposit(-100);
            //Console.WriteLine("=========");
            //acc.Withdraw(10);
            //acc.ToString();
            //acc.Withdraw(-500);

            Program myProgram = new Program();
            myProgram.ShowMenu();

            Console.Write("Enter your command: ");
            int chooseMenu = Convert.ToInt32(Console.ReadLine());
            int chooseId;
            int chooseAmount;
            Console.WriteLine("Command: {0}", chooseMenu);
            while (chooseMenu != 5)
            {
                if (chooseMenu > 5 || chooseMenu < 0)
                {
                    Console.WriteLine("Invalid command");
                    
                }
                else
                {
                    switch (chooseMenu)
                    {
                        case 1:
                            Console.WriteLine("Please enter ID:");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            if (myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account already exists...");
                            }
                            else
                            {
                                Console.WriteLine("Account created successfully...");

                                myProgram.AddBankAccount(chooseId);
                            }
                            break;
                        case 2:
                            Console.Write("Please enter ID: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Please enter amount: ");
                            chooseAmount = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).Deposit(chooseAmount);
                                Console.WriteLine("After deposit");
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;
                        case 3:
                            Console.Write("Please enter ID: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Please enter amount: ");
                            chooseAmount = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).Withdraw(chooseAmount);
                                Console.WriteLine("After withdraw");
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;
                        case 4:
                            Console.Write("Please enter ID: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;
                        case 5: break;
                        default:
                            break;
                    }
                    if (chooseMenu == 5) break;
                }
                Console.Write("Enter your command: ");
                chooseMenu = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("END PROGRAM");


            Console.Read();
            


        }
    }
}
