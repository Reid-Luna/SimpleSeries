let zones;
let editing = false;
let CurrentArea = Neighborhoods;
let loggedIn = false;

$(() => {
  $(".password").focus();
  const UpdateZones = newZones => {
    zones = JSON.parse(newZones);
    $("#weatherTableBody").empty();
    $("#weatherTableFoot").empty();
    if (!CurrentArea) return;
    Object.keys(CurrentArea).forEach(zone => {
      let weather = zones[CurrentArea[zone][0]];
      $("#weatherTableBody").append(
        `<tr>
        <td>${zone}</td>
        <td>
        <select class="custom-select selector" id="${zone}">
          <option selected value="${weather}">${weather}</option>
          ${Weather.map(type => `<option value="${type}">${type}</option>`)}
        </select>
      </div>
        </td>
      </tr>`
      );
    });
    $(".selector").on("change", e => {
      editing = true;
    });
    $("#weatherTableBody").append(`
    <tr>
      <td colspan=2>
      <button class="btn btn-outline-primary btn-lg btn-block" id="submit">Apply</button>
      </td>
    </tr>`);
    $("#submit").click(e => {
      e.preventDefault();

      Object.keys(CurrentArea).forEach(area => {
        CurrentArea[area].forEach(zone => {
          zones[zone] = $(`#${area}`).val();
        });
      });

      $.post("http://simplemenu/ChangeWeather", JSON.stringify(zones));
    });
  };

  $("#weatherBtn").click(() => {
    $(".container").css("display", "none");
    $("#weather").css("display", "flex");
    if (zones) {
      if (!editing) UpdateZones(JSON.stringify(zones));
    }
  });

  $(".AreaSelector").change(e => {
    editing = true;
    switch (e.target.value) {
      case "Neighborhoods":
        CurrentArea = Neighborhoods;
        break;

      case "Regions":
        CurrentArea = Regions;
        break;

      case "All":
        CurrentArea = All;
        break;
    }
    UpdateZones(JSON.stringify(zones));
  });

  window.addEventListener("message", event => {
    if (event.data.type === "enable") {
      $("html").css("display", event.data.enabled ? "flex" : "none");
    } else if (event.data.type === "zones") {
      if (!editing) UpdateZones(event.data.zones);
    } else if (event.data.type === "alert") {
      $(".alert")
        .addClass(event.data.success ? "alert-success" : "alert-danger")
        .html(
          event.data.success ? "Updated Weather" : "Failed to Update Weather"
        )
        .css("display", "block");
      setTimeout(() => {
        $(".alert")
          .removeClass(event.data.success ? "alert-success" : "alert-danger")
          .html("")
          .css("display", "none");
      }, 5000);
    }
  });

  window.addEventListener("keyup", e => {
    if ($(".password:focus")) {
      const code = e.keyCode ? e.keyCode : e.which;
      if (code == 13) {
        $("#loginBtn").click();
      }
    }
  });

  $("#loginBtn").click(() => {
    $.post(
      "http://simplemenu/Login",
      JSON.stringify({ password: $(".password").val() }),
      logged => {
        loggedIn = logged;
        if (loggedIn) {
          $(".login-container").remove();
          $(".container").css("display", "flex");
          $(".backBtn").attr("disabled", false);
        } else {
          $(".alert")
            .addClass("alert-danger")
            .html("Password Incorrect")
            .css("display", "block");

          setTimeout(() => {
            $(".alert")
              .removeClass("alert-danger")
              .html("")
              .css("display", "none");
          }, 5000);
        }
      }
    );
  });

  const close = () => {
    $.post("http://simplemenu/ESCAPE", JSON.stringify({}));
  };

  $(".closeBtn").click(() => {
    close();
  });

  $(".backBtn").click(() => {
    $("#weather").css("display", "none");
    $(".container").css("display", "flex");
  });

  document.onkeyup = event => {
    if (event.keyCode == 27) {
      console.log("escape");
      close();
    }
  };
});
