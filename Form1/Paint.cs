using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) => g = this.CreateGraphics();
        Graphics g;
        Bitmap b = new Bitmap(5, 5);
        bool Durum;
        int x = 5;
        private void DrawLine(Graphics g, Point location, Color color)
        {
            if (Durum)
            {
                for (int i = 0; i < x; i++)
                    for (int j = 0; j < x; j++)
                        b.SetPixel(i, j, color);
                g.DrawImageUnscaled(b, location.X, location.Y);
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DrawLine(g, e.Location, Renk);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) => Durum = false;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Durum = true;
                DrawLine(g, e.Location, Renk);
            }
        }
        Color Renk = Color.Black;
        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            if (cdRenk.ShowDialog() == DialogResult.OK)
                Renk = cdRenk.Color;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            x = int.Parse(txt.Text);
            b = new Bitmap(x, x);
        }
    }
}
