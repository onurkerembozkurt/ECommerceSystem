using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>() { new Product() {Id=1,CategoryId=1,Name="HP Notebook",Description="16GB RAM",Price=123456,Stock=6 },
                                                  new Product(){Id=2,CategoryId=2,Name="Samsung A12",Description="2GB RAM",Price=5600,Stock=5 } };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {



            //foreach (var item in _products)
            //{
            //    if (item.Id==product.Id)
            //    {
            //        productToDelete = item; 

            //    }
            //}
            //_products.Remove(productToDelete);
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product product)
        {
            Product dataToUpdate = null;
            foreach (var item in _products)
            {
                if (item.Id == product.Id)
                {

                    dataToUpdate.Name = product.Name;
                    dataToUpdate.Stock = item.Stock;
                    dataToUpdate.Price = item.Price;
                    dataToUpdate.CategoryId = item.CategoryId;
                }
            }
        }



    }
}
