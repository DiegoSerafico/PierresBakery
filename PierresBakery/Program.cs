using System;
using System.Collections.Generic;
using PierresBakery;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Perrie's Bakery");
      Console.WriteLine(
        "The Prices are:\n" + 
        "Bread: $5\n" + 
        "Pastry: $2\n" + 
        "\n" +
        "Current Discounts:\n" + 
        "Buy two get one free on bread.\n" + 
        "Buy 2 get one half off on pastries.\n"
      );
      Console.WriteLine("Would you like to make an order?");
      string willOrder = Console.ReadLine();
      if (willOrder.ToLower() == "yes")
      {
        Bread bread = new Bread();
        Pastry pastry = new Pastry();
        Console.WriteLine("How many loaves of bread would you like?");
        int breadAmount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many pastries would you like?");
        int pastryAmount = Convert.ToInt32(Console.ReadLine());
        float breadTotal = bread.Order(breadAmount);
        float pastryTotal = pastry.Order(pastryAmount);
        float orderTotal = breadTotal + pastryTotal;
        Console.WriteLine(
          "Bread Total: $" + breadTotal + "\n" + 
          "Pastry Total: $" + pastryTotal + "\n" + 
          "Order Total: $" + orderTotal 
          );
      }
    }
  }
}