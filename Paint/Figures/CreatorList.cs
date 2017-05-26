using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFigureClassLibrary;

namespace Paint.Figures
{
    class CreatorList: Dictionary<int, Creator>
    {
        private int currentId = 0;

        public CreatorList()
        {
            AddCreator(new CreatorLine());
        }

        public Figure GetFigure(int figureID)
        {
            return this[figureID].CreateFigure();
        }

        public int AddCreator(Creator creator)
        {
            this.Add(currentId, creator);
            return currentId++;
        }
    }
}
