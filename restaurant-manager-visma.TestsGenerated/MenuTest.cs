using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_visma.TestsGenerated
{
    /// <summary>This class contains parameterized unit tests for Menu</summary>
    [TestClass]
    [PexClass(typeof(Menu))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MenuTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Menu ConstructorTest()
        {
            Menu target = new Menu();
            return target;
            // TODO: add assertions to method MenuTest.ConstructorTest()
        }

        /// <summary>Test stub for addMenuItem(MenuItem)</summary>
        [PexMethod]
        public void addMenuItemTest([PexAssumeUnderTest] Menu target, MenuItem item)
        {
            target.addMenuItem(item);
            // TODO: add assertions to method MenuTest.addMenuItemTest(Menu, MenuItem)
        }

        /// <summary>Test stub for getDataFromFile(String)</summary>
        [PexMethod]
        public void getDataFromFileTest([PexAssumeUnderTest] Menu target, string menuFile)
        {
            target.getDataFromFile(menuFile);
            // TODO: add assertions to method MenuTest.getDataFromFileTest(Menu, String)
        }

        /// <summary>Test stub for getMenuListItem(Int32)</summary>
        [PexMethod]
        public MenuItem getMenuListItemTest([PexAssumeUnderTest] Menu target, int id)
        {
            MenuItem result = target.getMenuListItem(id);
            return result;
            // TODO: add assertions to method MenuTest.getMenuListItemTest(Menu, Int32)
        }

        /// <summary>Test stub for isAvailable(Int32)</summary>
        [PexMethod]
        public bool isAvailableTest([PexAssumeUnderTest] Menu target, int id)
        {
            bool result = target.isAvailable(id);
            return result;
            // TODO: add assertions to method MenuTest.isAvailableTest(Menu, Int32)
        }

        /// <summary>Test stub for newID()</summary>
        [PexMethod]
        public int newIDTest([PexAssumeUnderTest] Menu target)
        {
            int result = target.newID();
            return result;
            // TODO: add assertions to method MenuTest.newIDTest(Menu)
        }

        /// <summary>Test stub for printMenu()</summary>
        [PexMethod]
        public void printMenuTest([PexAssumeUnderTest] Menu target)
        {
            target.printMenu();
            // TODO: add assertions to method MenuTest.printMenuTest(Menu)
        }

        /// <summary>Test stub for removeMenuItem(Int32)</summary>
        [PexMethod]
        public void removeMenuItemTest([PexAssumeUnderTest] Menu target, int id)
        {
            target.removeMenuItem(id);
            // TODO: add assertions to method MenuTest.removeMenuItemTest(Menu, Int32)
        }

        /// <summary>Test stub for updateDataFile(String)</summary>
        [PexMethod]
        public void updateDataFileTest([PexAssumeUnderTest] Menu target, string menuFile)
        {
            target.updateDataFile(menuFile);
            // TODO: add assertions to method MenuTest.updateDataFileTest(Menu, String)
        }

        /// <summary>Test stub for updateName(Int32, String)</summary>
        [PexMethod]
        public void updateNameTest(
            [PexAssumeUnderTest] Menu target,
            int id,
            string name
        )
        {
            target.updateName(id, name);
            // TODO: add assertions to method MenuTest.updateNameTest(Menu, Int32, String)
        }

        /// <summary>Test stub for updateProducts(Int32, List`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public void updateProductsTest(
            [PexAssumeUnderTest] Menu target,
            int id,
            List<int> products
        )
        {
            target.updateProducts(id, products);
            // TODO: add assertions to method MenuTest.updateProductsTest(Menu, Int32, List`1<Int32>)
        }
    }
}
