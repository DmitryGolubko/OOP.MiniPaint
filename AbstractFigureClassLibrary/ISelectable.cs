using System.Drawing;

namespace AbstractFigureClassLibrary
{
    interface ISelectable
    {
        bool IsPointInFigure(Point point);
    }
}
