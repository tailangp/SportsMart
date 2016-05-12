using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsMart.Models;

namespace SportMart.Models.Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void test_product_instance()
        {
            Product product = new Product();
            Assert.IsNotNull(product);
        }

        [TestMethod]
        public void test_product_Id()
        {
            Product product = new Product();
            Assert.IsNotNull(product);
            Assert.AreEqual(product.Id, 0);
        }


        [TestMethod]
        public void test_product_Name()
        {
            Product product = new Product();
            Assert.IsNotNull(product);
            Assert.AreEqual(product.Name, null);
        }

        [TestMethod]
        public void test_product_Price()
        {
            Product product = new Product();
            Assert.IsNotNull(product);
            Assert.AreEqual(product.Price, 0);
        }

        [TestMethod]
        public void test_product_categoryId()
        {
            Product product = new Product();
            Assert.IsNotNull(product);
            Assert.AreEqual(product.CategoryId, 0);
        }

        [TestMethod]
        public void test_product_Category_Instance()
        {
            Product product = new Product();
            Assert.IsNotNull(product);
            Assert.IsNotNull(product.Category);
        }
    }
}
