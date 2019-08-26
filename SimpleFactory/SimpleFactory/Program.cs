using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var door = DoorFactory.MakeDoor(80, 30);
            Console.WriteLine($"Height of Door : {door.GetHeight()}");
            Console.WriteLine($"Width of Door : {door.GetWidth()}");
            Console.ReadKey();
        }
    }
}
