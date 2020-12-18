using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierres.Models;
using System.Collections.Generic;
using System;

namespace Pierres.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void Order_CreatesInstaceOfOrderWithProperties_void()
    {
      Order newOrder = new Order("title", "description", 1, "date");
      Assert.AreEqual("title", newOrder.Title);
      Assert.AreEqual("description", newOrder.Description);
      Assert.AreEqual(1, newOrder.Price);
      Assert.AreEqual("date", newOrder.Date);
    }
    [TestMethod]
    public void GetAll_ReturnsListOfAllOrders_void()
    {
      Order newOrder = new Order("name", "description", 1, "date");
      List<Order> orderList = new List<Order>{newOrder};
      CollectionAssert.AreEqual(orderList, Order.GetAll());
    }
    [TestMethod]
    public void Find_SearchesForSpecificOrder_void()
    {
      Order orderOne = new Order("name", "description", 1, "date");
      Order orderTwo = new Order("name2", "description2",1 , "date2");
      int Id = 2;
      Order result = Order.Find(Id);
      Assert.AreEqual(orderTwo, result);
    }
  }
}