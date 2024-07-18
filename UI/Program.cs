using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product();

        product.Name = "Computer";
        product.Stock = 15;
        product.Price = 12412;
        product.Description = "16GB Ram";
        product.SupplierId = 1;
        product.CategoryId = 1;
        Category category = new Category() { Name="Electronics"};
        Supplier supplier = new Supplier() { Name="Jackson",ContactInfo="WebSite" };
        IProductDal productDals = new EfProductDal();
        productDals.Add(product);
        ICategoryDal categoryDal=new EfCategoryDal();
        categoryDal.Add(category);
        ISupplierDal supplierDal=new EfSupplierDal();
        supplierDal.Add(supplier);



        foreach (var item in productDals.GetProductDetailDtos())
        {
            Console.WriteLine(item.ProductName+" "+item.CategoryName+" "+item.SupplierName+" "+item.Price);
        }
    }

}
