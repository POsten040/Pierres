using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;

namespace Pierres.Controllers
{
  public class OrdersController : Controller
  {
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