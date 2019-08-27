const express = require("express");
const app = express();

const cors = require("cors");
app.use(cors());

const bp = require("body-parser");
app.use(bp.json());
app.use(bp.urlencoded({ extended: false }));

let zones;
let updated = false;

on("SW:APIRecieveZones", Zones => {
  zones = Zones;
});

on("SW:SuccessfulUpdate", () => {
  updated = true;
});

app.get("/", (req, res) => {
  zones = null;
  let count = 0;
  TriggerEvent("SW:APIRequestZones");
  let interval = setInterval(() => {
    if (zones) {
      res.status(200).json(JSON.parse(zones));
      clearInterval(interval);
      return;
    } else if (count >= 3) {
      res.status(500).json({ error: "server didnt respond in time" });
      clearInterval(interval);
      return;
    }
    count++;
  }, 500);
});

app.post("/", (req, res) => {
  const { body } = req;
  let sendString = "";
  const { zones } = body;
  updated = false;
  let count = 0;

  zones.forEach(zone => {
    const [Name, Weather] = zone.split(":");
    sendString += `${Name}:${Weather},`;
  });

  sendString = sendString.substring(0, sendString.length - 1);
  TriggerEvent("SW:UpdateZones", sendString);

  let interval = setInterval(() => {
    if (updated) {
      res.status(200).json({ success: true });
      clearInterval(interval);
      return;
    } else if (count >= 3) {
      res.status(500).json({ error: "server didnt respond in time" });
      clearInterval(interval);
    }
    count++;
  }, 500);
});

app.listen(4000, () => {
  console.log("[SimpleWeatherAPI]: Listening on port 4000");
});
