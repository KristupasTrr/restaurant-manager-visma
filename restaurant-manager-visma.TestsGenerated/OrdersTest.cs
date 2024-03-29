// <copyright file="OrdersTest.cs">Copyright ©  2021</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_visma.TestsGenerated
{
    /// <summary>This class contains parameterized unit tests for Orders</summary>
    [PexClass(typeof(Orders))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class OrdersTest
    {
        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Orders ConstructorTest()
        {
            Orders target = new Orders();
            return target;
            // TODO: add assertions to method OrdersTest.ConstructorTest()
        }

        /// <summary>Test stub for createOrder(OrderItem)</summary>
        [PexMethod]
        public void createOrderTest([PexAssumeUnderTest]Orders target, OrderItem order)
        {
            target.createOrder(order);
            // TODO: add assertions to method OrdersTest.createOrderTest(Orders, OrderItem)
        }

        /// <summary>Test stub for getDataFromFile(String)</summary>
        [PexMethod]
        public void getDataFromFileTest([PexAssumeUnderTest]Orders target, string orderFile)
        {
            target.getDataFromFile(orderFile);
            // TODO: add assertions to method OrdersTest.getDataFromFileTest(Orders, String)
        }

        /// <summary>Test stub for getOrderCount()</summary>
        [PexMethod]
        public int getOrderCountTest([PexAssumeUnderTest]Orders target)
        {
            int result = target.getOrderCount();
            return result;
            // TODO: add assertions to method OrdersTest.getOrderCountTest(Orders)
        }

        /// <summary>Test stub for newID()</summary>
        [PexMethod]
        public int newIDTest([PexAssumeUnderTest]Orders target)
        {
            int result = target.newID();
            return result;
            // TODO: add assertions to method OrdersTest.newIDTest(Orders)
        }

        /// <summary>Test stub for printOrders()</summary>
        [PexMethod]
        public void printOrdersTest([PexAssumeUnderTest]Orders target)
        {
            target.printOrders();
            // TODO: add assertions to method OrdersTest.printOrdersTest(Orders)
        }

        /// <summary>Test stub for updateDataFile(String)</summary>
        [PexMethod]
        public void updateDataFileTest([PexAssumeUnderTest]Orders target, string orderFile)
        {
            target.updateDataFile(orderFile);
            // TODO: add assertions to method OrdersTest.updateDataFileTest(Orders, String)
        }
    }
}
