using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;
using System;


namespace Pierres.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("vendors/{Id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
    [HttpPost("vendors/{Id}/orders/new")]
    public ActionResult Show(int Id, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      Dictionary<string, object> model = new Dictionary<string, object>();
			Vendor selectedVendor = Vendor.Find(Id);
      selectedVendor.AddOrder(newOrder);
			List<Order> orderList = selectedVendor.Orders;
			model.Add("vendor", selectedVendor);
			model.Add("orders", orderList);
			return View(model);
    }
  }
}