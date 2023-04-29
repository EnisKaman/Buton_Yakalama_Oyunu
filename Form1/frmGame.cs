using Microsoft.VisualBasic.ApplicationServices;
using Model;
using System;
using System.Collections;
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
    public partial class frmGame : Form
    {
        int puan = 0;
        string ad;
        string soyad;
        int kacdk;
        int dk;
        int sayac = 60;

        public frmGame()
        {
            InitializeComponent();
        }

        public frmGame(Kullanici usr , Seviye seviye)
        {
            InitializeComponent();
            label6.Text = $"{usr.Ad} {usr.Soyad}";
            this.kacdk = usr.Sure;

            this.seviye = seviye;
            Seviyeİslemleri();
        }

        ArrayList al = new ArrayList();
        Seviye seviye;

        void Seviyeİslemleri()
        {
            switch (seviye)
            {
                case Seviye.Kolay:
                    this.Size = new Size(300, 300);
                    break;
                case Seviye.Orta:
                    this.Size = new Size(500, 500);
                    break;
                case Seviye.Zor:
                    this.Size = new Size(800, 800);
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Helal olsun ne yaptın be");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            button1.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            panel1.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));


            this.button1.Location = new Point(rnd.Next(this.ClientSize.Width - button1.Width - panel1.Width), rnd.Next(this.ClientSize.Height - button1.Height));
           // Cursor.Position = PointToScreen(button1.Location);


            puan++;
            //puan= puan +53891;
            button1.Text = puan.ToString();
            label1.Text = puan.ToString();
            label4.Text = "Buton: " + button1.Location.ToString();

            if (puan == 1)
            {
                tmrSure.Start();
            }


        }

        private void frmGame_SizeChanged(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.ClientSize.Width - panel1.Width, 0);
            panel1.Height = this.ClientSize.Height;
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"{ad} {soyad}";
            if (kacdk <= 9)
            {
                sure.Text = $"0{kacdk}:00";
            }

            else
            {
                sure.Text = $"{kacdk}:00";
            }

            tmrSure.Interval = 1000;
            dk = kacdk - 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;

            for (int i = 0; i < kacdk; i++)
            {

                if (sayac == -1)
                {
                    dk--;
                    sayac = 59;
                }

                if (sayac <= 9)
                {
                    sure.Text = $"{dk}:0" + sayac.ToString();
                }
                else
                {
                    sure.Text = $"{dk}:" + sayac.ToString();
                }

                if (dk == 0 && sayac == 0)
                {
                    al.Add(puan);
                    tmrSure.Stop();
                    button1.Enabled = false;

                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show($"{ad} {soyad} {Puanlar()}\nTekrar Oynamak İster Misiniz ?", "Süreniz Doldu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialog == DialogResult.Yes)
                    {
                        puan = 0;
                        dk = kacdk;
                        tmrSure.Start();
                        button1.Text = "Bana Tıkla";
                        button1.Enabled = true;
                    }
                    else
                    {
                        this.Close();
                        button1.Enabled = false;
                        return;
                    }
                    
                }
            }
        }
        string Puanlar()
        {
            int sayac = 0;
            string skor=string.Empty;
            foreach (var item in al)
            {
                sayac++;
                skor += $"{sayac}. Oyunun Skoru: {item}\n";
            }
            return skor;
        }

        private void frmGame_MouseMove(object sender, MouseEventArgs e)
        {

            label2.Text = $"Mouse X: {e.X} , Y: {e.Y}";
        }
    }
}
