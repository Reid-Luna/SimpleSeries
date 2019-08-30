let enabled = false;
let zones = null;

const EnableMenu = enable => {
  SendNuiMessage(
    JSON.stringify({
      type: "enable",
      enabled: enable
    })
  );
  SetNuiFocus(enable, enable);
};

RegisterNuiCallbackType("ESCAPE");
on("__cfx_nui:ESCAPE", (data, cb) => {
  enabled = false;
  EnableMenu(enabled);
});

RegisterNuiCallbackType("ChangeWeather");
on("__cfx_nui:ChangeWeather", data => {
  emitNet("SW:ClientChangeWeather", JSON.stringify(data));
  // console.log("[SimpleWeather]: Sending Weather");
});

onNet("SW:ClientUpdateSuccess", () => {
  // console.log("[SimpleWeather]: Success");
  SendNuiMessage(
    JSON.stringify({
      type: "alert",
      success: true
    })
  );
});

onNet("SW:SetWeather", Zones => {
  zones = JSON.parse(Zones);
  SendNuiMessage(
    JSON.stringify({
      type: "zones",
      zones: Zones
    })
  );
});

setTick(() => {
  if (IsControlJustReleased(0, 168)) {
    enabled = true;
    EnableMenu(enabled);
  }
});
