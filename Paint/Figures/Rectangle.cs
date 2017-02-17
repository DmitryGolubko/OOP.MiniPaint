using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figures
{
    public class Rectangle : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Point point, int width, int height) : base(point)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
