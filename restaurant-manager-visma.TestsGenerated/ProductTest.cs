using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_visma.TestsGenerated
{
    /// <summary>This class contains parameterized unit tests for Product</summary>
    [TestClass]
    [PexClass(typeof(Product))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProductTest
    {

        /// <summary>Test stub for .ctor(Int32, String, Int32, String, Double)</summary>
        [PexMethod]
        public Product ConstructorTest(
            int id,
            string name,
            int portionCount,
            string unit,
            double portionSize
        )
        {
            Product target = new Product(id, name, portionCount, unit, portionSize);
            return target;
            // TODO: add assertions to method ProductTest.ConstructorTest(Int32, String, Int32, String, Double)
        }
    }
}
