using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAccessModifier
{
    class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        private string color;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetLength()
        {
            return length;
        }

        private string GetColor()
        {
            return color;
        }

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("Color: {0}", GetColor());
        }
    }//end class Rectangle

    class Tabletop : Rectangle
    {
        public Tabletop (double l, double w) :base(l * 2, w *2) { 
        
                
        }

        public void DoubleLength()
            {
                length = length * 2;
            }


        //public void Display()
        //{
        //    base.Display();
        //    Console.WriteLine("Color: {0}", GetColor());
        //}
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Tabletop myTabletop = new Tabletop(10,20);
            Console.WriteLine("Length of myTabletop :{0}", myTabletop.GetLength());
            Console.ReadLine();
        }
    }
}
