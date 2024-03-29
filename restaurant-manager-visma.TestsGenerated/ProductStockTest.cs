using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_visma.TestsGenerated
{
    /// <summary>This class contains parameterized unit tests for ProductStock</summary>
    [TestClass]
    [PexClass(typeof(ProductStock))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ProductStockTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public ProductStock ConstructorTest()
        {
            ProductStock target = new ProductStock();
            return target;
            // TODO: add assertions to method ProductStockTest.ConstructorTest()
        }

        /// <summary>Test stub for addToStock(Product)</summary>
        [PexMethod]
        public void addToStockTest([PexAssumeUnderTest] ProductStock target, Product product)
        {
            target.addToStock(product);
            // TODO: add assertions to method ProductStockTest.addToStockTest(ProductStock, Product)
        }

        /// <summary>Test stub for deductStock(Int32)</summary>
        [PexMethod]
        public void deductStockTest([PexAssumeUnderTest] ProductStock target, int id)
        {
            target.deductStock(id);
            // TODO: add assertions to method ProductStockTest.deductStockTest(ProductStock, Int32)
        }

        /// <summary>Test stub for getDataFromFile(String)</summary>
        [PexMethod]
        public void getDataFromFileTest([PexAssumeUnderTest] ProductStock target, string stockFile)
        {
            target.getDataFromFile(stockFile);
            // TODO: add assertions to method ProductStockTest.getDataFromFileTest(ProductStock, String)
        }

        /// <summary>Test stub for getStock(Int32)</summary>
        [PexMethod]
        public int getStockTest([PexAssumeUnderTest] ProductStock target, int id)
        {
            int result = target.getStock(id);
            return result;
            // TODO: add assertions to method ProductStockTest.getStockTest(ProductStock, Int32)
        }

        /// <summary>Test stub for isAvailable(Int32)</summary>
        [PexMethod]
        public bool isAvailableTest([PexAssumeUnderTest] ProductStock target, int id)
        {
            bool result = target.isAvailable(id);
            return result;
            // TODO: add assertions to method ProductStockTest.isAvailableTest(ProductStock, Int32)
        }

        /// <summary>Test stub for newID()</summary>
        [PexMethod]
        public int newIDTest([PexAssumeUnderTest] ProductStock target)
        {
            int result = target.newID();
            return result;
            // TODO: add assertions to method ProductStockTest.newIDTest(ProductStock)
        }

        /// <summary>Test stub for printStock()</summary>
        [PexMethod]
        public void printStockTest([PexAssumeUnderTest] ProductStock target)
        {
            target.printStock();
            // TODO: add assertions to method ProductStockTest.printStockTest(ProductStock)
        }

        /// <summary>Test stub for removeStock(Int32)</summary>
        [PexMethod]
        public void removeStockTest([PexAssumeUnderTest] ProductStock target, int id)
        {
            target.removeStock(id);
            // TODO: add assertions to method ProductStockTest.removeStockTest(ProductStock, Int32)
        }

        /// <summary>Test stub for updateDataFile(String)</summary>
        [PexMethod]
        public void updateDataFileTest([PexAssumeUnderTest] ProductStock target, string stockFile)
        {
            target.updateDataFile(stockFile);
            // TODO: add assertions to method ProductStockTest.updateDataFileTest(ProductStock, String)
        }

        /// <summary>Test stub for updateStock(Int32, Int32)</summary>
        [PexMethod]
        public void updateStockTest(
            [PexAssumeUnderTest] ProductStock target,
            int id,
            int newStock
        )
        {
            target.updateStock(id, newStock);
            // TODO: add assertions to method ProductStockTest.updateStockTest(ProductStock, Int32, Int32)
        }
    }
}
