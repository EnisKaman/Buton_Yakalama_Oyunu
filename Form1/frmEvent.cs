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
    public partial class frmEvent : Form
    {
        public frmEvent()
        {
            InitializeComponent();
            
        }
        private void MyClick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void frmEvent_Load(object sender, EventArgs e)
        {
            var rnd = new Random();
            button1.Text = rnd.Next(0, 100).ToString();
            button2.Text = rnd.Next(0, 100).ToString();
            button3.Text = rnd.Next(0, 100).ToString();
        }
        static int cevap = 0;
        private void Topla(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            cevap = int.Parse(buton.Text) + cevap;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cevap.ToString());
        }
    }
}
