using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restaurant_manager_visma;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace restaurant_manager_visma.TestsGenerated
{
    public partial class OrdersTest
    {

[TestMethod]
[PexGeneratedBy(typeof(OrdersTest))]
public void newIDTest278()
{
    Orders orders;
    int i;
    orders = new Orders();
    i = this.newIDTest(orders);
    Assert.AreEqual<int>(1, i);
    Assert.IsNotNull((object)orders);
}
    }
}
