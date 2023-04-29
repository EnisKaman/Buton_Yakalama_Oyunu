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
    public partial class Matematik : Form
    {
        public Matematik()
        {
            InitializeComponent();
        }
        static int sonuc = 0;
        static int a;
        static int b;
        static int c;
        

        private void hesapla_Click(object sender, EventArgs e)
        {
            a = int.Parse(degerA.Text);
            b = int.Parse(degerB.Text);
            c = int.Parse(degerC.Text);

            sonuc = (b * b) - (4 * a * c);


            MessageBox.Show(sonuc.ToString());
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double arti;
            double eksi;
            double kare = Math.Sqrt(sonuc);

            arti = (-1 * (b + kare)) / (a * 2);
            eksi = (-1 * (b - kare)) / (a * 2);
            MessageBox.Show($"Pozitif Kök: " + arti + "\nNegatif Kök: " + eksi);
        }

       
    }
}
