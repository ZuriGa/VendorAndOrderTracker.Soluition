using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Order title",  "Order description");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "Order title";
      Order newOrder = new Order(title,  "Order description");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string title = "Order title";
      Order newOrder = new Order(title,  "Order description");
      string updatedTitle = "New Order";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }
    
    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "Order description";
      Order newOrder = new Order("Order title", description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
  }
}