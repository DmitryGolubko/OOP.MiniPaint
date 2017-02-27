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
//using System.Windows.Media;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            var line = new Line(new Point(300, 400), new Point(370, 450));
            line.Draw(graphics);
        }

        private void PolygonButton_Click(object sender, EventArgs e)
        {
            var polygon = new Polygon();
            polygon.AddPoint(new Point(200, 200));
            polygon.AddPoint(new Point(200, 300));
            polygon.AddPoint(new Point(150, 50));
            polygon.Draw(graphics);
        }
    }
}
