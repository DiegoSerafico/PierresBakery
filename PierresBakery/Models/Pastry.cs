namespace PierresBakery
{
  public class Pastry
  {
    public float Price = 2;
    public float Discount = 0.5F;

    public float Order(int amount)
    {
      float total = (float) amount * 10;
      return total;
    }
  }
}