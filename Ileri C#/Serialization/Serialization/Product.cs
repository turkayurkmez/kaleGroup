using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Product
    {
        public Product()
        {

        }
        public Product(int id, decimal price)
        {
            Id = id;
            Price = price;
        }

        public int Id { get; set; }
        public NameDetails Name { get; set; }=new NameDetails();
        public decimal Price { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public string Version { get; set; }


    }
    [Serializable]
    public class ProductList 
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Clear()
        {
            Products.Clear();
        }


    }
}
