using Model;
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
    public enum Seviye
    {
        Kolay,
        Orta,
        Zor
    }
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool boslukvar = false;

            foreach (Control item in this.Controls["grpKullanici"].Controls)
            {

                if (item is TextBox && item.Tag != null && item.Tag.ToString() == "Z" && item.Text == String.Empty)
                {
                    item.BackColor = Color.Red;
                    boslukvar = true;
                }
            }
            if (boslukvar)
            {
                MessageBox.Show("Lütfen İlgili Alanları Boş Bırakmayınız!", "Etme", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Seviye seviye;

            if (rbKolay.Checked)
            {
                seviye = Seviye.Kolay;
            }
            else if (rbOrta.Checked)
            {
                seviye = Seviye.Orta;
            }
            else
            {
                seviye = Seviye.Zor;
            }

            try
            {
                frmGame frmGame = new frmGame(new Kullanici { Ad = txtAd.Text, Soyad = txtSoyad.Text, Sure = int.Parse(kacdk.Text) }, seviye);
                frmGame.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Süre Kısmına Sayısal Değer Giriniz", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }



        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == String.Empty)
            {
                txt.BackColor = Color.Red;
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }

    }
}
