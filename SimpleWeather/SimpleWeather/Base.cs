using CitizenFX.Core;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace SimpleWeather
{
  public class Base : BaseScript
  {
    WeatherDB DB;
    public Base()
    {
      DB = new WeatherDB();
      EventHandlers.Add("SW:ClientChangeWeather", new Action<string>(ClientChangeWeather));
      Tick += onTick;
    }

    public void ClientChangeWeather(string json)
    {
      DB.FromClient(json);
      TriggerClientEvent("SW:ClientUpdateSuccess");
      Debug.WriteLine("[SimpleWeather]: Recieved New Weather");
    }

    public async Task onTick()
    {
      TriggerClientEvent("SW:SetWeather", DB.SendToClient());
      await Delay(5000);
    }
  }
}
