namespace Display.Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pluginEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.InitialDirectory = Environment.CurrentDirectory;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //1. seçilen kasördeki .dll dosyalarında dolaş ve Plugin'leri getir.
            }
        }
    }
}