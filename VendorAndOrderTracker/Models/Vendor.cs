  using System.Collections.Generic;
  using System;

  namespace VendorAndOrderTracker.Models
  {
    public class Vendor
    {
      public string Name { get; set; }

      public Vendor(string VendorName, string VendorDescription)
      {
        Name = VendorName;
        Description = VendorDescription;
        _instances.Add(this);
        Id = _instances.Count;

      }
      public string Description { get; set; }
      private static List<Vendor> _instances = new List<Vendor> { };

      public static List<Vendor> GetAll()
      {
        return _instances;
      }
      public static void ClearAll()
      {
        _instances.Clear();
      }
      public int Id { get; }
    }
  }