namespace Form1
{
    partial class frmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            button1 = new Button();
            label3 = new Label();
            kacdk = new TextBox();
            grpKullanici = new GroupBox();
            grpZorluk = new GroupBox();
            rbZor = new RadioButton();
            rbOrta = new RadioButton();
            rbKolay = new RadioButton();
            grpKullanici.SuspendLayout();
            grpZorluk.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 51);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 99);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(107, 43);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 0;
            txtAd.Tag = "Z";
            txtAd.TextChanged += txt_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(107, 96);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            txtSoyad.TextChanged += txt_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(326, 300);
            button1.Name = "button1";
            button1.Size = new Size(82, 40);
            button1.TabIndex = 3;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 145);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Süre";
            // 
            // kacdk
            // 
            kacdk.Location = new Point(107, 142);
            kacdk.Name = "kacdk";
            kacdk.PlaceholderText = "Dakika";
            kacdk.Size = new Size(100, 23);
            kacdk.TabIndex = 2;
            kacdk.Tag = "Z";
            kacdk.TextChanged += txt_TextChanged;
            // 
            // grpKullanici
            // 
            grpKullanici.Controls.Add(txtSoyad);
            grpKullanici.Controls.Add(kacdk);
            grpKullanici.Controls.Add(label1);
            grpKullanici.Controls.Add(label3);
            grpKullanici.Controls.Add(label2);
            grpKullanici.Controls.Add(txtAd);
            grpKullanici.Location = new Point(97, 75);
            grpKullanici.Name = "grpKullanici";
            grpKullanici.Size = new Size(250, 203);
            grpKullanici.TabIndex = 6;
            grpKullanici.TabStop = false;
            grpKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // grpZorluk
            // 
            grpZorluk.Controls.Add(rbZor);
            grpZorluk.Controls.Add(rbOrta);
            grpZorluk.Controls.Add(rbKolay);
            grpZorluk.Location = new Point(380, 75);
            grpZorluk.Name = "grpZorluk";
            grpZorluk.Size = new Size(297, 203);
            grpZorluk.TabIndex = 7;
            grpZorluk.TabStop = false;
            grpZorluk.Text = "Zorluk";
            // 
            // rbZor
            // 
            rbZor.AutoSize = true;
            rbZor.Location = new Point(122, 143);
            rbZor.Name = "rbZor";
            rbZor.Size = new Size(43, 19);
            rbZor.TabIndex = 2;
            rbZor.TabStop = true;
            rbZor.Text = "Zor";
            rbZor.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(122, 95);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(48, 19);
            rbOrta.TabIndex = 1;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKolay
            // 
            rbKolay.AutoSize = true;
            rbKolay.Location = new Point(122, 48);
            rbKolay.Name = "rbKolay";
            rbKolay.Size = new Size(54, 19);
            rbKolay.TabIndex = 0;
            rbKolay.TabStop = true;
            rbKolay.Text = "Kolay";
            rbKolay.UseVisualStyleBackColor = true;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpZorluk);
            Controls.Add(grpKullanici);
            Controls.Add(button1);
            Name = "frmGiris";
            Text = "frmGiris";
            grpKullanici.ResumeLayout(false);
            grpKullanici.PerformLayout();
            grpZorluk.ResumeLayout(false);
            grpZorluk.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Button button1;
        private Label label3;
        private TextBox kacdk;
        private GroupBox grpKullanici;
        private GroupBox grpZorluk;
        private RadioButton rbZor;
        private RadioButton rbOrta;
        private RadioButton rbKolay;
    }
}