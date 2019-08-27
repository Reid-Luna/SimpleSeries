using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleWeather.Shared;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace SimpleWeather.Server
{
  class Base : BaseScript
  {
    WeatherDB DB;
    public Base()
    {
      DB = new WeatherDB();

      EventHandlers.Add(Events.APIREQUESTZONES, new Action(SendZones));
      EventHandlers.Add(Events.UPDATEZONES, new Action<string>(UpdateZones));
      EventHandlers.Add(Events.SUCCESSFULUPDATE, new Action(SuccessfulUpdate));

      Tick += onTick;
    }

    public void SuccessfulUpdate()
    {
      Debug.WriteLine("[SimpleWeather]: Updated Weather");
    }

    public void UpdateZones(string Incoming)
    {
      bool updated = DB.FromAPI(Incoming);
      if (updated) TriggerEvent(Events.SUCCESSFULUPDATE);
    }

    public void SendZones()
    {
      TriggerEvent(Events.APIRECEIVEZONES, DB.SendToAPI());
    }

    public async Task onTick()
    {
      TriggerClientEvent(Events.SYNCWEATHER, new object[] { DB.SendToClient() });
      await Delay(10000);
    }
  }
}
