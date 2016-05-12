using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsMart.Models;

namespace SportMart.Models.Test
{
    [TestClass]
    public class ProductCategoryTest
    {
        [TestMethod]
        public void test_ProductCategory_instance()
        {
            ProductCategory productCategory = new ProductCategory();
            Assert.IsNotNull(productCategory);
        }

        [TestMethod]
        public void test_ProductCategory_Id()
        {
            ProductCategory productCategory = new ProductCategory();
            Assert.IsNotNull(productCategory);
            Assert.AreEqual(productCategory.Id, 0);
        }


        [TestMethod]
        public void test_ProductCategory_Name()
        {
            ProductCategory productCategory = new ProductCategory();
            Assert.IsNotNull(productCategory);
            Assert.AreEqual(productCategory.Name, null);
        }

        [TestMethod]
        public void test_ProductCategory_Name_Val()
        {
            ProductCategory productCategory = new ProductCategory();
            productCategory.Name = "Electronics";
            Assert.IsNotNull(productCategory);
            Assert.AreEqual(productCategory.Name, "Electronics");
        }
    }
}
