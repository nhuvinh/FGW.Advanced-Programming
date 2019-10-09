using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    class Order
    {
        Drink DrinkItem;
        Franchise FranchiseItem;
        Pizza PizzaItem;
        
        public Order(Drink drink, Franchise franchise, Pizza pizza)
        {
            DrinkItem = drink;
            FranchiseItem = franchise;
            PizzaItem = pizza;
        }

        public double GetPrice()
        {
            return DrinkItem.GetPrice() + FranchiseItem.GetPrice() + PizzaItem.GetPrice();
        }
    }


    abstract class Drink {
        protected double Price;

        public double GetPrice()
        {
            return Price;
        }
    }

    class Water : Drink {
        public Water()
        {
            Price = 1.29;
        }
    }

    class Wine : Drink {
        public Wine()
        {
            Price = 7.49;
        }
    }

    class Lemonade : Drink {
        public Lemonade()
        {
            Price = 1.29;
        }
    }

    abstract class Franchise {
        protected double Price;

        public double GetPrice()
        {
            return Price;
        }
    }

    class Shirt : Franchise {
        public Shirt()
        {
            Price = 21.99;
        }
    }

    class Mug : Franchise {
        public Mug()
        {
            Price = 4.99;
        }
    }

    abstract class Pizza
    {
        protected double Price;
        protected bool FamilySize = false;
        protected Topping Toppings;


        public virtual double GetPrice()
        {
            return FamilySize ? Price + 4.15 : Price;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }

        public void SetFamilySize()
        {
            FamilySize = true;
        }

        public void AddTopping(Topping topping)
        {
            Toppings = topping;
        }

        public abstract double GetToppingPrice();

    }



    class MagueritaPizza : Pizza
    {
        public MagueritaPizza()
        {
            Price = 4.99;
        }

        public override double GetToppingPrice()
        {
            return Toppings.GetPrice();
        }

    }

    class SalamiPizza : Pizza
    {
        private Pizza mPizza;

        public SalamiPizza(Pizza pizza)
        {
            mPizza = pizza;
            mPizza.SetPrice(5.99);
        }

        public override double GetPrice()
        {
            return mPizza.GetPrice() + mPizza.GetToppingPrice();
        }

        public override double GetToppingPrice()
        {
            return Toppings.GetPrice();
        }
    }

    class HawaiiPizza : Pizza
    {
        private Pizza mPizza;

        public HawaiiPizza(Pizza pizza)
        {
            mPizza = pizza;
            mPizza.SetPrice(5.99);
        }

        public override double GetPrice()
        {
            return mPizza.GetPrice();
        }

        public override double GetToppingPrice()
        {
            return Toppings.GetPrice();
        }
    }

    abstract class Topping
    {
        protected double Price;
        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price)
        {
            Price = price;
        }
    }

    class Ham : Topping
    {
        public Ham()
        {
            Price = 0.99;
        }
    }

    class Cheese : Topping
    {
        public Cheese()
        {
            Price = 0.69;
        }
    }

    class Salami : Topping
    {
        public Salami()
        {
            Price = 0.99;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myWater = new Water();
            var myShirt = new Shirt();
        
            var myPizza = new MagueritaPizza();
            Console.WriteLine("Price of myPizza: {0}", myPizza.GetPrice());
            myPizza.SetFamilySize();

            var mySalamiPizza = new SalamiPizza(myPizza);
            Console.WriteLine("Price of mySalamiPizza: {0}", mySalamiPizza.GetPrice());
            mySalamiPizza.AddTopping(new Cheese());
            var myOrder = new Order(myWater, myShirt, mySalamiPizza);
            Console.WriteLine("Price of my order: {0}", myOrder.GetPrice());

            Console.ReadKey();

        }
    }
}
