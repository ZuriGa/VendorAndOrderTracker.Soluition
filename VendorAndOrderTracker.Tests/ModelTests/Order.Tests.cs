using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
  
    [TestInitialize]
    public void Initialize()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Order title", "Order description", 5);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "Order title";
      Order newOrder = new Order(title, "Order description", 5);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string title = "Order title";
      Order newOrder = new Order(title, "Order description", 5);
      string updatedTitle = "New Order";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string description = "Order description";
      Order newOrder = new Order("Order title", description, 5);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetOrderDescription_ReturnsSetOrderDescription_String()
    {
      string description = "Order description";
      Order newOrder = new Order("Order title", description, 5);
      string updatedDescription = "New order description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      int price = 5;
      Order newOrder = new Order("Order title", "Order description", price);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetOrderPrice_ReturnOrderPrice_Int()
    {
      int price = 5;
      int updatedPrice = 10;
      Order newOrder = new Order("Order title", "Order description", price);
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_DateTime()
    {
      Order newOrder = new Order("Order title", "Order description", 5);
      DateTime expectedDate = DateTime.Now;
      DateTime actualDate = newOrder.DatePlaced;
      Assert.IsTrue((expectedDate - actualDate).Duration() < TimeSpan.FromSeconds(1));
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      string order1 = "order 1";
      string order2 = "order 2";
      Order newOrder1 = new Order(order1, "Order description", 5);
      Order newOrder2 = new Order(order2, "Order description", 10);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      Console.WriteLine($"Expected Count: {newList.Count}, Actual Count: {result.Count}");
      Console.WriteLine($"Expected Orders: {string.Join(", ", newList)}");
      Console.WriteLine($"Actual Orders: {string.Join(", ", result)}");

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      Order newOrder = new Order("Order title", "Order description", 5);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
  }
}