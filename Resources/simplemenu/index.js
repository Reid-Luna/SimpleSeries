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
});

RegisterNuiCallbackType("Login");
on("__cfx_nui:Login", (data, cb) => {
  const password = data["password"];
  cb(password == "Parker00");
});

RegisterNuiCallbackType("ChangeTime");
on("__cfx_nui:ChangeTime", (data, cb) => {
  let { hours, minutes, seconds } = data;
  if (!hours) hours = 0;
  if (!minutes) minutes = 0;
  if (!seconds) seconds = 0;
  emitNet("ST:SetTime", hours, minutes, seconds);
  cb(true);
});

RegisterNuiCallbackType("Freeze");
on("__cfx_nui:Freeze", data => {
  emitNet("ST:FreezeTime");
});

onNet("SW:ClientUpdateSuccess", () => {
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

onNet("ST:SyncTime", (h, m, s, frozen) => {
  SendNuiMessage(
    JSON.stringify({
      type: "time",
      time: [h, m, s],
      frozen
    })
  );
});

setTick(() => {
  if (IsControlJustReleased(0, 168)) {
    enabled = true;
    EnableMenu(enabled);
  }
});
