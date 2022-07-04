namespace introThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread counter = null;

        private async void button1_Click(object sender, EventArgs e)
        {
            //counter = new Thread(countToANumber);
            //counter.Start();

           await Task.Run(countToANumber);

            //counter.Join();

            MessageBox.Show("Döngü tamamlandı");
        }

        Task countToANumber()
        {
            for (int i = 0; i < 10000; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i / 100;
            }
            
            return Task.CompletedTask;
        }

        private void buttonSample_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //counter.Join();
        }
    }
}