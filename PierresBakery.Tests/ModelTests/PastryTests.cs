using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry.Price = 2;
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void Order_GetOrderPrice_4()
    {
      Pastry.Price = 2;
      Pastry pastry = new Pastry();
      float result = pastry.Order(2);
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Order_GetOrderPrice_10()
    {
      Pastry.Price = 3;
      Pastry pastry = new Pastry();
      float result = pastry.Order(3);
      Assert.AreEqual(7.5, result);
    }
  }
}