namespace PierresBakery
{
  public class Pastry
  {
    public float Price = 2;
    public float Discount = 0.5F;

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