using simpleshoe.Interfaces;

namespace simpleshoe.Models
{
  public class Shoe : IShoe
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public string Id { get; set; }
  }
}