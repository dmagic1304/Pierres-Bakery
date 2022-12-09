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
  }
}