﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figures
{
    public class Circle : Ellipse
    {

        public Circle(Point point, int radius) : base(point, radius, radius)
        {
       
        }
    }
}
