using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Figures
{
    class CreatorList: List<Creator>
    {
        public CreatorList()
        {
            this.Add(new CreatorEllipse());
            this.Add(new CreatorCircle());
            this.Add(new CreatorRectangle());
            this.Add(new CreatorSquare());
            this.Add(new CreatorLine());
            this.Add(new CreatorPolygon());
        }

        public Figure GetFigure(int figureID)
        {
            return this[figureID].CreateFigure();
        }
    }
}
