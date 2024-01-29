using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorController : Controller
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

    [HttpPost("/vendors/new")]
    public ActionResult CreateVendor(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }


    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor selectedVendor = Vendor.Find(id);
      if (selectedVendor == null)
      {
        return RedirectToAction("Index");
      }
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", selectedVendor);
      model.Add("orders", selectedVendor.Orders);
      return View("Show", model);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult ShowOrders(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("vendor", vendor);
      model.Add("orders", vendor.Orders);
      return View("~/Views/Orders/Show.cshtml", vendor);
    }
  }
}
