using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;

class Program
{
    static void Main(string[] args)
    {
        IProductDal productDals = new InMemoryProductDal();
        foreach (var item in productDals.GetAll())
        {
            Console.WriteLine(item.Name);
        }
    }

}
