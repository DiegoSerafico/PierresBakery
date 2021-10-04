namespace PierresBakery
{
  public class Pastry
  {
    public static float Price { get; set; } = 2;
    public static float Discount { get; } = 0.5F;

    public float Order(int amount)
    {
      float total = (float) amount * Pastry.Price;
      for (int count = 1; count <= amount; count++)
      {
        if (count % 3 == 0)
        {
          total -= Pastry.Price * Pastry.Discount;
        }
      }
      return total;
    }
  }
}