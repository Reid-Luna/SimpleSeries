using System;

namespace SimpleTime
{
  class TimeDB
  {
    public bool Frozen = false;
    public int Hours = 00;
    public int Minutes = 00;
    public int Seconds = 00;
    public double secondOfDay = 0.0;
    public TimeDB()
    {
    }

    public void AddMinute()
    {
      secondOfDay = (Hours * 3600) + (Minutes * 60) + Seconds;
      if (!Frozen)
      {
        secondOfDay += 60;
        if (secondOfDay >= 86400)
        {
          secondOfDay %= 86400;
        }
      }

      Hours = (int)Math.Floor(secondOfDay / 3600.0);

      Minutes = (int)Math.Floor((secondOfDay - (Hours * 3600)) / 60);

      Seconds = (int)(secondOfDay - (Hours * 3600) - (Minutes * 60));

    }

    public void FreezeTime()
    {
      Frozen = !Frozen;
    }

    public void SetTime(string _Hours, string _Minutes, string _Seconds)
    {
      int _hours = int.Parse(_Hours);
      int _minutes = int.Parse(_Minutes);
      int _seconds = int.Parse(_Seconds);

      if (_hours > 24) _hours = 24;
      if (_minutes > 59) _minutes = 59;
      if (_seconds > 59) _seconds = 59;
      Hours = _hours;
      Minutes = _minutes;
      Seconds = _seconds;
    }
  }
}
