using System.Diagnostics;

namespace ParallelFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetSize_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                ParallelFor(dialog);
                //standardFor(dialog.SelectedPath);
            }
        }

        private void standardFor(string selectedPath)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long totalSize = 0;
            var files = Directory.GetFiles(selectedPath, "*.*", searchOption: SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                var fileInfo = new FileInfo(files[i]);
                totalSize += fileInfo.Length;
            }
            stopwatch.Stop();

            var megaByte = totalSize / (1024 * 1024);
            label1.Text = $"{files.Length} kadar dosyanın toplam boyutu: {megaByte.ToString("N0")}";
            label2.Text = stopwatch.ElapsedMilliseconds.ToString();
        }

        private void ParallelFor(FolderBrowserDialog dialog)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long totalSize = 0;
            var files = Directory.GetFiles(dialog.SelectedPath, "*.*", searchOption: SearchOption.AllDirectories);
            Parallel.For(0, files.Length, x =>
            {
                var fileInfo = new FileInfo(files[x]);
                //totalSize += fileInfo.Length;
                Interlocked.Add(ref totalSize, fileInfo.Length);
            });

            stopwatch.Stop();


            var megaByte = totalSize / (1024 * 1024);
            label1.Text = $"{files.Length} kadar dosyanın toplam boyutu: {megaByte.ToString("N0")}";
            label3.Text = stopwatch.ElapsedMilliseconds.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                //ParallelFor(dialog);
                standardFor(dialog.SelectedPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                var files = Directory.GetFiles(dialog.SelectedPath, "*.*", SearchOption.AllDirectories);

                Stopwatch stopwatch = Stopwatch.StartNew();
                long totalSize = 0;
                Parallel.ForEach(files, file =>
                {
                    FileInfo fileInfo = new FileInfo(file);
                    Interlocked.Add(ref totalSize, fileInfo.Length);
                });

                stopwatch.Stop();

                label1.Text = $"{files.Length} kadar dosyanın toplam boyutu: {totalSize.ToString("N0")}";

                label4.Text = stopwatch.ElapsedMilliseconds + " milisaniyede tamamlandı";

                //ParallelFor(dialog);

            }
        }
    }
}