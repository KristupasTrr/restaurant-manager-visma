using System.IO;
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
    public partial class ManagerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ManagerTest))]
[PexRaisedException(typeof(IOException))]
public void productStockPageTestThrowsIOException379()
{
    Manager manager;
    manager = new Manager((string)null, (string)null, (string)null);
    this.productStockPageTest(manager);
}
    }
}
