namespace Hafta3_1_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Programı Kapatmak İstiyor musunuz?", "Program Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (sonuc == DialogResult.No)
            {
                // private void Form1_FormClosing(object sender, FormClosingEventArgs e) MessageBox.Show("Kapatma İşlemi İptal Edildi");
            }
            else if (sonuc == DialogResult.Yes)
            {
                MessageBox.Show("Uygulama Kapatılıyor");
            }
        }

    }
}