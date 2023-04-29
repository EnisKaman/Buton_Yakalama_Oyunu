namespace Form1
{
    partial class YaziSayi
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
            this.sayi = new System.Windows.Forms.TextBox();
            this.yazi = new System.Windows.Forms.Label();
            this.cevir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sayi
            // 
            this.sayi.Location = new System.Drawing.Point(184, 152);
            this.sayi.Name = "sayi";
            this.sayi.Size = new System.Drawing.Size(100, 23);
            this.sayi.TabIndex = 0;
            // 
            // yazi
            // 
            this.yazi.AutoSize = true;
            this.yazi.Location = new System.Drawing.Point(403, 159);
            this.yazi.Name = "yazi";
            this.yazi.Size = new System.Drawing.Size(27, 15);
            this.yazi.TabIndex = 1;
            this.yazi.Text = "Sıfır";
            // 
            // cevir
            // 
            this.cevir.Location = new System.Drawing.Point(308, 239);
            this.cevir.Name = "cevir";
            this.cevir.Size = new System.Drawing.Size(75, 23);
            this.cevir.TabIndex = 2;
            this.cevir.Text = "Çevir";
            this.cevir.UseVisualStyleBackColor = true;
            this.cevir.Click += new System.EventHandler(this.cevir_Click);
            // 
            // YaziSayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cevir);
            this.Controls.Add(this.yazi);
            this.Controls.Add(this.sayi);
            this.Name = "YaziSayi";
            this.Text = "YaziSayi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox sayi;
        private Label yazi;
        private Button cevir;
    }
}