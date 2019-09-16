using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessModifier
{
    class Rectangle
    {
        //member variables
        double length;
        double width;

        public double GetArea()
        {
            return length * width;
        }

        public void SetLength(double len)
        {
            length = len;
        }

        public double GetLength()
        {
            return length;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

    class Box : Rectangle
    {
        public void setLength() {
        
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
                r.SetLength(10);
                Box b = new Box();
                b.SetLength(20);
                Console.WriteLine("{0}", b.GetLength());
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
