using System.Collections.Generic;

namespace PlacesYouHaveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Length { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { };

    public Place(string cityName, int length)
    {
      CityName = cityName; //where they stayed 
      Length = length; //length of stay in days 
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}