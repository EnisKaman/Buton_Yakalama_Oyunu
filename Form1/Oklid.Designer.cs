namespace Form1
{
    partial class Oklid
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
            this.sonuc = new System.Windows.Forms.Button();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(334, 235);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(106, 58);
            this.sonuc.TabIndex = 0;
            this.sonuc.Text = "Sonuç";
            this.sonuc.UseVisualStyleBackColor = true;
            this.sonuc.Click += new System.EventHandler(this.sonuc_Click);
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(456, 159);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(100, 23);
            this.sayi2.TabIndex = 1;
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(221, 159);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(100, 23);
            this.sayi1.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(241, 130);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 15);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Birinci Sayı";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(478, 130);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 15);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "İkinci Sayı";
            // 
            // Oklid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sonuc);
            this.Name = "Oklid";
            this.Text = "Euclidean Algoritması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sonuc;
        private TextBox sayi2;
        private TextBox sayi1;
        private Label lbl1;
        private Label lbl2;
    }
}