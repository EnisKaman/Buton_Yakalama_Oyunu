namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var btn = new Button();
            btn.Size = new Size(100, 50);
            btn.Text = "my button";
            btn.Location = new Point(50, 50);
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}