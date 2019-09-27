using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramsExamples
{
    class Rectangle {
        private int width;
        private int height;
        double area;

        public Rectangle(int w, int h) { }

        public double distance (Rectangle r)
        {
            return 0;
        }
    }

    class Student
    {
        private string name;
        private int id;
        private static int totalStudents;

        public int getID()
        {
            return id;
        }

        string getEmail()
        {
            return name + "@fpt.edu.vn";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
