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
      int result = bread.Order(2);
      Assert.AreEqual(10, result);
    }
  }
}