namespace Hafta4_3_ArdisikToplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            double toplam;
            toplam = 0;
            for (int i = x; i <= y; i++)
            {
                toplam += i;
            }
            label3.Text = toplam.ToString();
        }
    }
}