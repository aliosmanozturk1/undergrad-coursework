namespace Hafta2_3_VKI_Hesaplayici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaButonu_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(boy_TextBox.Text);
            double kilo = Convert.ToDouble(agirlik_TextBox.Text);

            double VKI = (kilo) / (boy / 100 * boy / 100);
            VKI_textBox.Text = VKI.ToString();

            if (VKI < 19) { siniflandirma_TextBox.Text = "Zayıf"; }
            else if (VKI < 25) { siniflandirma_TextBox.Text = "İdeal"; }
            else if (VKI < 35) { siniflandirma_TextBox.Text = "Kilolu"; }
            else if (VKI < 45) { siniflandirma_TextBox.Text = "Obez"; }
            else { siniflandirma_TextBox.Text = "Morbid Obez";  }
        }
    }
}