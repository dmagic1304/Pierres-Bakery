namespace PierresBakery
{
  public class Bread
  {
    public int Quantity { get;}
    public int BreadTotal { get;}

    public Bread (int userInput)
    {
      Quantity = userInput;
      BreadTotal = BreadCalc();
    }

    public int BreadCalc()
    {
      int loafPrice = 5;
      int promotionCount = Quantity / 3;
      int totalPrice = (loafPrice * Quantity) - (loafPrice * promotionCount);
     
      return totalPrice;
    }

   
  }
}