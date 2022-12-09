using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod]
    public void GetInput_ItStoresUserInputAsProperty_Int()
    {
      int userInput = 5;
      Bread newBread = new Bread(userInput);
      Assert.AreEqual(userInput, newBread.Quantity);
    }

    [TestMethod]
    public void GetBreadPrice_ItReturnsTotalBreadPrice_Int()
    {
      int userInput = 5;
      Bread newBread = new Bread(userInput);
      Assert.AreEqual(userInput, newBread.BreadTotal);
    }

    [TestMethod]
    public void BreadCalc_ItWillCalculateTotalBreadrice_Int()
    {
      int userInput = 5;
      Bread newBread = new Bread(userInput);
      Assert.AreEqual(25, newBread.BreadCalc());
    }
  }
}