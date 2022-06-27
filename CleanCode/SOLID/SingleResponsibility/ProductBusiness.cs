using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductBusiness
    {
        public int AddProduct(string name, string description, decimal price)
        {
            var connectionString = @"Data Source=(localdb)\Mssqllocaldb;Initial Catalog=sampleDatabase;Integrated Security=True";
            var commandText = "Insert into Products (Name, Description,Price) values (@name, @description,@price)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@name", name);
            parameters.Add("@description", description);
            parameters.Add("@price", price);

         
            var affectedRowsCount = new DataHelper(connectionString).Execute(commandText, parameters);
           

            return affectedRowsCount;
        }
    }
}
