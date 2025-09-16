namespace Hafta4_2_AsalSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kontrol = 0;
            Console.Write("Sayı Girin : ");
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi == 1 || sayi == 0)
            {
                label2.Text = "Girdiğiniz Sayı Asal Değildir";

            }
            else
            {
                for (int i = 2; i < sayi / 2; i++)
                {
                    if (sayi % i == 0) //Kalansız bölünüyormu?
                    {
                        kontrol++;
                        break; //Diğer sayılara bakmaya gerek duymuyoruz.
                    }


                }

                if (kontrol != 0)
                {
                    label2.Text = "Girdiğiniz Sayı Asal Değildir";
                }

                else
                {
                    label2.Text = "Girdiğiniz Sayı Asaldır";
                }

            }
        }
    }
}