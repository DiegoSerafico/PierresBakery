using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Order_GetOrderPrice_4()
    {
      Pastry pastry = new Pastry();
      float result = pastry.Order(2);
      Assert.AreEqual(4, result);
    }
  }
}