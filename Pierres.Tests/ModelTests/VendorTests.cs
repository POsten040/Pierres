using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void Vendor_CreateInstanceOfVendorWithProperties_True()
    {
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(newVendor.Name, "name");
      Assert.AreEqual(newVendor.Description, "description");
    }
    [TestMethod]
    public void Vendor_CreatesEmptyListForOrders_void()
    {
      Vendor newVendor = new Vendor("name", "description");
      List<Order> orderList = new List<Order>{};
      CollectionAssert.AreEqual(orderList, newVendor.Orders);
    } 
  }
}