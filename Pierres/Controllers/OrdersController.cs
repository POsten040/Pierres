using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;

namespace Pierres.Controllers
{
  public class OrdersController : Controller
  {
    [HttpPost("vendors/{Id}/orders")]
    public ActionResult Create(string title, string description, int price, string date)
    {
      Order newOrder = new Order(title, description, price, date);
      return RedirectToAction("Index");
    }
    [HttpGet("vendors/{Id}/orders/new")]
    public ActionResult Index(int Id)
    {
      Vendor vendor = Vendor.Find(Id);
      return View(vendor);
    }
  }
}