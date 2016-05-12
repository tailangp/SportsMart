using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportsMart.Models;
using SportsMart.Repository;
using SportsMart.Services.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportsMart.Services.Test
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void test_product_create()
        {
            var productRepo = new Mock<IRepository<Product>>();
            var dummyProduct = get_dummy_product();
            productRepo.Setup(m => m.Create(dummyProduct)).Returns(Task.FromResult<int>(5));

            var productService = new ProductService(productRepo.Object);
            var result = productService.Create(dummyProduct).Result;
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void test_product_find_by_id()
        {
            var productRepo = new Mock<IRepository<Product>>();
            var dummyProduct = get_dummy_product();
            productRepo.Setup(m => m.FindById(dummyProduct.Id)).Returns(Task.FromResult<Product>(dummyProduct));

            var productService = new ProductService(productRepo.Object);
            var result = productService.FindById(dummyProduct.Id).Result;
            Assert.AreEqual(result.Id, dummyProduct.Id);
            Assert.AreEqual(result.Name, dummyProduct.Name);
            Assert.AreEqual(result.Price, dummyProduct.Price);
            Assert.IsNotNull(result.Category);
            Assert.AreEqual(result.Category.Id, dummyProduct.Category.Id);
            Assert.AreEqual(result.Category.Name, dummyProduct.Category.Name);
        }

        [TestMethod]
        public void test_products_get_all()
        {
            var productRepo = new Mock<IRepository<Product>>();
            var dummyProducts = get_dummy_products();
            productRepo.Setup(m => m.FindAll()).Returns(Task.FromResult<IEnumerable<Product>>(dummyProducts));

            var productService = new ProductService(productRepo.Object);
            var result = productService.FindAll().Result;
            Assert.IsNotNull(result);
        }






        private Product get_dummy_product()
        {
            return new Product { Id = 5, Name = "Test Product", Price = 10, Category = new ProductCategory { Id = 1, Name = "Electronics" } };
        }

        private List<Product> get_dummy_products()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 5, Name = "Test Product", Price = 10, Category = new ProductCategory { Id = 1, Name = "Electronics" } });
            products.Add(new Product { Id = 6, Name = "Test Product", Price = 11, Category = new ProductCategory { Id = 1, Name = "Electronics" } });
            products.Add(new Product { Id = 7, Name = "Test Product", Price = 12, Category = new ProductCategory { Id = 1, Name = "Electronics" } });

            return products;
        }
    }
}
