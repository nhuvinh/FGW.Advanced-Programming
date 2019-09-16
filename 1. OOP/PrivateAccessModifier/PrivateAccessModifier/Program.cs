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
        private double length;
        private double width;
        private string color;

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
        public void Display()
        {
            base.Display();
            Console.WriteLine("Color: {0}", GetColor());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
