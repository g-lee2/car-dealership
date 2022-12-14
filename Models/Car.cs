namespace Dealership.Models {

  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public Car(string makeModel, int price, int miles)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
    }
    public double SalePrice()
    {
      return Price -= (int)(Price * 0.05); 
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like: " + sound;
    }
  }
}
