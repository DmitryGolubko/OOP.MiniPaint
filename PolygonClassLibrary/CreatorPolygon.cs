using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFigureClassLibrary;
using System.Drawing;

namespace PolygonClassLibrary
{
    public class CreatorPolygon: Creator
    {
        public CreatorPolygon()
        {
            Name = "Пятиугольник";
        }
        public override Figure CreateFigure()
        {
            return new Polygon();
        }
    }
}
