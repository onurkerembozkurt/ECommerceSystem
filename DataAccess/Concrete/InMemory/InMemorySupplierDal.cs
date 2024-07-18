using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemorySupplierDal : ISupplierDal
    {
        List<Supplier> _suppliers;
        public InMemorySupplierDal()
        {
            _suppliers = new List<Supplier>() { new Supplier() {Id=1,Name="XYZ",ContactInfo="John" },
                                                new Supplier(){Id=2,Name="ABC",ContactInfo="Jackson" } };
        }
        public void Add(Supplier supplier)
        {
            _suppliers.Add(supplier);
        }

        public void Delete(Supplier supplier)
        {
            Supplier supplierToDelete = _suppliers.FirstOrDefault(s=>s.Id==supplier.Id);
            _suppliers.Remove(supplierToDelete);
        }

        public Supplier Get(Expression<Func<Supplier, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetAll()
        {
            return _suppliers;
        }

        public List<Supplier> GetAll(Expression<Func<Supplier, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Supplier GetById(int id)
        {
            return _suppliers.FirstOrDefault(s => s.Id == id);

        }

        public void Update(Supplier supplier)
        {
            Supplier supplierToUpdate=_suppliers.FirstOrDefault(s=>s.Id==supplier.Id);
        }
    }
}
