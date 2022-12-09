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
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    
    [TestMethod]
    public void GetInput_ItStoreUserInputAsProperty_Int()
    {
      int userInput = 5;
      Bread newBread = new Bread(userInput);
      Assert.AreEqual(userInput, newBread.Quantity());
    }
  }
}