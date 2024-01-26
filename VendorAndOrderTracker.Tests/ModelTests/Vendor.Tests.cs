using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Test
{
  [TestClass]
  public class VendorTests 
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Test Name","Description of Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Name";
      Vendor newVendor = new Vendor("Test Name","Description of Vendor");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Description of Vendor";
      Vendor newVendor = new Vendor("Test Name", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_ReturnsSetDescription_String()
    {
      string description = "Description of Vendor";
      Vendor newVendor = new Vendor("Test Name", description);
      newVendor.Description = description;
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
  }
}