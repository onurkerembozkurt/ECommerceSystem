using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public void Add(Supplier supplier)
        {
            _supplierDal.Add(supplier);
        }

        public void Delete(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
        }

        public void Update(Supplier supplier)
        {
           _supplierDal.Update(supplier);
        }

        public List<Supplier> GetAll()
        {
            return _supplierDal.GetAll();
        }

        public Supplier GetById(int id)
        {
          return  _supplierDal.GetById(id);
        }
    }
}
