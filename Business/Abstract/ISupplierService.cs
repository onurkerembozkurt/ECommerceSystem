using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISupplierService
    {
         IResult Add(Supplier supplier);
         IResult Delete(Supplier supplier);
         IResult Update(Supplier supplier);
         IDataResult<List<Supplier>> GetAll();
         IDataResult<Supplier> GetById(int id);
    }
}
