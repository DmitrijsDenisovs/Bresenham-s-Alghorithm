using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLine
{
    public partial class Form1 : Form
    {
        int x1_val;
        int x2_val;
        int y1_val;
        int y2_val;

        bool firstCoords = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetCoordsAndDraw();
        }

        private void DrawPoint(Color color, int x, int y)
        {
            SolidBrush brush = new SolidBrush(color);

            this.CreateGraphics().FillRectangle(brush, x, y, 1, 1);
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            if (Math.Abs(y2 - y1) < Math.Abs(x2 - x1))
            {
                if (x1 > x2)
                {
                    PlotLineLow(x2, y2, x1, y1);
                }
                else
                {
                    PlotLineLow(x1, y1, x2, y2);
                }
            }
            else
            {
                if (y1 > y2)
                {
                    PlotLineHigh(x2, y2, x1, y1);
                }
                else
                {
                    PlotLineHigh(x1, y1, x2, y2);
                }
            }
        }

        private void PlotLineLow(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int yi = 1;
            if (dy < 0)
            {
                yi = -1;
                dy = (-1) * dy;
            }

            int error = (2 * dy) - dx;
            int y = y1;

            for (int x = x1; x < x2; x++)
            {
                DrawPoint(Color.Red, x, y);
                if (error > 0)
                {
                    y += yi;
                    error += (2 * (dy - dx));
                }
                else
                {
                    error += 2 * dy;
                }
            }
        }

        private void PlotLineHigh(int x1, int y1, int x2, int y2)
        {
            int dx = x2 - x1;
            int dy = y2 - y1;
            int xi = 1;
            if (dx < 0)
            {
                xi = -1;
                dx = (-1) * dx;
            }

            int error = (2 * dx) - dy;
            int x = x1;

            for (int y = y1; y < y2; y++)
            {
                DrawPoint(Color.Blue, x, y);
                if (error > 0)
                {
                    x += xi;
                    error += (2 * (dx - dy));
                }
                else
                {
                    error += 2 * dx;
                }
            }
        }

        private void NumericInput_KeyPress(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int x = this.PointToClient(Cursor.Position).X;
            int y = this.PointToClient(Cursor.Position).Y;
            this.CreateGraphics().DrawRectangle(new Pen(Color.Black, 5), new Rectangle(x, y, 1, 1));
            if (firstCoords)
            {
                x1.Text = x.ToString();
                y1.Text = y.ToString();
            }
            else
            {
                x2.Text = x.ToString();
                y2.Text = y.ToString();
            }

            firstCoords = !firstCoords;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                GetCoordsAndDraw();
            }
        }

        private void GetCoordsAndDraw()
        {
            bool valid = true;

            if (Int32.TryParse(x1.Text, out x1_val))
            {
            }
            else
            {
                valid = false;
            }

            if (Int32.TryParse(x2.Text, out x2_val))
            {
            }
            else
            {
                valid = false;
            }

            if (Int32.TryParse(y1.Text, out y1_val))
            {
            }
            else
            {
                valid = false;
            }

            if (Int32.TryParse(y2.Text, out y2_val))
            {
            }
            else
            {
                valid = false;
            }

            if (valid)
            {
                DrawLine(x1_val, y1_val, x2_val, y2_val);
            }
            else
            {
                MessageBox.Show("Coordinates must be integer numbers", "Invalid input");
            }
        }
    }
}
