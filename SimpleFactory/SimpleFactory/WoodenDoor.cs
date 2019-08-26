using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class WoodenDoor : IDoor
    {
        private int Height { get; set; }
        private int Width { get; set; }

        public WoodenDoor(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int GetHeight()
        {
            return this.Height;
        }
        public int GetWidth()
        {
            return this.Width;
        }
    }
}
