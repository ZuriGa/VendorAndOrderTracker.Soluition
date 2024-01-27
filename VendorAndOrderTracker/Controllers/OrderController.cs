using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
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
        vendor.AddOrder(newOrder);
      }
      return RedirectToAction("Show", "Vendor", new { vendorId });
    }

    [HttpGet("/vendors/{vendorId}/orders/{ordersId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      model.Add("orders", vendor.Orders);
      return View(model);
    }
  }
}