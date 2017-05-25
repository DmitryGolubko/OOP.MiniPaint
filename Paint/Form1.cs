﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.Figures;
using System.Windows.Input;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Paint
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private List<Figure> Figures;
        private Figure figure;
        private Pen pen;
        public BinaryFormatter formatter;
        public Figure selectedFigure;
        private Point currentPoint;
        private List<Point> MovingPoints;
        private bool moving;

        public Form1()
        {
            InitializeComponent(); 
            Figures = new List<Figure>();
            MovingPoints = new List<Point>();
            pen = new Pen(Color.Black, 1);
            graphics = pictureBox1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            pictureBoxColor.BackColor = Color.Black;
            trackBarPenWidth.Value = 1;
            pen.Width = trackBarPenWidth.Value;
            labelPenWidth.Text = "Толщина линий: " + trackBarPenWidth.Value.ToString();
            buttonSerialize.Enabled = false;
            buttonDeserialize.Enabled = true;
            selectedFigure = null;
            moving = false;
        }
                              
        private void DrawAll()
        {
            for (int i = 0; i < Figures.Count; i++)
            {
                Figures[i].Draw(graphics, Figures[i].colorParams);
            }
        }

        private void btnFigure_MouseDown(object sender, MouseEventArgs e)
        {
            figure = new CreatorList().GetFigure(int.Parse((sender as Button).Tag.ToString()));
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pen.Color = colorDialog1.Color;
            pictureBoxColor.BackColor = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBarPenWidth.Value;
            labelPenWidth.Text = "Толщина линий: " + trackBarPenWidth.Value.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            currentPoint = new Point(e.X, e.Y);
            MovingPoints.Add(currentPoint);
            if (figure != null)
            {
                figure.AddPoint(currentPoint);
                figure.colorParams = pen.Color;
                figure.widthParams = pen.Width;
                Figures.Add(figure);
                buttonSerialize.Enabled = true;
                selectedFigure = null;
            }
            else
            {
                moving = false;
                for (int i = Figures.Count - 1; i >= 0; i--)
                {
                    if (Figures[i].IsPointInFigure(currentPoint))
                    {
                        //DrawAll();
                        selectedFigure = Figures[i];
                        selectedFigure.Draw(graphics, Color.Red);
                        selectedFigure.Points[0] = currentPoint;
                        break;
                    }
                    else
                    {
                        DrawAll();
                        //Figures[i].Draw(graphics, Figures[i].colorParams);
                        selectedFigure = null;
                    }
                }
            } 
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var movePoint = new Point(e.X, e.Y);
            MovingPoints.Add(movePoint);
            if ((figure != null) && (e.Button == MouseButtons.Left))
            {
                graphics.Clear(Color.White);
                figure.EndPoint(movePoint);
                figure.Draw(graphics, figure.colorParams);
                DrawAll();
            }
            if ((selectedFigure != null) && (e.Button == MouseButtons.Left))
            {
                moving = true;
                graphics.Clear(Color.White);
                selectedFigure.StartPoint(new Point((selectedFigure.StartX - (MovingPoints[MovingPoints.Count - 2].X - MovingPoints[MovingPoints.Count - 1].X)), selectedFigure.StartY - (MovingPoints[MovingPoints.Count - 2].Y - MovingPoints[MovingPoints.Count - 1].Y)));
                selectedFigure.EndPoint(new Point((selectedFigure.EndX - (MovingPoints[MovingPoints.Count - 2].X - MovingPoints[MovingPoints.Count - 1].X)), selectedFigure.EndY - (MovingPoints[MovingPoints.Count - 2].Y - MovingPoints[MovingPoints.Count - 1].Y)));
                //DrawAll();
                for (int i = 0; i < Figures.Count; i++)
                {
                    if (Figures[i] != selectedFigure)
                    {
                        Figures[i].Draw(graphics, Figures[i].colorParams);
                    } 
                }
                selectedFigure.Draw(graphics, Color.Red);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var UpPoint = new Point(e.X, e.Y);
            MovingPoints.Add(UpPoint);
            if (figure != null)
            {
                figure.EndPoint(new Point(e.X, e.Y));
                figure.Draw(graphics, figure.colorParams);
                DrawAll();
            }
            if ((selectedFigure != null) && (e.Button == MouseButtons.Left))
            {
                graphics.Clear(Color.White);
                selectedFigure.StartPoint(new Point((selectedFigure.StartX - (MovingPoints[MovingPoints.Count - 2].X - MovingPoints[MovingPoints.Count - 1].X)), selectedFigure.StartY - (MovingPoints[MovingPoints.Count - 2].Y - MovingPoints[MovingPoints.Count - 1].Y)));
                selectedFigure.EndPoint(new Point((selectedFigure.EndX - (MovingPoints[MovingPoints.Count - 2].X - MovingPoints[MovingPoints.Count - 1].X)), selectedFigure.EndY - (MovingPoints[MovingPoints.Count - 2].Y - MovingPoints[MovingPoints.Count - 1].Y)));
                DrawAll();
                selectedFigure.Draw(graphics, Color.Red);
                if (moving)
                {
                    //DrawAll();
                    //selectedFigure.Draw(graphics, selectedFigure.colorParams);
                    moving = false;
                } 
            }
            figure = null;
            selectedFigure = null;
            MovingPoints.Clear(); 
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Figures.Clear();
            graphics.Clear(Color.White);
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {   
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height; 
        }

        private void buttonSerialize_Click(object sender, EventArgs e)
        {
            if (Figures.Count == 0)
            {
                MessageBox.Show("Нечего сериалиализовывать.", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                var formatter = new BinaryFormatter();
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                {
                    using (var fStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        formatter.Serialize(fStream, Figures);
                    }
                }
            }
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                using (var fStream = File.OpenRead(openFileDialog1.FileName))
                {
                    try
                    {
                        Figures = new List<Figure>();
                        Figures = (List<Figure>)formatter.Deserialize(fStream);
                        DrawAll();
                    }
                    catch (SerializationException g)
                    {
                        MessageBox.Show(g.Message);
                    }
                }  
            }
        }
    }
}
