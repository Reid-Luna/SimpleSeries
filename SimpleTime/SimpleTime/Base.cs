using CitizenFX.Core;
using System;
using System.Threading.Tasks;

namespace SimpleTime
{
  public class Base : BaseScript
  {
    TimeDB DB;
    public Base()
    {
      DB = new TimeDB();
      EventHandlers.Add("ST:SetTime", new Action<string, string, string>(DB.SetTime));
      EventHandlers.Add("ST:FreezeTime", new Action(DB.FreezeTime));
      Tick += onTick;
    }

    public async Task onTick()
    {
      await Delay(2000);
      DB.AddMinute();
      TriggerClientEvent("ST:SyncTime", DB.Hours, DB.Minutes, DB.Seconds, DB.Frozen);
    }
  }
}
