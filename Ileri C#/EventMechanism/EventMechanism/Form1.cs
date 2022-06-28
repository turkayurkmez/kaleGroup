namespace EventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSample_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            categoryService.CategoryAdded += CategoryService_CategoryAdded;
            categoryService.AddCategory(new Category { Name = "Bilgisayar" });

        }

        private void CategoryService_CategoryAdded(object sender, CategoryAddedEventArgs e)
        {
            MessageBox.Show($"{e.NewCategory.Name}, {e.CreatedDate.ToString()} tarihinde, {e.CreatedBy} tarafından eklendi");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}