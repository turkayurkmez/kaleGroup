using Display.SDK;

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
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //1. seçilen kasördeki .dll dosyalarında dolaş ve Plugin'leri getir.
                var plugs = PluginHelper.GetPlugs(folderBrowserDialog.SelectedPath);
                addMenuItemForPlug(plugs);
            }
        }

        Dictionary<string, Plug> loadedPlugins = new Dictionary<string, Plug>();
        private void addMenuItemForPlug(List<Plug> plugs)
        {
            plugs.ForEach(plug => { 
               ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(plug.Name);
                pluginsToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
                toolStripMenuItem.Click += ToolStripMenuItem_Click;
                loadedPlugins.Add(plug.Name, plug);

            });
        }

        private void ToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            string name = (sender as ToolStripItem).Text;

            int x = int.Parse(textBoxX.Text);
            int y = int.Parse(textBoxY.Text);
            Plug active = loadedPlugins[name];
            IPlug plug = PluginHelper.CreateInstance(active);
            plug.Draw(panel1.CreateGraphics(), new SolidBrush(Color.Red),x,y, 100, 100);
        }
    }
}