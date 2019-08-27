const express = require("express");
const app = express();

const bp = require("body-parser");
app.use(bp.json());
app.use(bp.urlencoded({ extended: false }));

const cors = require("cors");
app.use(cors());

let zones;

on("Zones", Zones => {
  zones = Zones;
});

app.get("/getzones", (req, res) => {
  emit("GetZones");
  let timeout = setInterval(() => {
    if (zones) {
      res.send(JSON.parse(zones));
      clearInterval(timeout);
      console.log("SimpleWeatherAPI: Waiting For Server Response");
    }
  }, 500);
});

app.post("/updatezones", (req, res) => {
  emit("WeatherUpdate", JSON.stringify(req.body));
  res.send({ success: true });
});

app.listen(4000, () => {
  console.log("SimpleWeatherAPI: API LISTENING");
});
