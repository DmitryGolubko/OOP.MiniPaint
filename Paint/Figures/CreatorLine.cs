﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFigureClassLibrary;

namespace Paint.Figures
{
    class CreatorLine: Creator
    {
        public override Figure CreateFigure()
        {
            return new Line();
        }
    }
}
