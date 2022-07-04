using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBagOnWindows
{
    public partial class Form2 : Form, IAttachFormBag
    {
        public Form2()
        {
            InitializeComponent();
        }

        public dynamic FormBag { get; set; } = new FormBag();

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = FormBag.MyCustomValue;
        }
    }
}
