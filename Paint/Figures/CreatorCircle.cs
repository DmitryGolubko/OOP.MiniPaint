﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figures
{
    class CreatorCircle: CreatorEllipse
    {
        public override Figure CreateFigure()
        {
            return new Circle();
        }
    }
}
