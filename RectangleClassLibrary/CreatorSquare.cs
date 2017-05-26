using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFigureClassLibrary;

namespace RectangleClassLibrary
{
    public class CreatorSquare: CreatorRectangle
    {
        public CreatorSquare()
        {
            Name = "Квадрат";
        }
        public override Figure CreateFigure()
        {
            return new Square();
        }
    }
}
