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
        "Buy 2 get one half off on pastries.\n" +
      );
      Console.WriteLine("Would you like to make an order?");
      string willOrder = Console.Readline();
      if (willOrder.ToLower() == "yes")
      {
        Bread bread = new Bread();
        Pastry pastry = new Pastry();
        Console.WriteLine("How Many Loaves of bread would you like?");
        int breadAmount = Console.Readline();
        Console.WriteLine("How many pastries would you like?");
        int pastryAmount = Console.Readline();
      }
    }
  }
}