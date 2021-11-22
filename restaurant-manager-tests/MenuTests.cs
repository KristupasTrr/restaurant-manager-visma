using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_tests
{
    [TestClass()]
    public class MenuTests
    {
        private Menu menuItems;
        private Menu menuItemsEmpty;
        private ProductStock itemsInStock;
        [TestInitialize]
        public void Initialize()
        {
            itemsInStock = new ProductStock();
            menuItems = new Menu();
            menuItemsEmpty = new Menu();

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
            var id = menuItems.newID();
            var expected = 2;

            Assert.AreEqual(expected, id);
        }

        [TestMethod()]
        public void newID_WhenEmpty_Test()
        {
            var id = menuItemsEmpty.newID();
            var expected = 1;

            Assert.AreEqual(expected, id);
        }

        [TestMethod()]
        public void isAvailable_Available_Test()
        {
            var available = menuItems.isAvailable(1);

            Assert.IsTrue(available);
        }

        [TestMethod()]
        public void isAvailable_Unavailable_Test()
        {
            var available = menuItems.isAvailable(5);

            Assert.IsFalse(available);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 2 }, 2, true)]
        [DataRow(new int[] { 3, 6 }, 4, false)]
        [DataRow(new int[] { 1, 2, 3 }, 5, false)]
        public void addMenuItem_Valid_Test(int[] item_ids, int id, bool expected)
        {
            var testMenuItem = new MenuItem(2, "menuItem2", new List<int> (item_ids));
            menuItems.addMenuItem(testMenuItem);

            var available = menuItems.isAvailable(id);

            Assert.AreEqual(available, expected);
        }
        
        [TestMethod()]
        public void addMenuItem_Invalid_Test()
        {
            var testMenuItem = new MenuItem(2, "menuItem2", new List<int> { 1, 2 });
            menuItems.addMenuItem(testMenuItem);

            var available = menuItems.isAvailable(2);

            Assert.IsTrue(available);
        }

        [TestMethod()]
        public void removeMenuItemTest()
        {
            menuItems.removeMenuItem(1);
            var available = menuItems.isAvailable(1);
            Assert.IsFalse(available);
        }

        [TestMethod()]
        public void updateNameTest()
        {
            var newName = "rename";
            menuItems.updateName(1, newName);

            var item = menuItems.getMenuListItem(1);

            Assert.AreEqual(item.name, newName);
        }

        [TestMethod()]
        public void updateProductsTest()
        {
            var newProductsList = new List<int> { 1 };
            menuItems.updateProducts(1, newProductsList);

            var expected = menuItems.getMenuListItem(1);

            Assert.AreEqual(expected.products, newProductsList);
        }

        [TestMethod()]
        public void getMenuListItemTest()
        {
            var expected = new MenuItem(1, "menuItem1", new List<int> { 1, 2 });
            var item = menuItems.getMenuListItem(1);
            Assert.AreEqual(expected.id, item.id);
        }
    }
}