using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{


    public interface IRepository<T> where T : class, IEntity, new()
    { 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IList<T> GetAll();
        T GetById(int id);
    }

    public interface IMath<in T, out W> where T: struct, IComparable<T> 
                                        where W: struct, IComparable<W>
    {
        void Sum(T t1, T t2);
        W Test(T t1);
    }

    public class AdoProductRepository : IRepository<Product>
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEntity
    {

    }
    public class Customer : IEntity
    {

    }

    public class Product : IEntity
    {

    }

    public class Category : IEntity 
    {

    }


}
