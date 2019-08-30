const SetWeather = Weather => {
  SetWeatherTypePersist(Weather);
  SetWeatherTypeNowPersist(Weather);
  SetWeatherTypeNow(Weather);
  SetOverrideWeather(Weather);
};

const Blackout = Blackout => {
  SetBlackout(Blackout);
};

const ParseWeather = FromServer => {
  Zones = JSON.parse(FromServer);
  const [X, Y, Z] = GetEntityCoords(GetPlayerPed(-1));
  const ZONE = GetNameOfZone(X, Y, Z);
  SetWeather(Zones[ZONE]);
};

onNet("SW:SetWeather", ParseWeather);
