namespace PierresBakery
{
  public class Pastry
  {
    public int Quantity { get;}

    public int PastryTotal { get; }

     public Pastry (int userInput)
    {
      Quantity = userInput;
      PastryTotal = Quantity;
    }

    public int PastryCalc()
    {
      int singlePrice = 2;      
      int totalPrice = singlePrice * Quantity;
      if (Quantity == 3)
      {
        totalPrice = 5;
      }
     
      return totalPrice;
    }

    
  }
}