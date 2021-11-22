using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_tests
{
    [TestClass]
    public class ProductStockTests
    {
        private ProductStock itemsInStock;
        private ProductStock itemsInStockEmpty;
        [TestInitialize]
        public void Initialize()
        {
            itemsInStock = new ProductStock();
            itemsInStockEmpty = new ProductStock();

            var testProduct1 = new Product(1, "name1", 5, "kg", 0.3);
            var testProduct2 = new Product(2, "name2", 5, "kg", 0.3);
            var testProduct3 = new Product(3, "name3", 5, "kg", 0.3);

            itemsInStock.addToStock(testProduct1);
            itemsInStock.addToStock(testProduct2);
            itemsInStock.addToStock(testProduct3);
        }

        [TestMethod]
        public void newID_WhenEmptyList_Test()
        {
            var id = itemsInStockEmpty.newID();
            var expected = 1;

            Assert.AreEqual(expected, id);
        }

        [TestMethod]
        public void newID_WhenNotEmptyList_Test()
        {
            var id = itemsInStock.newID();
            var expected = 4;

            Assert.AreEqual(expected, id);
        }
        
        [DataTestMethod]
        [DataRow(1, true)]
        [DataRow(5, false)]
        [DataRow(-1, false)]
        public void isAvailable_Test(int id, bool expected)
        {
            var result = itemsInStock.isAvailable(id);
            
            Assert.AreEqual(result, expected);
        }
        
        [TestMethod]
        public void getStock_WhenAvailable_Test()
        {
            var stock = itemsInStock.getStock(1);
            var expected = 5;

            Assert.AreEqual(expected, stock);
        }
        
        [TestMethod]
        public void getStock_WhenUnavailable_Test()
        {
            Assert.ThrowsException<NullReferenceException>(() => itemsInStock.getStock(5));
        }

        [DataTestMethod]
        [DataRow(1, 10, 10)]
        [DataRow(-1, 10, -1)]
        [DataRow(5, 10, -1)]
        [DataRow(5, -5, -1)]
        public void updateStock_Test(int id, int stock, int expected)
        {
            var result = itemsInStock.updateStock(id, stock);

            Assert.AreEqual(result, expected);
        }
        
        [TestMethod]
        public void removeStock_WhenAvailable_Test()
        {
            itemsInStock.removeStock(1);
            var available = itemsInStock.isAvailable(1);

            Assert.IsFalse(available);
        }

        [TestMethod]
        public void deductStock_WhenAvailable_Test()
        {
            var expected = 4;
            itemsInStock.deductStock(1);

            var stock = itemsInStock.getStock(1);

            Assert.AreEqual(expected, stock);
        }
        
        [TestMethod]
        public void deductStock_WhenUnavailable_Test()
        {
            Assert.ThrowsException<NullReferenceException>(() => itemsInStock.deductStock(6));
        }

        [TestMethod]
        public void addToStock_Test()
        {
            var product = new Product(5, "prod1", 10, "kg", 0.3);

            itemsInStock.addToStock(product);

            var available = itemsInStock.isAvailable(5);
            var productResult = itemsInStock.getProduct(5);

            Assert.AreEqual(product, productResult);
            Assert.AreEqual(available, true);
        }
    }
}