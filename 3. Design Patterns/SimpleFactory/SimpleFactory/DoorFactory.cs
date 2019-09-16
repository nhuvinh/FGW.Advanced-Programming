using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class DoorFactory
    {
        public static IDoor MakeDoor(int height, int width)
        {
            return new WoodenDoor(height, width);
        }
    }
}
