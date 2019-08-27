using System;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using System.Collections.Generic;

namespace SimpleWeather.Client
{
  public class Base : BaseScript
  {
    public Base()
    {
      EventHandlers.Add(Shared.Events.SYNCWEATHER, new Action<List<object>>(SyncWeather));
    }

    public void SyncWeather(List<object> IncomingWeather)
    {
      Dictionary<string, string> NewWeather = Shared.Weather.ConvertToClient(IncomingWeather);
      var PlayerLocation = Game.PlayerPed.Position;
      string Zone = GetNameOfZone(PlayerLocation.X, PlayerLocation.Y, PlayerLocation.Z);
      SetWeather(NewWeather[Zone]);
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
  };
}
