using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

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
      int userInput = 1;
      Bread newBread = new Bread(userInput);
      Assert.AreEqual(5, newBread.BreadTotal);
    }

    [TestMethod]
    public void BreadCalc_ItWillCalculateTotalBreadPrice_Int()
    {
      int userInput = 2;
      Bread newBread = new Bread(userInput);
      Assert.AreEqual(10, newBread.BreadCalc());
    }

    [TestMethod]
    public void BreadCalc_ItWillNotCalculateThirdBread_Int()
    {
      int userInput = 3;
      Bread newBread = new Bread(userInput);
      Assert.AreEqual(10, newBread.BreadCalc());
    }

    [TestMethod]
    public void BreadCalc_ItWillNotCalculateEveryThirdBread_Int()
    {
      int userInput = 8;
      Bread newBread = new Bread(userInput);
      Assert.AreEqual(30, newBread.BreadCalc());
    }
  }
}