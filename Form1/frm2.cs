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
    public partial class frm2 : Form
    {
        frm1 frm1;
        public frm2()
        {
            InitializeComponent();
        }

        public frm2(frm1 frm1)
        {
            InitializeComponent();
            this.frm1 = frm1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm1.Text = textBox1.Text;
            frm1 frm = (frm1)Application.OpenForms["frm1"];
            frm.Text=textBox1.Text;
        }
        
    }
}
