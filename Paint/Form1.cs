using System;
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
        private Figure selectedFigure;

        public Form1()
        {
            InitializeComponent(); 
            Figures = new List<Figure>();
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
            if (figure != null)
            {
                figure.AddPoint(new Point(e.X, e.Y));
                figure.colorParams = pen.Color;
                figure.widthParams = pen.Width;
                Figures.Add(figure);
                buttonSerialize.Enabled = true;
                selectedFigure = null;
            }
            else
            {
                for (int i = Figures.Count - 1; i >= 0; i--)
                {
                    if (Figures[i].IsPointInFigure(new Point(e.X, e.Y)))
                    {
                        DrawAll();
                        Figures[i].colorParams = Color.Red;
                        Figures[i].Draw(graphics);
                        selectedFigure = Figures[i];
                        Figures[i].colorParams = pen.Color;
                        break;
                    }
                    else
                    {
                        DrawAll();
                        Figures[i].colorParams = pen.Color;
                        Figures[i].Draw(graphics);
                        selectedFigure = null;
                    }
                }
            } 
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if ((figure != null) && (e.Button == MouseButtons.Left))
            {
                graphics.Clear(Color.White);
                figure.EndPoint(new Point(e.X, e.Y));
                figure.Draw(graphics);
                DrawAll();
            }
            if ((selectedFigure != null) && (e.Button == MouseButtons.Left))
            {
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (figure != null)
            {
                figure.EndPoint(new Point(e.X, e.Y));
                figure.Draw(graphics);
                DrawAll();
            }
            figure = null;
            
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
                using (var fStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, Figures);
                }
            }
        }

        private void buttonDeserialize_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            openFileDialog1.ShowDialog();
            using (var fStream = File.OpenRead(openFileDialog1.FileName))
            {   
                try
                {
                    Figures = new List<Figure>();
                    Figures = (List<Figure>)formatter.Deserialize(fStream);
                    DrawAll();
                }
                catch(SerializationException g)
                {
                    MessageBox.Show(g.Message);
                }
                   
            }
        }
    }
}
