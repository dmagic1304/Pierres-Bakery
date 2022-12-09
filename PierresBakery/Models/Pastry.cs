namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Quantity { get;}

    public int PastryTotal { get; }

     public Pastry (int userInput)
    {
      Quantity = userInput;
      PastryTotal = PastryCalc();
    }

    public int PastryCalc()
    {
      int singlePrice = 2;
      int comboPrice = 5;      
      int singlePricedN = Quantity % 3;
      int comboPricedN = Quantity / 3; 

      int totalPrice = (comboPricedN * comboPrice) + (singlePricedN * singlePrice);
     
      return totalPrice;
    }

    
  }
}