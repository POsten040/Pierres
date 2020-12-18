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
  }
}