using System;
using SimpleWeather.Shared;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using System.Collections.Generic;

namespace SimpleWeather.Depreciated.Client
{
  /*
  public class Client
  {
    public Client()
    {
      EventHandlers.Add(Events.SYNCWEATHER, new Action<string>(SyncWeather));
      EventHandlers.Add(Events.SYNCTIME, new Action<List<object>>(SyncTime));
    }

    public void SyncTime(List<object> _Time)
    {
      int[] Time = new int[3];
      for (int i = 0; i < _Time.Count; i++)
      {
        Time[i] = int.Parse(_Time[i].ToString());
      }
      SetClockTime(Time[0], Time[1], Time[2]);
      NetworkOverrideClockTime(Time[0], Time[1], Time[2]);
    }

    public void SyncWeather(string Weather)
    {
      SetWeather(Weather);
    }

    public async void SetWeather(string Weather)
    {
      ClearOverrideWeather();
      ClearWeatherTypePersist();
      SetWeatherTypeOverTime(Weather, 15.0f);
      await Delay(15000);
      SetWeatherTypePersist(Weather);
      SetWeatherTypeNow(Weather);
      SetWeatherTypeNowPersist(Weather);
    }
  }
  */
}
