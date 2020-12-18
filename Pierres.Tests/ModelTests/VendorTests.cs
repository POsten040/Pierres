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
      string name = "vendorName";
      string description = "vendorDescription";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(newVendor.Name, "wrong name");
      Assert.AreEqual(newVendor.Description, " wrong Description");
    }
  }
}