using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFigureClassLibrary;

namespace RectangleClassLibrary
{
    public class CreatorRectangle: Creator 
    {
        public CreatorRectangle()
        {
            Name = "Прямоугольник";
        }
        public override Figure CreateFigure()
        {
            return new Rectangle();
        }
    }
}
