using System.Data.SqlClient;

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Bir nesnenin sadece bir sormuluğu olmalı.
         * 
         * Bir nesneyi değiştirmek için birden fazla sebep buluyorsanız, prensibe uymuyorsunuz demektir.
         */


        private void buttonAddProduct_Click(object sender, EventArgs e)
        {


            string name = textBoxProductName.Text;
            string description=textBoxDescription.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);

            ProductBusiness productBusiness = new ProductBusiness();
            var affectedRowsCount=productBusiness.AddProduct(name, description, price );       


            string message = affectedRowsCount > 0 ? "Kayıt Başarılı" : "Kayıt başarısız";
            MessageBox.Show(message);



        }
    }
}