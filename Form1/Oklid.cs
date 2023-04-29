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
    public partial class Oklid : Form
    {
        public Oklid()
        {
            InitializeComponent();
        }

        private void sonuc_Click(object sender, EventArgs e)
        {


            int cevap = 0;
            int sonuc = 0;
            int rakam1 =0;
            int rakam2 =0;
            int rakam3 =0;

            rakam1 = int.Parse(sayi1.Text); //1. sayıyı değişkene atadım
            rakam2 = int.Parse(sayi2.Text); //2. sayıyı değişkene atadım

            if (rakam1 < rakam2) // Eğer girilen birinci sayı ikinci sayıdan küçükse ;
            {
                rakam3 = rakam2; // Büyük sayı farklı bir değişkende tutulur ve birinci sayı olur,               
                rakam2= rakam1;  // Küçük sayı ikinci sayı olur.   

                while (cevap <= 0)
                {
                    cevap = rakam3 % rakam2; //Birinci sayının ikinciye bölümünden kalanı cevap değişkenine atanır
                    sonuc = sonuc + cevap;   //Sonuç toplanır
                    rakam3 = rakam2;         //İkinci sayı bölünen olur
                    rakam2 = cevap;          //ilk işlemden kalan bölen olur

                }                            //Sonuç 0 olana kadar işlem başa döner
            }
            else //Girilen ilk sayı ikinciden küçük değilse işlemler normal olarak yapılır
            {
                while (cevap <= 0)
                {
                    cevap = rakam1 % rakam2;
                    sonuc = sonuc + cevap;
                    rakam1 = rakam2;
                    rakam2 = cevap;

                }
            }
         

            

            MessageBox.Show(sonuc.ToString()); //Sonuç ekrana yazdırılması
        }
    }
}
