using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread();
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void Order_GetOrderPrice_10()
    {
      Bread.Price = 5;
      Bread bread = new Bread();
      float result = bread.Order(2);
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void Order_GetOrderPrice_20()
    {
      Bread.Price = 5;
      Bread bread = new Bread();
      float result = bread.Order(6);
      Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void Order_GetOrderPrice_12()
    {
      Bread.Price = 6;
      Bread bread = new Bread();
      float result = bread.Order(2);
      Assert.AreEqual(12, result);
    }
  }
}