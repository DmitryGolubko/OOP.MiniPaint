﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figures
{
    public class Ellipse : Figure
    {
        public int A { get; set; }
        public int B { get; set; }

        public Ellipse(Point point, int a, int b) : base(point)
        {
            this.A = a;
            this.B = b;
        }
    }
}
