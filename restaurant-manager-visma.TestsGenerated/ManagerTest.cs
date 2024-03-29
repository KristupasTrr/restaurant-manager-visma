using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_visma.TestsGenerated
{
    /// <summary>This class contains parameterized unit tests for Manager</summary>
    [TestClass]
    [PexClass(typeof(Manager))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ManagerTest
    {

        /// <summary>Test stub for .ctor(String, String, String)</summary>
        [PexMethod]
        internal Manager ConstructorTest(
            string productStockFile,
            string menuFile,
            string ordersFile
        )
        {
            Manager target = new Manager(productStockFile, menuFile, ordersFile);
            return target;
            // TODO: add assertions to method ManagerTest.ConstructorTest(String, String, String)
        }

        /// <summary>Test stub for createMenuItemPage()</summary>
        [PexMethod]
        internal void createMenuItemPageTest([PexAssumeUnderTest] Manager target)
        {
            target.createMenuItemPage();
            // TODO: add assertions to method ManagerTest.createMenuItemPageTest(Manager)
        }

        /// <summary>Test stub for createOrderPage()</summary>
        [PexMethod]
        internal void createOrderPageTest([PexAssumeUnderTest] Manager target)
        {
            target.createOrderPage();
            // TODO: add assertions to method ManagerTest.createOrderPageTest(Manager)
        }

        /// <summary>Test stub for createProductPage()</summary>
        [PexMethod]
        internal void createProductPageTest([PexAssumeUnderTest] Manager target)
        {
            target.createProductPage();
            // TODO: add assertions to method ManagerTest.createProductPageTest(Manager)
        }

        /// <summary>Test stub for getInputNumber()</summary>
        [PexMethod]
        internal int getInputNumberTest([PexAssumeUnderTest] Manager target)
        {
            int result = target.getInputNumber();
            return result;
            // TODO: add assertions to method ManagerTest.getInputNumberTest(Manager)
        }

        /// <summary>Test stub for mainPage()</summary>
        [PexMethod]
        internal void mainPageTest([PexAssumeUnderTest] Manager target)
        {
            target.mainPage();
            // TODO: add assertions to method ManagerTest.mainPageTest(Manager)
        }

        /// <summary>Test stub for menuPage()</summary>
        [PexMethod]
        internal void menuPageTest([PexAssumeUnderTest] Manager target)
        {
            target.menuPage();
            // TODO: add assertions to method ManagerTest.menuPageTest(Manager)
        }

        /// <summary>Test stub for orderPage()</summary>
        [PexMethod]
        internal void orderPageTest([PexAssumeUnderTest] Manager target)
        {
            target.orderPage();
            // TODO: add assertions to method ManagerTest.orderPageTest(Manager)
        }

        /// <summary>Test stub for printMenuPage()</summary>
        [PexMethod]
        internal void printMenuPageTest([PexAssumeUnderTest] Manager target)
        {
            target.printMenuPage();
            // TODO: add assertions to method ManagerTest.printMenuPageTest(Manager)
        }

        /// <summary>Test stub for printOrdersPage()</summary>
        [PexMethod]
        internal void printOrdersPageTest([PexAssumeUnderTest] Manager target)
        {
            target.printOrdersPage();
            // TODO: add assertions to method ManagerTest.printOrdersPageTest(Manager)
        }

        /// <summary>Test stub for printStockPage()</summary>
        [PexMethod]
        internal void printStockPageTest([PexAssumeUnderTest] Manager target)
        {
            target.printStockPage();
            // TODO: add assertions to method ManagerTest.printStockPageTest(Manager)
        }

        /// <summary>Test stub for productStockPage()</summary>
        [PexMethod]
        internal void productStockPageTest([PexAssumeUnderTest] Manager target)
        {
            target.productStockPage();
            // TODO: add assertions to method ManagerTest.productStockPageTest(Manager)
        }

        /// <summary>Test stub for removeMenuItemPage()</summary>
        [PexMethod]
        internal void removeMenuItemPageTest([PexAssumeUnderTest] Manager target)
        {
            target.removeMenuItemPage();
            // TODO: add assertions to method ManagerTest.removeMenuItemPageTest(Manager)
        }

        /// <summary>Test stub for removeStockPage()</summary>
        [PexMethod]
        internal void removeStockPageTest([PexAssumeUnderTest] Manager target)
        {
            target.removeStockPage();
            // TODO: add assertions to method ManagerTest.removeStockPageTest(Manager)
        }

        /// <summary>Test stub for updateMenuItemPage()</summary>
        [PexMethod]
        internal void updateMenuItemPageTest([PexAssumeUnderTest] Manager target)
        {
            target.updateMenuItemPage();
            // TODO: add assertions to method ManagerTest.updateMenuItemPageTest(Manager)
        }

        /// <summary>Test stub for updateStockPage()</summary>
        [PexMethod]
        internal void updateStockPageTest([PexAssumeUnderTest] Manager target)
        {
            target.updateStockPage();
            // TODO: add assertions to method ManagerTest.updateStockPageTest(Manager)
        }
    }
}
