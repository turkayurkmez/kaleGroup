namespace FormsBagOnWindows
{
    public partial class Form1 : Form, IAttachFormBag
    {
        public Form1()
        {
            InitializeComponent();
        }

        public dynamic FormBag { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBag.MyCustomValue = "Uydurdum";
            form2.Show();
        }
    }
}