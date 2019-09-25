using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalization
{
    interface Shape
    {
        double getArea();
    }

    abstract class RectangularShape : Shape
    {
        private int width;
        private int height;
        
        public bool contains(int x, int y)
        {
            return true;
        }


        // double getArea()
        //{
        //    return 0;
        //}

        double Shape.getArea()
        {
            throw new NotImplementedException();
        }

        
    }

    class Rectangle
    {
        private int x;
        private int y;

        public Rectangle (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distance(Rectangle r)
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
