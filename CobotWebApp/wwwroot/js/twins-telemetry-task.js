"use strict";

const twinsHubConnection = new signalR.HubConnectionBuilder().withUrl("/twinsHub").build();

const twinsTelemetryElapsedSpan = document.getElementById("twinsTelemetryElapsedSpan");
const twinsTelemetrySpinner = document.getElementById("twinsTelemetrySpinner");

const cobotElapsedTimeDiv = document.getElementById("cobotElapsedTimeDiv");

const controlBoxVoltageDiv = document.getElementById("controlBoxVoltageDiv");

const payloadCogXDiv = document.getElementById("payloadCogXDiv");
const payloadCogYDiv = document.getElementById("payloadCogYDiv");
const payloadCogZDiv = document.getElementById("payloadCogZDiv");
const payloadMassDiv = document.getElementById("payloadMassDiv");

const basePositionDiv = document.getElementById("basePositionDiv");
const baseTemperatureDiv = document.getElementById("baseTemperatureDiv");
const baseVoltageDiv = document.getElementById("baseVoltageDiv");

const shoulderPositionDiv = document.getElementById("shoulderPositionDiv");
const shoulderTemperatureDiv = document.getElementById("shoulderTemperatureDiv");
const shoulderVoltageDiv = document.getElementById("shoulderVoltageDiv");

const elbowPositionDiv = document.getElementById("elbowPositionDiv");
const elbowTemperatureDiv = document.getElementById("elbowTemperatureDiv");
const elbowVoltageDiv = document.getElementById("elbowVoltageDiv");
const elbowXDiv = document.getElementById("elbowXDiv");
const elbowYDiv = document.getElementById("elbowYDiv");
const elbowZDiv = document.getElementById("elbowZDiv");

const wrist1PositionDiv = document.getElementById("wrist1PositionDiv");
const wrist1TempeatureDiv = document.getElementById("wrist1TempeatureDiv");
const wrist1VoltageDiv = document.getElementById("wrist1VoltageDiv");

const wrist2PositionDiv = document.getElementById("wrist2PositionDiv");
const wrist2TemperatureDiv = document.getElementById("wrist2TemperatureDiv");
const wrist2VoltageDiv = document.getElementById("wrist2VoltageDiv");

const wrist3PositionDiv = document.getElementById("wrist3PositionDiv");
const wrist3TemperatureDiv = document.getElementById("wrist3TemperatureDiv");
const wrist3VoltageDiv = document.getElementById("wrist3VoltageDiv");

const toolTemperatureDiv = document.getElementById("toolTemperatureDiv");
const toolVoltageDiv = document.getElementById("toolVoltageDiv");
const toolRxDiv = document.getElementById("toolRxDiv");
const toolRyDiv = document.getElementById("toolRyDiv");
const toolRzDiv = document.getElementById("toolRzDiv");
const toolXDiv = document.getElementById("toolXDiv");
const toolYDiv = document.getElementById("toolYDiv");
const toolZDiv = document.getElementById("toolZDiv");
twinsHubConnection.start().then(function () {
    invokeTwinsTelemetryTask();
}).catch(function (err) {
    return console.error(err.toString());
});

twinsHubConnection.on("TwinsTelemetryResponse", function (message) {

    twinsTelemetrySpinner.style.display = 'none';
    const twinsTelemetryModelObject = JSON.parse(message);
    twinsTelemetryElapsedSpan.innerHTML = twinsTelemetryModelObject.Duration;

    cobotElapsedTimeDiv.innerHTML = twinsTelemetryModelObject.CobotTwinModel.ElapsedTime;

    controlBoxVoltageDiv.innerHTML = twinsTelemetryModelObject.ControlBoxTwinModel.Voltage;

    payloadCogXDiv.innerHTML = twinsTelemetryModelObject.PayloadTwinModel.CogX;
    payloadCogYDiv.innerHTML = twinsTelemetryModelObject.PayloadTwinModel.CogY;
    payloadCogZDiv.innerHTML = twinsTelemetryModelObject.PayloadTwinModel.CogZ;
    payloadMassDiv.innerHTML = twinsTelemetryModelObject.PayloadTwinModel.Mass;

    basePositionDiv.innerHTML = twinsTelemetryModelObject.BaseTwinModel.Position;
    baseTemperatureDiv.innerHTML = twinsTelemetryModelObject.BaseTwinModel.Temperature;
    baseVoltageDiv.innerHTML = twinsTelemetryModelObject.BaseTwinModel.Voltage;

    shoulderPositionDiv.innerHTML = twinsTelemetryModelObject.ShoulderTwinModel.Position;
    shoulderTemperatureDiv.innerHTML = twinsTelemetryModelObject.ShoulderTwinModel.Temperature;
    shoulderVoltageDiv.innerHTML = twinsTelemetryModelObject.ShoulderTwinModel.Voltage;

    elbowPositionDiv.innerHTML = twinsTelemetryModelObject.ElbowTwinModel.Position;
    elbowTemperatureDiv.innerHTML = twinsTelemetryModelObject.ElbowTwinModel.Temperature;
    elbowVoltageDiv.innerHTML = twinsTelemetryModelObject.ElbowTwinModel.Voltage;
    elbowXDiv.innerHTML = twinsTelemetryModelObject.ElbowTwinModel.X;
    elbowYDiv.innerHTML = twinsTelemetryModelObject.ElbowTwinModel.Y;
    elbowZDiv.innerHTML = twinsTelemetryModelObject.ElbowTwinModel.Z;

    wrist1PositionDiv.innerHTML = twinsTelemetryModelObject.Wrist1TwinModel.Position;
    wrist1TemperatureDiv.innerHTML = twinsTelemetryModelObject.Wrist1TwinModel.Temperature;
    wrist1VoltageDiv.innerHTML = twinsTelemetryModelObject.Wrist1TwinModel.Voltage;

    wrist2PositionDiv.innerHTML = twinsTelemetryModelObject.Wrist2TwinModel.Position;
    wrist2TemperatureDiv.innerHTML = twinsTelemetryModelObject.Wrist2TwinModel.Temperature;
    wrist2VoltageDiv.innerHTML = twinsTelemetryModelObject.Wrist2TwinModel.Voltage;

    wrist3PositionDiv.innerHTML = twinsTelemetryModelObject.Wrist3TwinModel.Position;
    wrist3TemperatureDiv.innerHTML = twinsTelemetryModelObject.Wrist3TwinModel.Temperature;
    wrist3VoltageDiv.innerHTML = twinsTelemetryModelObject.Wrist3TwinModel.Voltage;

    toolTemperatureDiv.innerHTML = twinsTelemetryModelObject.ToolTwinModel.Temperature;
    toolVoltageDiv.innerHTML = twinsTelemetryModelObject.ToolTwinModel.Voltage;
    toolRxDiv.innerHTML = twinsTelemetryModelObject.ToolTwinModel.Rx;
    toolRyDiv.innerHTML = twinsTelemetryModelObject.ToolTwinModel.Ry;
    toolRzDiv.innerHTML = twinsTelemetryModelObject.ToolTwinModel.Rz;
    toolXDiv.innerHTML = twinsTelemetryModelObject.ToolTwinModel.X;
    toolYDiv.innerHTML = twinsTelemetryModelObject.ToolTwinModel.Y;
    toolZDiv.innerHTML = twinsTelemetryModelObject.ToolTwinModel.Z;

    setTimeout(invokeTwinsTelemetryTask, 5000);
});
function invokeTwinsTelemetryTask() {
    twinsTelemetrySpinner.style.display = 'block';
    twinsHubConnection.invoke("TwinsTelemetryTask").catch(function (err) {
        console.log(err.toString());
        cobotElapsedTimeDiv.innerHTML = "Not Syncing";

        controlBoxVoltageDiv.innerHTML = "Not Syncing";

        payloadCogXDiv.innerHTML = "Not Syncing";
        payloadCogYDiv.innerHTML = "Not Syncing";
        payloadCogZDiv.innerHTML = "Not Syncing";
        payloadMassDiv.innerHTML = "Not Syncing";

        basePositionDiv.innerHTML = "Not Syncing";
        baseTemperatureDiv.innerHTML = "Not Syncing";
        baseVoltageDiv.innerHTML = "Not Syncing";

        shoulderPositionDiv.innerHTML = "Not Syncing";
        shoulderPositionDiv.innerHTML = "Not Syncing";
        shoulderTemperatureDiv.innerHTML = "Not Syncing";
        shoulderVoltageDiv.innerHTML = "Not Syncing";

        elbowPositionDiv.innerHTML = "Not Syncing";
        elbowTemperatureDiv.innerHTML = "Not Syncing";
        elbowVoltageDiv.innerHTML = "Not Syncing";
        elbowXDiv.innerHTML = "Not Syncing";
        elbowYDiv.innerHTML = "Not Syncing";
        elbowZDiv.innerHTML = "Not Syncing";

        wrist1PositionDiv.innerHTML = "Not Syncing";
        wrist1TemperatureDiv.innerHTML = "Not Syncing";
        wrist1VoltageDiv.innerHTML = "Not Syncing";

        wrist2PositionDiv.innerHTML = "Not Syncing";
        wrist2TemperatureDiv.innerHTML = "Not Syncing";
        wrist2VoltageDiv.innerHTML = "Not Syncing";

        wrist3PositionDiv.innerHTML = "Not Syncing";
        wrist3TemperatureDiv.innerHTML = "Not Syncing";
        wrist3VoltageDiv.innerHTML = "Not Syncing";

        toolTemperatureDiv.innerHTML = "Not Syncing";
        toolVoltageDiv.innerHTML = "Not Syncing";
        toolRxDiv.innerHTML = "Not Syncing";
        toolRyDiv.innerHTML = "Not Syncing";
        toolRzDiv.innerHTML = "Not Syncing";
        toolXDiv.innerHTML = "Not Syncing";
        toolYDiv.innerHTML = "Not Syncing";
        toolZDiv.innerHTML = "Not Syncing";

        reject(err.toString());
    });
}
