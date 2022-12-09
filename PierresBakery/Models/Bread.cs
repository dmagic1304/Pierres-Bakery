namespace PierresBakery
{
  public class Bread
  {
    public int Quantity { get;}
    public int BreadTotal { get;}

    public Bread (int userInput)
    {
      Quantity = userInput;
      BreadTotal = Quantity;
    }

    public int BreadCalc()
    {
      int loafPrice = 5;
      int totalPrice = loafPrice * Quantity;
      return totalPrice;
    }

   
  }
}