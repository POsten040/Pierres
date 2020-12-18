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
    [TestMethod]
    public void Vendor_AddsIdToNewVendorObjects_void()
    {
      Vendor newVendor = new Vendor("name", "description");
      int Id = 1;
      Assert.AreEqual(newVendor.Id, Id);
    }
    [TestMethod]
    public void Find_SearchesForSpecificVendor_void()
    {
      Vendor vendorOne = new Vendor("name", "description");
      Vendor vendorTwo = new Vendor("name2", "description2");
      int Id = 2;
      Vendor result = Vendor.Find(Id);
      Assert.AreEqual(vendorTwo, result);
    }
  }
}