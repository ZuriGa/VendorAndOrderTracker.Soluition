using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/neworder")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/vendors/{vendorId}/orders/new")]
    public ActionResult Create(int vendorId, string title, string description, int price)
    {
      Vendor vendor = Vendor.Find(vendorId);
      if (vendor != null)
      {
        Order newOrder = new Order(title, description, price);
        newOrder.DatePlaced = DateTime.Now;
        vendor.AddOrder(newOrder);
      }
      return RedirectToAction("Show", "Vendor", new { id = vendorId });
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View("~/Views/Orders/Show.cshtml", model);
    }
  }
}