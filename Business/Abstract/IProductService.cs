using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
         IDataResult<Product> GetById(int id);
         IDataResult<List<Product>> GetAll();
        IDataResult<List<ProductDetailDto>> GetProductDetailDtos();

    }
}
