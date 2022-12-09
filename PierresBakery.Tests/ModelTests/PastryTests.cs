using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
   public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetInput_ItStoresUserInputAsProperty_Int()
    {
      int userInput = 5;
      Pastry newPastry = new Pastry(userInput);
      Assert.AreEqual(userInput, newPastry.Quantity);
    }

    [TestMethod]
    public void GetPastryPrice_ItReturnsTotalPastryPrice_Int()
    {
      int userInput = 1;
      Pastry newPastry = new Pastry(userInput);
      Assert.AreEqual(3, newPastry.PastryTotal);
    }
  }
}