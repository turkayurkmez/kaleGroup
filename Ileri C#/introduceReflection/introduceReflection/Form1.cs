using System.Reflection;
using System.Windows.Forms;
namespace introduceReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            clearAllListBoxes();
            try
            {
                //MessageBox.Show(comboBox1.SelectedText);
                Type type = Type.GetType(comboBox1.SelectedItem.ToString());
                if (type != null)
                {
                    fillMethods(type);
                    fillProperties(type);
                    fillEvents(type);
                }
                else
                {
                    MessageBox.Show("tipi bulamadık....");
                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("Tip adını doğru girdiğinize emin olun");
                
            }

           
           



        }

        private void clearAllListBoxes()
        {
            foreach (var item in this.Controls)
            {
                if (item is ListBox)
                {
                    (item as ListBox).Items.Clear();
                }

             
            }
        }

        private void fillEvents(Type? type)
        {
            type.GetEvents().ToList().ForEach(@event => listBoxEvents.Items.Add(@event.Name));
        }

        private void fillProperties(Type? type)
        {
            type.GetProperties().ToList().ForEach(property => listBoxProperties.Items.Add(property.Name));
        }

        private void fillMethods(Type? type)
        {
            foreach (var method in type.GetMethods())
            {
                listBoxMethods.Items.Add(method.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBoxType.Text = typeof(Button).AssemblyQualifiedName;
            var types = typeof(string).Assembly.GetTypes();
            foreach (var item in types)
            {
                comboBox1.Items.Add(item.AssemblyQualifiedName);
            }

            comboBox1.Items.Insert(0, typeof(Button).AssemblyQualifiedName);
        }
    }
}