using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Figures;
using System.Windows.Input;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        int checkingElement = 0;
        Point startPosition;
        List<Figure> Figures;
        string currentFigure;

        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
            Figures = new List<Figure>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            
        }

        private void EllipseButton_Click(object sender, EventArgs e)
        {
            var ellipse = new Ellipse(new Point(300, 300), 100, 50);
            ellipse.Draw(graphics);
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            var circle = new Circle(new Point(400, 300), 200);
            circle.Draw(graphics);
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = new Figures.Rectangle(new Point(400, 300), 200, 100);
            rectangle.Draw(graphics);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            var square = new Square(new Point(300, 100), 100);
            square.Draw(graphics);
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
           
            checkingElement = 1;
            currentFigure = "Paint.Figures." + LineButton.Name.Replace("Button", "");
             
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            var polygon = new Polygon();
            polygon.AddPoint(new Point(200, 200));
            polygon.AddPoint(new Point(200, 300));
            polygon.AddPoint(new Point(150, 50));
            polygon.AddPoint(new Point(300, 100));
            polygon.Draw(graphics);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkingElement == 1)
            {
                startPosition = e.Location;
                //currentFigure = "Paint.Figures.Line";
                Type type = Type.GetType(currentFigure);
                Type[] paramTypes = new Type[2];
                paramTypes[0] = (new Point()).GetType();
                paramTypes[1] = (new Point()).GetType();
                var temp = type.GetConstructor(paramTypes).Invoke(new Object[]{ new Point(1, 1), new Point(5, 5)});
                //var line = new Line(startPosition, startPosition);
                //string typeline = line.GetType().ToString();
                Figures.Add((Figure)temp);
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkingElement == 1)
            {
                Point endPosition = e.Location;
                ((Line)Figures[Figures.Count - 1]).EndPoint = endPosition;
                ((Line)Figures[Figures.Count - 1]).Draw(graphics);
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point endPosition = e.Location;
                ((Line)Figures[Figures.Count - 1]).EndPoint = endPosition;
                graphics.Clear(Color.White);
                ((Line)Figures[Figures.Count - 1]).Draw(graphics);
                DrawAll();
            }
            
        }
        private void DrawAll()
        {
            for (int i = 0; i < Figures.Count; i++)
            {
                Figures[i].Draw(graphics);
            }
        }
    }
}
