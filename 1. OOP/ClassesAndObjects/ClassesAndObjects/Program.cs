using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Box
    {
        private double length;   // Length of a box
        private double breadth;  // Breadth of a box
        private double height;   // Height of a box
        string color; // Color of a box
        
        // Default Constructor
        public Box()
        {
            length = 0;
            breadth = 0;
            height = 0;
            color = "white";

        }

        // Constructor with properties
        public Box(double len, double bre, double hei)
        {
            length = len;
            breadth = bre;
            height = hei;
            color = "white";
        }

        public Box(double len, double bre, double hei, string col) {
            length = len;
            breadth = bre;
            height = hei;
            color = col;
        }

        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        public void setColor(string col)
        {
            color = col; 
        }

        public double getArea()
        {
            return length * breadth;
        }

        public double getVolume()
        {
            return getArea() * height;
        }

   
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();   // Declare Box1 of type Box
            Box Box2 = new Box(6.0,5.4,4.4); // Declare Box2 of type Box
            Box Box3 = new Box(7.5, 2.2, 4.4, "red");
            double volume;

            // box 1 specification
            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(5.0);

            //// box 2 specification
            //Box2.setLength(12.0);
            //Box2.setBreadth(13.0);
            //Box2.setHeight(10.0);

            // volume of box 1
            volume = Box1.getVolume();
            Console.WriteLine("Volume of Box1 : {0}", volume);

            // volume of box 2
            volume = Box2.getVolume();
            Console.WriteLine("Volume of Box2 : {0}", volume);

            // volume of box 3
            volume = Box3.getVolume();
            Console.WriteLine("Volume of Box3 : {0}", volume);

            // Box 4
            Box Box4 = new Box(10, 20, 30);
            Console.WriteLine("Volume of Box4: {0}", Box4.getVolume());

            Console.ReadKey();
        }
    }
}
