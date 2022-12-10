using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    static void Main()
    {
      
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\n Welcome to Pierre's Bakery!!\n*****************************\n");
      Console.ResetColor();
      Console.WriteLine("Here is our offer for today:");
      Console.WriteLine("--------------------------------------------------------------------------");
      Console.WriteLine(">> Fresh bread for only $5 per loaf with a special offer of BUY 2 GET 1 FREE!!");
      Console.WriteLine(">> Tasty Pastry at $2 for one with special price of 5$ FOR 3!!");
      Console.WriteLine("--------------------------------------------------------------------------");

      Console.WriteLine("How many loafs of bread would you like to buy?");
      int breadQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("And how many pastries can I get for you?");
      int pastryQuantity = int.Parse(Console.ReadLine());

      Bread breadSelection = new Bread(breadQuantity);
      Pastry pastrySelection = new Pastry(pastryQuantity);

      int totalCost = breadSelection.BreadTotal + pastrySelection.PastryTotal;
      Console.WriteLine("Thank you for your purchase!");
      Console.WriteLine("The total cost is going to be ${0} dollars.", totalCost);

    }
  }
}