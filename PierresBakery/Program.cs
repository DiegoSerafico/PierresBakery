using System;
using System.Collections.Generic;
using PierresBakery;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine(
        "The Prices are:\n" + 
        "Bread: $5\n" + 
        "Pastry: $2\n" + 
        "\n" +
        "Current Discounts:\n" + 
        "Buy two get one free on bread.\n" + 
        "Buy two get one half off on pastries.\n"
      );
      Console.WriteLine("Would you like to make an order?");
      string willOrder = Console.ReadLine();
      Bread bread = new Bread();
      Pastry pastry = new Pastry();
      float breadTotal = 0;
      float pastryTotal = 0;
      int breadAmount = 0;
      int pastryAmount = 0;
      while (willOrder.ToLower() == "yes")
      {
        Console.WriteLine("How many loaves of bread would you like?");
        breadAmount += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many pastries would you like?");
        pastryAmount += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Would you like to add to your order?");
        willOrder = Console.ReadLine();
      }
      breadTotal += bread.Order(breadAmount);
      pastryTotal += pastry.Order(pastryAmount);
      float orderTotal = breadTotal + pastryTotal;
      Console.WriteLine(
        "Bread Total: $" + breadTotal + "\n" + 
        "Pastry Total: $" + pastryTotal + "\n" + 
        "Order Total: $" + orderTotal + "\n"
      );
      Console.WriteLine("Thank you for shopping at Pierre's Bakery. Have a wonderful day!");
    }
  }
}