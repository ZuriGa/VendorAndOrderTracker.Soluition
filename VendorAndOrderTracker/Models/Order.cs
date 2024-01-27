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
      public Order(string title, string description, int price)
      {
        Title = title;
        Description = description;
        Price = price;
        DatePlaced = DateTime.Now;
      }
    }
  }