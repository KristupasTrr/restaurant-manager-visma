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
    public partial class MenuTest
    {

[TestMethod]
[PexGeneratedBy(typeof(MenuTest))]
public void getMenuListItemTest126()
{
    Menu menu;
    MenuItem menuItem;
    menu = new Menu();
    menuItem = this.getMenuListItemTest(menu, 0);
    Assert.IsNull((object)menuItem);
    Assert.IsNotNull((object)menu);
}
    }
}
