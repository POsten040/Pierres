using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;

namespace Pierres.Controllers
{
  public class OrdersController : Controller
  {
    // [HttpPost("vendors/{Id}/orders")]
    // public ActionResult Create(string title, string description, int price, string date)
    // {
    //   Order newOrder = new Order(title, description, price, date);
    //   return RedirectToAction("Index");
    // }
    [HttpGet("vendors/{Id}/orders/new")]
    public ActionResult New(int Id)
    {
			Dictionary<string, object> model = new Dictionary<string, object>();
			Vendor selectedVendor = Vendor.Find(Id);
			List<Order> orderList = selectedVendor.Orders;
			model.Add("vendor", selectedVendor);
			model.Add("orders", orderList);
			return View(model);
    }
  }
}