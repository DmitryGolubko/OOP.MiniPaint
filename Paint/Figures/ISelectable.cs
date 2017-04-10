using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint.Figures
{
    interface ISelectable
    {
        bool IsPointInFigure(Point point);
    }
}
