using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager_visma.Tests
{
    [TestClass()]
    public class OrdersTests
    {
        private Orders orders;
        private Orders ordersEmpty;
        private Menu menuItems;
        private ProductStock itemsInStock;
        [TestInitialize]
        public void Initialize()
        {
            itemsInStock = new ProductStock();
            menuItems = new Menu();
            orders = new Orders();
            ordersEmpty = new Orders();

            var testProduct1 = new Product(1, "name1", 5, "kg", 0.3);
            var testProduct2 = new Product(2, "name2", 5, "kg", 0.3);
            var testProduct3 = new Product(3, "name3", 5, "kg", 0.3);
            var testProductIds = new List<int>();
            testProductIds.Add(1);
            testProductIds.Add(2);
            testProductIds.Add(3);


            itemsInStock.addToStock(testProduct1);
            itemsInStock.addToStock(testProduct2);
            itemsInStock.addToStock(testProduct3);

            var testMenuItem = new MenuItem(1, "menuItem1", testProductIds);

            menuItems.addMenuItem(testMenuItem);
        }

        [TestMethod()]
        public void newID_WhenNotEmpty_Test()
        {
            var orderItem = new OrderItem(1, DateTime.Now, new List<int> { 1 });
            orders.createOrder(orderItem);

            var id = orders.newID();
            var expected = 2;

            Assert.AreEqual(expected, id);
        }

        [TestMethod()]
        public void newID_WhenEmpty_Test()
        {
            var id = orders.newID();
            var expected = 1;

            Assert.AreEqual(expected, id);
        }

        [TestMethod()]
        public void createOrderTest()
        {
            var orderItem = new OrderItem(1, DateTime.Now, new List<int> { 1 });
            orders.createOrder(orderItem);

            var expected = 1;

            var count = orders.getOrderCount();

            Assert.AreEqual(expected, count);
        }

    }
}