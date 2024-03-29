using CsvHelper.Configuration;
using CsvHelper;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;

namespace restaurant_manager_visma.TestsGenerated
{
    /// <summary>This class contains parameterized unit tests for ToIntArrayConverter</summary>
    [TestClass]
    [PexClass(typeof(ToIntArrayConverter))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ToIntArrayConverterTest
    {

        /// <summary>Test stub for ConvertFromString(String, IReaderRow, MemberMapData)</summary>
        [PexMethod]
        public object ConvertFromStringTest(
            [PexAssumeUnderTest] ToIntArrayConverter target,
            string text,
            IReaderRow row,
            MemberMapData memberMapData
        )
        {
            object result = target.ConvertFromString(text, row, memberMapData);
            return result;
            // TODO: add assertions to method ToIntArrayConverterTest.ConvertFromStringTest(ToIntArrayConverter, String, IReaderRow, MemberMapData)
        }

        /// <summary>Test stub for ConvertToString(Object, IWriterRow, MemberMapData)</summary>
        [PexMethod]
        public string ConvertToStringTest(
            [PexAssumeUnderTest] ToIntArrayConverter target,
            object value,
            IWriterRow row,
            MemberMapData memberMapData
        )
        {
            string result = target.ConvertToString(value, row, memberMapData);
            return result;
            // TODO: add assertions to method ToIntArrayConverterTest.ConvertToStringTest(ToIntArrayConverter, Object, IWriterRow, MemberMapData)
        }
    }
}
