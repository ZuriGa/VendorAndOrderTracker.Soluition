using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public DateTime DatePlaced { get; }
    public int Id  { get; }
    private static List<Order> _orders = new List<Order> { };
    public Order(string title, string description, int price)
    {
      Title = title;
      Description = description;
      Price = price;
      DatePlaced = DateTime.Now;
      _orders.Add(this);
      Id = _orders.Count;
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }
    public static void ClearAll()
    {
      _orders.Clear();
    }

  }
}