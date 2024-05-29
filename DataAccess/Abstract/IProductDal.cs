using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(Product product);
        public List<Product> GetAll();
        public Product GetById(int id);
    }
}
