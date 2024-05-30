ECommerceSystem
Project Concept: E-Commerce Management System
The ECommerceSystem is a layered C# project designed to manage an e-commerce platform. This project is structured in multiple phases to ensure a comprehensive understanding and implementation of various features over a period of 10 weeks.

Week 1: Project Fundamentals and Initial Steps
Project Structure and Layer Creation
Create a New C# Project:

Open Visual Studio and create a new project.
Select "Console App (.NET Core)" as the project type and name it ECommerceSystem.
Create Layers:

In Solution Explorer, right-click on the ECommerceSystem solution and select Add > New Project.
Select "Class Library (.NET Core)" and name it ECommerceSystem.Entities.
Repeat this process for ECommerceSystem.DataAccess, ECommerceSystem.Business, and ECommerceSystem.ConsoleApp.
Add Project References:

Right-click on the ECommerceSystem.ConsoleApp project and select Add > Project Reference.
Select ECommerceSystem.Entities, ECommerceSystem.DataAccess, and ECommerceSystem.Business and add them.
Product Entity and InMemory CRUD Operations
Create Product Entity in Entities Layer:

In the ECommerceSystem.Entities project, create a class named Product.cs with the following properties:


namespace ECommerceSystem.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
Define IProductDal Interface:

In the ECommerceSystem.DataAccess project, create an interface named IProductDal.cs with the following methods:


using ECommerceSystem.Entities;
using System.Collections.Generic;

namespace ECommerceSystem.DataAccess
{
    public interface IProductDal
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
Create InMemoryProductDal Class:

In the ECommerceSystem.DataAccess project, create a class named InMemoryProductDal.cs and implement the IProductDal interface:


using ECommerceSystem.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceSystem.DataAccess
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, CategoryId = 1, Name = "Product1", Description = "Description1", Price = 100, Stock = 10 },
                new Product { Id = 2, CategoryId = 2, Name = "Product2", Description = "Description2", Price = 200, Stock = 20 },
                // Other initial products
            };
        }

        public Product GetById(int id)
        {
            return _products.SingleOrDefault(p => p.Id == id);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Description = product.Description;
                productToUpdate.Price = product.Price;
                productToUpdate.Stock = product.Stock;
                productToUpdate.CategoryId = product.CategoryId;
            }
        }

        public void Delete(Product product)
        {
            var productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }
    }
}
Current Project Status
Product, Category, and Supplier entities have been created.
The DataAccess layers for these classes have been written, and their InMemory parts have been implemented.
Future Steps
Implement SQL Server database and EF Core for persistent data storage.
Develop Business layer services and validation rules.
Extend CRUD operations and set up Web API layer.
Implement Authentication and Authorization.
Optimize performance and implement caching.
Add logging and error handling.
Deploy the project to a server or cloud platform.
How to Run
Clone the repository:
bash

git clone https://github.com/onurkerembozkurt/ECommerceSystem.git
Open the solution in Visual Studio.
Set ECommerceSystem.ConsoleApp as the startup project.
Build and run the project.
Feel free to contribute and open issues for any bugs or enhancements.

License
This project is licensed under the MIT License.
