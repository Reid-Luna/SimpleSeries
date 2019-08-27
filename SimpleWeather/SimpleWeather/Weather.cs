using System;
using System.Collections.Generic;
using SimpleWeather.Shared;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleWeather
{
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

    public string[] SendToClient()
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

    public string SendToAPI()
    {
      string Return = "[";
      foreach (KeyValuePair<string, string> Zone in Current)
      {
        Return += $"\"{Zone.Key}:{Zone.Value}\",";
      }
      Return = Return.TrimEnd(',');
      Return += "]";
      return Return;
    }

    public bool FromAPI(string Incoming)
    {
      string[] newWeather = Incoming.Split(',');
      foreach (string weather in newWeather)
      {
        string[] _splitWeather = weather.Split(':');
        string ZONE = _splitWeather[0];
        string WEATHER = _splitWeather[1];
        Current[ZONE] = WEATHER;
      }
      return true;
    }
  }
}
