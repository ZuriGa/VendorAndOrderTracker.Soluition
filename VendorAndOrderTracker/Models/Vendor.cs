  using System.Collections.Generic;

  namespace VendorAndOrderTracker.Models
  {
    public class Vendor
    {
      public string Name { get; set; }

      public Vendor(string VendorName, string VendorDescription)
      {
        Name = VendorName;
        Description = VendorDescription;

      }
      
      public string Description { get; }
    }
  }