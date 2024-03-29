using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_visma.TestsGenerated
{
    /// <summary>This class contains parameterized unit tests for MenuItem</summary>
    [TestClass]
    [PexClass(typeof(MenuItem))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MenuItemTest
    {

        /// <summary>Test stub for .ctor(Int32, String, List`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public MenuItem ConstructorTest(
            int id,
            string name,
            List<int> products
        )
        {
            MenuItem target = new MenuItem(id, name, products);
            return target;
            // TODO: add assertions to method MenuItemTest.ConstructorTest(Int32, String, List`1<Int32>)
        }
    }
}
