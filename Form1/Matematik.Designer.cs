namespace Form1
{
    partial class Matematik
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
            this.degerC = new System.Windows.Forms.TextBox();
            this.degerB = new System.Windows.Forms.TextBox();
            this.degerA = new System.Windows.Forms.TextBox();
            this.hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // degerC
            // 
            this.degerC.Location = new System.Drawing.Point(497, 106);
            this.degerC.Name = "degerC";
            this.degerC.Size = new System.Drawing.Size(100, 23);
            this.degerC.TabIndex = 0;
            // 
            // degerB
            // 
            this.degerB.Location = new System.Drawing.Point(316, 106);
            this.degerB.Name = "degerB";
            this.degerB.Size = new System.Drawing.Size(100, 23);
            this.degerB.TabIndex = 1;
            // 
            // degerA
            // 
            this.degerA.BackColor = System.Drawing.SystemColors.Window;
            this.degerA.Location = new System.Drawing.Point(138, 106);
            this.degerA.Name = "degerA";
            this.degerA.Size = new System.Drawing.Size(100, 23);
            this.degerA.TabIndex = 2;
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(254, 230);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(100, 54);
            this.hesapla.TabIndex = 3;
            this.hesapla.Text = "Diskriminant";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kök Bul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Matematik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.degerA);
            this.Controls.Add(this.degerB);
            this.Controls.Add(this.degerC);
            this.Name = "Matematik";
            this.Text = "Matematik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox degerC;
        private TextBox degerB;
        private TextBox degerA;
        private Button hesapla;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}