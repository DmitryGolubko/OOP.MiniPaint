using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFigureClassLibrary;

namespace Paint
{
    public class CreatorCircle: CreatorEllipse
    {
        public CreatorCircle()
        {
            Name = "Круг";
        }
        public override Figure CreateFigure()
        {
            return new Circle();
        }
    }
}
