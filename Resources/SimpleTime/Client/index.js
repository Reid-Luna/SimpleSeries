onNet("ST:SyncTime", (h, m, s) => {
  hours = Number(h);
  minutes = Number(m);
  seconds = Number(s);
  NetworkOverrideClockTime(hours, minutes, seconds);
});
