namespace Project.Models
{
  public class Parcel
  {
    public int Weigth { get; set; }
    public int Width { get; set; }
    public int Heigth { get; set; }
    public int Length { get; set; }

    public Parcel(int weigth, int width, int heigth, int length)
    {
      Weigth = weigth;
      Heigth = heigth;
      Width = width;
      Length = length;

    }

    public int Volume()
    {
      return Width * Length * Heigth;
    }

    public int CostToShip()
    {
      int weigth = Weigth;
      int volume = Volume();
      int cost = Weigth * (volume / 10);
      return cost;
    }
  
  }
}