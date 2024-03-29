using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_visma.TestsGenerated
{
    /// <summary>This class contains parameterized unit tests for OrderItem</summary>
    [TestClass]
    [PexClass(typeof(OrderItem))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OrderItemTest
    {

        /// <summary>Test stub for .ctor(Int32, DateTime, List`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public OrderItem ConstructorTest(
            int id,
            DateTime date,
            List<int> menuItems
        )
        {
            OrderItem target = new OrderItem(id, date, menuItems);
            return target;
            // TODO: add assertions to method OrderItemTest.ConstructorTest(Int32, DateTime, List`1<Int32>)
        }
    }
}
