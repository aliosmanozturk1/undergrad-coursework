using Microsoft.VisualBasic.Logging;

namespace Hafta2_2_NotHesaplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaButonu_Click(object sender, EventArgs e)
        {
            int araSinav = Convert.ToInt32(arasinavTextBox.Text);
            int finalSinav = Convert.ToInt32(finalSinavTextBox.Text);

            int ortalama = (araSinav * 40 / 100) + (finalSinav * 60 / 100);
            hesaplananNotTextBox.Text = ortalama.ToString();

            if (ortalama > 85)
            {
                harfNotTextBox.Text = "AA";
            }

            else if (ortalama > 75)
            {
                harfNotTextBox.Text = "BA";
            }

            else if (ortalama > 60)
            {
                harfNotTextBox.Text = "BB";
            }

            else if (ortalama >= 50)
            {
                harfNotTextBox.Text = "DD";
            }

            else if (ortalama < 50)
            {
                harfNotTextBox.Text = "FF";
            }

        }
    }
}