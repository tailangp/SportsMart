using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportsMart.Services.Test
{
    [TestClass]
    public class ProductServicesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var productService = new Mock<IRepository<Product>>();
            var product = new Product();
            product.Id = 5;
            productService.Setup(m => m.FindById(product.Id)).Returns(Task.FromResult<Product>(product));
            var res = productService.FindById(product.Id);
            Assert.AreEqual(1, 1);
        }
    }
}
