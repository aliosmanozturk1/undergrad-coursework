namespace Hafta2_1_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.Text)
            {
                case "mavi": this.BackColor = Color.Blue; break;
                case "sarı": this.BackColor = Color.Yellow; break;
                case "beyaz": this.BackColor = Color.White; break;
                case "kırmızı": this.BackColor = Color.Red; break;
                case "yeşil": this.BackColor = Color.Green; break;
            }
        }
    }
}