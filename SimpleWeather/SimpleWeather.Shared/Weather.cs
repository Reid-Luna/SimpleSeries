using System.Collections.Generic;

namespace SimpleWeather.Shared
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

    public static Dictionary<string, string> Dictionary = new Dictionary<string, string>
    {
      { "CLEAR", "CLEAR" },
      { "EXTRASUNNY", "EXTRASUNNY" },
      { "CLOUDS", "CLOUDS" },
      { "OVERCAST", "OVERCAST" },
      { "RAIN", "RAIN" },
      { "CLEARING", "CLEARING" },
      { "THUNDER", "THUNDER" },
      { "SMOG", "SMOG" },
      { "FOGGY", "FOGGY" },
      { "XMAS", "XMAS" },
      { "SNOWLIGHT", "SNOWLIGHT" },
      { "BLIZZARD", "BLIZZARD" }
    };

    public static string[] SendToClient(Dictionary<string, string> Current)
    {
      string[] Return = new string[Current.Count];
      int count = 0;
      foreach (KeyValuePair<string, string> Zone in Current)
      {
        Return[count] = $"{Zone.Key}:{Zone.Value}";
        count++;
      }
      return Return;
    }

    public static Dictionary<string, string> ConvertToClient(List<object> Current)
    {
      Dictionary<string, string> Return = new Dictionary<string, string> { };
      foreach (string _zone in Current)
      {
        string ZONE = _zone.Split(':')[0];
        string WEATHER = _zone.Split(':')[1];
        if (Return.ContainsKey(ZONE))
        {
          Return[ZONE] = WEATHER;
        }
        else Return.Add(ZONE, WEATHER);
      }
      return Return;
    }
  }
}
