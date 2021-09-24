using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public float Price = 5;
    public float Discount = 1;

    public float Order(int amount)
    {
      float total = (float) amount * Price;
      for (int count = 1; count <= amount; count++)
      {
        if (count % 3 == 0)
        {
          total -= Price * Discount;
        }
      }
      return total;
    }
  }
}