using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Order_GetOrderPrice_10()
    {
      Bread bread = new Bread();
      float result = bread.Order(2);
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void Order_GetOrderPrice_20()
    {
      Bread bread = new Bread();
      float result = bread.Order(6);
      Assert.AreEqual(20, result);
    }
  }
}