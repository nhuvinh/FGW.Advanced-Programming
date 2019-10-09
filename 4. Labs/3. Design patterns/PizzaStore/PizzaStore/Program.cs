namespace PizzaStore
{
    using System;

    /// <summary>
    /// Defines the <see cref="Order" />
    /// </summary>
    internal class Order
    {
        /// <summary>
        /// Defines the DrinkItem
        /// </summary>
        internal Drink DrinkItem;

        /// <summary>
        /// Defines the FranchiseItem
        /// </summary>
        internal Franchise FranchiseItem;

        /// <summary>
        /// Defines the PizzaItem
        /// </summary>
        internal Pizza PizzaItem;

        /// <summary>
        /// Defines the ToppingItem
        /// </summary>
        internal Topping ToppingItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="drink">The drink<see cref="Drink"/></param>
        /// <param name="franchise">The franchise<see cref="Franchise"/></param>
        /// <param name="pizza">The pizza<see cref="Pizza"/></param>
        public Order(Drink drink, Franchise franchise, Pizza pizza, Topping topping)
        {
            DrinkItem = drink;
            FranchiseItem = franchise;
            PizzaItem = pizza;
            ToppingItem = topping;
        }

        /// <summary>
        /// The GetPrice
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPrice()
        {
            return DrinkItem.GetPrice() + FranchiseItem.GetPrice() + PizzaItem.GetPrice() + ToppingItem.GetPrice();
        }
    }

    /// <summary>
    /// Defines the <see cref="Drink" />
    /// </summary>
    internal abstract class Drink
    {
        /// <summary>
        /// Defines the Price
        /// </summary>
        protected double Price;

        /// <summary>
        /// The GetPrice
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPrice()
        {
            return Price;
        }
    }

    /// <summary>
    /// Defines the <see cref="Water" />
    /// </summary>
    internal class Water : Drink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Water"/> class.
        /// </summary>
        public Water()
        {
            Price = 1.29;
        }
    }

    /// <summary>
    /// Defines the <see cref="Wine" />
    /// </summary>
    internal class Wine : Drink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wine"/> class.
        /// </summary>
        public Wine()
        {
            Price = 7.49;
        }
    }

    /// <summary>
    /// Defines the <see cref="Lemonade" />
    /// </summary>
    internal class Lemonade : Drink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lemonade"/> class.
        /// </summary>
        public Lemonade()
        {
            Price = 1.29;
        }
    }

    /// <summary>
    /// Defines the <see cref="Franchise" />
    /// </summary>
    internal abstract class Franchise
    {
        /// <summary>
        /// Defines the Price
        /// </summary>
        protected double Price;

        /// <summary>
        /// The GetPrice
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public double GetPrice()
        {
            return Price;
        }
    }

    /// <summary>
    /// Defines the <see cref="Shirt" />
    /// </summary>
    internal class Shirt : Franchise
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shirt"/> class.
        /// </summary>
        public Shirt()
        {
            Price = 21.99;
        }
    }

    /// <summary>
    /// Defines the <see cref="Mug" />
    /// </summary>
    internal class Mug : Franchise
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mug"/> class.
        /// </summary>
        public Mug()
        {
            Price = 4.99;
        }
    }

    /// <summary>
    /// Defines the <see cref="Pizza" />
    /// </summary>
    internal abstract class Pizza
    {
        /// <summary>
        /// Defines the Price
        /// </summary>
        protected double Price;

        /// <summary>
        /// Defines the FamilySize
        /// </summary>
        protected bool FamilySize = false;

        /// <summary>
        /// The GetPrice
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public virtual double GetPrice()
        {
            return FamilySize ? Price + 4.15 : Price;
        }

        /// <summary>
        /// The SetPrice
        /// </summary>
        /// <param name="price">The price<see cref="double"/></param>
        public void SetPrice(double price)
        {
            Price = price;
        }

        /// <summary>
        /// The SetFamilySize
        /// </summary>
        public void SetFamilySize()
        {
            FamilySize = true;
        }
    }

    /// <summary>
    /// Defines the <see cref="MagueritaPizza" />
    /// </summary>
    internal class MagueritaPizza : Pizza
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagueritaPizza"/> class.
        /// </summary>
        public MagueritaPizza()
        {
            Price = 4.99;
        }
    }

    /// <summary>
    /// Defines the <see cref="SalamiPizza" />
    /// </summary>
    internal class SalamiPizza : Pizza
    {
        /// <summary>
        /// Defines the mPizza
        /// </summary>
        private Pizza mPizza;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalamiPizza"/> class.
        /// </summary>
        /// <param name="pizza">The pizza<see cref="Pizza"/></param>
        public SalamiPizza(Pizza pizza)
        {
            mPizza = pizza;
            mPizza.SetPrice(5.99);
        }

        /// <summary>
        /// The GetPrice
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public override double GetPrice()
        {
            return mPizza.GetPrice();
        }
    }

    /// <summary>
    /// Defines the <see cref="HawaiiPizza" />
    /// </summary>
    internal class HawaiiPizza : Pizza
    {
        /// <summary>
        /// Defines the mPizza
        /// </summary>
        private Pizza mPizza;

        /// <summary>
        /// Initializes a new instance of the <see cref="HawaiiPizza"/> class.
        /// </summary>
        /// <param name="pizza">The pizza<see cref="Pizza"/></param>
        public HawaiiPizza(Pizza pizza)
        {
            mPizza = pizza;
            mPizza.SetPrice(5.99);
        }

        /// <summary>
        /// The GetPrice
        /// </summary>
        /// <returns>The <see cref="double"/></returns>
        public override double GetPrice()
        {
            return mPizza.GetPrice();
        }
    }

    /// <summary>
    /// Defines the <see cref="Topping" />
    /// </summary>
    internal abstract class Topping
    {
        protected double Price;
        public double GetPrice()
        {
            return Price;
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
            Price = 1.49;
        }

    }

    /// <summary>
    /// Defines the <see cref="Program" />
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Main
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/></param>
        internal static void Main(string[] args)
        {
            var myWater = new Water();
            var myShirt = new Shirt();

            var myPizza = new MagueritaPizza();
            Console.WriteLine("Price of myPizza: {0}", myPizza.GetPrice());
            myPizza.SetFamilySize();

            var mySalamiPizza = new SalamiPizza(myPizza);
            Console.WriteLine("Price of mySalamiPizza: {0}", mySalamiPizza.GetPrice());

            var myOrder = new Order(myWater, myShirt, mySalamiPizza, new Cheese());
            Console.WriteLine("Price of my order: {0}", myOrder.GetPrice());

            Console.ReadKey();
        }
    }
}
