namespace Hafta4_1_Thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread start1 = new Thread(delegate () { ProgressDoldur(progressBar1, label1, 0, 1000); });
            Thread start2 = new Thread(delegate () { ProgressDoldur(progressBar2, label4, 0, 1000); });
            Thread start3 = new Thread(delegate () { ProgressDoldur(progressBar3, label5, 0, 1000); });

            start1.Start();
            start2.Start();
            start3.Start();
        }

        public void ProgressDoldur(ProgressBar prgBar, Label lbl, int min, int max)
        {
            prgBar.Maximum = max;
            prgBar.Minimum = min;

            prgBar.Step = 5;

            for (int i = prgBar.Minimum; i <= prgBar.Maximum; i++)
            {
                prgBar.Value = i;
                lbl.Text = i.ToString();
            }
        }
    }
}