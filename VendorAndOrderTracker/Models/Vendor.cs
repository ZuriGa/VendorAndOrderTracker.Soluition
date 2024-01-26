  using System.Collections.Generic;

  namespace VendorAndOrderTracker.Models
  {
    public class Vendor
    {
      public string Name { get; set; }

      public Vendor(string VendorName)
      {
        Name = VendorName;
        
      }
    }
  }