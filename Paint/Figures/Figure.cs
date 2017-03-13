﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    public abstract class Figure
    {

        public abstract void Draw(Graphics g);

        public Figure()
        {

        }
    }
}
