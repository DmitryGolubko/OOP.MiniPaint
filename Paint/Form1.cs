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
using System.Drawing.Drawing2D;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        List<Figure> Figures;
        private Figure figure;
        GraphicsState transState;

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
            if (figure != null)
            { 
                figure.AddPoint(new Point(e.X, e.Y));
                Figures.Add(figure);
                transState = graphics.Save();
            }       
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (figure != null)
            {
                transState = graphics.Save();
                graphics.Clear(Color.White);
                graphics.Restore(transState);
                //DrawAll();
                figure.EndPoint(new Point(e.X, e.Y));
                figure.Draw(graphics);
                transState = graphics.Save();
                //graphics.Restore(transState);
            }
            figure = null;            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((figure != null) && (e.Button == MouseButtons.Left))
            {
                figure.EndPoint(new Point(e.X, e.Y));
                graphics.Clear(Color.White);
                
                figure.Draw(graphics);
                //graphics.Restore(transState);
                //DrawAll();
            }

        }

        private void DrawAll()
        {
            for (int i = 0; i < Figures.Count; i++)
            {
                Figures[i].Draw(graphics);
            }
        }

        private void btnFigure_MouseDown(object sender, MouseEventArgs e)
        {
            figure = new CreatorList().GetFigure(Int32.Parse((sender as Button).Tag.ToString()));

        }
    }
}
