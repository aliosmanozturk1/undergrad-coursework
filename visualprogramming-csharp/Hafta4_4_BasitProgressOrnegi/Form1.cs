namespace Hafta4_4_BasitProgressOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int yaziUzunluk = textBox1.TextLength;
            int deger = (int)yaziUzunluk * 100 / textBox1.MaxLength;
            progressBar1.Value = deger;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 150;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 5;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }
    }
}