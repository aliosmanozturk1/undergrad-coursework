namespace Hafta1_1_ButonOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Text = "Merhaba";
            this.BackColor = Color.Blue;
            
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = "Merhaba";
            this.BackColor = Color.Red;

            button1.Visible = true;
            button2.Visible = false;
        }
    }
}