using System.Collections.Generic;
using Newtonsoft.Json;

namespace SimpleWeather
{
  public class Weather
  {
    public static string CLEAR = "CLEAR";
    public static string EXTRASUNNY = "EXTRASUNNY";
    public static string CLOUDS = "CLOUDS";
    public static string OVERCAST = "OVERCAST";
    public static string RAIN = "RAIN";
    public static string CLEARING = "CLEARING";
    public static string THUNDER = "THUNDER";
    public static string SMOG = "SMOG";
    public static string FOGGY = "FOGGY";
    public static string XMAS = "XMAS";
    public static string SNOWLIGHT = "SNOWLIGHT";
    public static string BLIZZARD = "BLIZZARD";
  }
  public class WeatherDB
  {
    private Dictionary<string, string> Current = new Dictionary<string, string>
    {

    };

    public WeatherDB()
    {
      foreach (KeyValuePair<string, string> Zone in Areas.Zones)
      {
        Current.Add(Zone.Key, Weather.CLEAR);
      }
    }

    public string SendToClient()
    {
      return JsonConvert.SerializeObject(Current);
    }

    public void FromClient(string _zones)
    {
      Current = JsonConvert.DeserializeObject<Dictionary<string, string>>(_zones);
    }
  }
}
