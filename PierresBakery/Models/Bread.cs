using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public static float Price { get; set; } = 5;
    public static float Discount { get; } = 1;

    public float Order(int amount)
    {
      float total = (float) amount * Bread.Price;
      for (int count = 1; count <= amount; count++)
      {
        if (count % 3 == 0)
        {
          total -= Bread.Price * Bread.Discount;
        }
      }
      return total;
    }
  }
}