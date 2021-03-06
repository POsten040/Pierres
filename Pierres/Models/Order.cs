using System.Collections.Generic;

namespace Pierres.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int Id)
    {
      return _instances[Id-1];
    }
    public void Remove()
    {
      _instances.Remove(this);
    }
  }
}
