using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceSystemContext>, IProductDal
    {


        public List<ProductDetailDto> GetProductDetailDtos() {

            using (ECommerceSystemContext eCommerceSystemContext=new ECommerceSystemContext())
            {
                var result = from p in eCommerceSystemContext.Products
                             join c in eCommerceSystemContext.Categories
                             on p.CategoryId equals c.Id
                             join s in eCommerceSystemContext.Suppliers
                             on p.SupplierId equals s.Id
                             select new ProductDetailDto { ProductName = p.Name, CategoryName = c.Name, SupplierName = s.Name, Price = p.Price };
                return result.ToList();

            }

        }
        
    }
}
