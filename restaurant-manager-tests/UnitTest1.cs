using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace restaurant_manager_tests
{
    [TestClass]
    public class UnitTest1
    {
        //private List<Product> itemsInStock;
        [TestInitialize]
        public void Initialize()
        {
            // your common setup code here
            //this.controller = ...
        }

        [TestMethod]
        public void TestMethod1()
        {
            var a = 2;
            var b = 3;
            var expected = 5;

            Assert.AreEqual(expected, a + b);
        }
    }
}
