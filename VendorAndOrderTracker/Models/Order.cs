  using System.Collections.Generic;

  namespace VendorAndOrderTracker.Models
  {
    public class Order
    {
      public string Title { get; set; }
      public Order(string title)
      {
        Title = title;
      }
    }
  }