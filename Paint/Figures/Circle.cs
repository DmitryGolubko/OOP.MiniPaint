using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    public class Circle : Ellipse
    {
        public Circle(Point center, int radius) : base(center, radius, radius)
        {
                  
        }

    }
}
