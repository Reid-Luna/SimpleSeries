using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CitizenFX.Core;
using SimpleWeather.Shared;
using static CitizenFX.Core.Native.API;

namespace SimpleWeather.Depreciated.Server
{
  /*
  public class Server
  {
    public string ActiveWeather = Weather.BLIZZARD;
    public int[] Time = new int[3];
    public bool ControlTime = false;
    public Server()
    {
      RegisterCommand("SetWeather", new Action<int, List<object>, string>(SetWeather), true);
      RegisterCommand("SetTime", new Action<int, List<object>, string>(SetTime), true);
      RegisterCommand("ResetTime", new Action(ResetTime), true);
      Tick += onTick;
    }

    public void SetWeather(int source, List<object> args, string raw)
    {
      string newWeather = args[0].ToString();
      if (Weather.Dictionary.ContainsKey(newWeather)) { ActiveWeather = Weather.Dictionary[newWeather]; Debug.WriteLine($"Setting Weather as {newWeather}"); }
      else Debug.WriteLine($"{newWeather} is not a weather type.");
    }

    public void ResetTime()
    {
      ControlTime = false;
    }

    public void SetTime(int source, List<object> args, string raw)
    {
      int Hours;
      int Minutes;
      int Seconds;
      string _Hours = args[0].ToString();
      string _Minutes = args[1].ToString();
      string _Seconds = args[2].ToString();

      if (!int.TryParse(_Hours, out Hours)) { Debug.WriteLine($"Hours must be a number. got {_Hours}"); return; }
      if (!int.TryParse(_Minutes, out Minutes)) { Debug.WriteLine($"Minutes must be a number. got {_Minutes}"); return; }
      if (!int.TryParse(_Seconds, out Seconds)) { Debug.WriteLine($"Seconds must be a number. got {_Seconds}"); return; }

      Time = new int[] { Hours, Minutes, Seconds };
      ControlTime = true;
      Debug.WriteLine($"Setting Time to {Hours}:{Minutes}:{Seconds}");
    }

    public async Task onTick()
    {
      TriggerClientEvent(Events.SYNCWEATHER, ActiveWeather);
      if (ControlTime) TriggerClientEvent(Events.SYNCTIME, new object[] { Time });
      await Delay(10000);
    }
  }
  */
}
