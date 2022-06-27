using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public interface IRpository<T> 
    {
        IList<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Remove(T entity);

        void Update(T entity);       
    }


    public interface IProductRepository:IRpository<Product>
    {
        IList<Product> SearchProductByName(string name);
    }

    public class EFProductRepository : IProductRepository
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Product entity)
        {
            throw new NotImplementedException();
        }

        public IList<Product> SearchProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
