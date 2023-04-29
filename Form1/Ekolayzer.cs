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
    public partial class Ekolayzer : Form
    {
        public Ekolayzer()
        {
            InitializeComponent();
        }
        private void Ekolayzer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Black;
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Height = random.Next(150);
            panel2.Height = random.Next(150);
            panel3.Height = random.Next(150);
            panel4.Height = random.Next(150);
            panel5.Height = random.Next(150);
            panel6.Height = random.Next(150);
            panel7.Height = random.Next(150);
            panel8.Height = random.Next(150);
        }

       
    }
}
