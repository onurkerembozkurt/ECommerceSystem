using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal() {
        _categories= new List<Category>() { new Category() {Id=1,Name="Computer" },
                                            new Category(){Id=2,Name="CellPhone" } };
        
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete=_categories.FirstOrDefault(c => c.Id == category.Id);
            _categories.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);

        }

        public void Update(Category category)
        {
            Category categoryToUpdate=_categories.FirstOrDefault(c=>c.Id==category.Id);

        }
    }
}
