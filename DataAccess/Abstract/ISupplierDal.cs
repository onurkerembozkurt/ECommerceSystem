using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISupplierDal
    {
        public void Add(Supplier supplier);
        public void Delete(Supplier supplier);
        public void Update(Supplier supplier);
        public List<Supplier> GetAll();
        public Supplier GetById(int id);
    }
}
