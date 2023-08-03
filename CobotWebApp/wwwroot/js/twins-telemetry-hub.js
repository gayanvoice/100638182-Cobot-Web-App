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
        cobotElapsedTimeDiv.innerHTML = "Error";

        controlBoxVoltageDiv.innerHTML = "Error";

        payloadCogXDiv.innerHTML = "Error";
        payloadCogYDiv.innerHTML = "Error";
        payloadCogZDiv.innerHTML = "Error";
        payloadMassDiv.innerHTML = "Error";

        basePositionDiv.innerHTML = "Error";
        baseTemperatureDiv.innerHTML = "Error";
        baseVoltageDiv.innerHTML = "Error";

        shoulderPositionDiv.innerHTML = "Error";
        shoulderPositionDiv.innerHTML = "Error";
        shoulderTemperatureDiv.innerHTML = "Error";
        shoulderVoltageDiv.innerHTML = "Error";

        elbowPositionDiv.innerHTML = "Error";
        elbowTemperatureDiv.innerHTML = "Error";
        elbowVoltageDiv.innerHTML = "Error";
        elbowXDiv.innerHTML = "Error";
        elbowYDiv.innerHTML = "Error";
        elbowZDiv.innerHTML = "Error";

        wrist1PositionDiv.innerHTML = "Error";
        wrist1TemperatureDiv.innerHTML = "Error";
        wrist1VoltageDiv.innerHTML = "Error";

        wrist2PositionDiv.innerHTML = "Error";
        wrist2TemperatureDiv.innerHTML = "Error";
        wrist2VoltageDiv.innerHTML = "Error";

        wrist3PositionDiv.innerHTML = "Error";
        wrist3TemperatureDiv.innerHTML = "Error";
        wrist3VoltageDiv.innerHTML = "Error";

        toolTemperatureDiv.innerHTML = "Error";
        toolVoltageDiv.innerHTML = "Error";
        toolRxDiv.innerHTML = "Error";
        toolRyDiv.innerHTML = "Error";
        toolRzDiv.innerHTML = "Error";
        toolXDiv.innerHTML = "Error";
        toolYDiv.innerHTML = "Error";
        toolZDiv.innerHTML = "Error";

        reject(err.toString());
    });
}
