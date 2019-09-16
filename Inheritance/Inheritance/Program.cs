using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Rectangle
    {
        //member variables
        public double length;
        public double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle  
    class Tabletop : Rectangle
    {
        private double cost;
        public Tabletop(double l, double w ) : base(l, w) {
            
        }

        public Tabletop() : base (0.0, 0.0)
        {
            cost = 0.0;
        }

        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }
        public void Display()
        {
            base.Display();
            // Console.WriteLine("Length is : {0}", length);
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle(10, 20);
            // myRectangle.Display();

            //  Console.WriteLine("Length of my Rectangle: {0}", myRectangle.length);
            // Console.WriteLine("Area of myRectangle: {0}", myRectangle.GetArea());

            Tabletop t = new Tabletop(4.5, 7.5);
            t.Display();
            Console.ReadLine();
        }
    }
}
