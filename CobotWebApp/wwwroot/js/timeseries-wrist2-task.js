"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesWrist2ElapsedSpan = document.getElementById("timeseriesWrist2ElapsedSpan");
const timeseriesWrist2Spinner = document.getElementById("timeseriesWrist2Spinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesWrist2Task();
}).catch(function (err) {
    return console.error(err.toString());
});
var wrist2TemperatureXArray = [];
var wrist2TemperatureYArray = [];

var wrist2PositionXArray = [];
var wrist2PositionYArray = [];

var wrist2VoltageXArray = [];
var wrist2VoltageYArray = [];

timeseriesHubConnection.on("TimeseriesWrist2Response", function (message) {

    timeseriesWrist2Spinner.style.display = 'none';

    const timeseriesWrist2ModelObject = JSON.parse(message);

    timeseriesWrist2ElapsedSpan.innerHTML = timeseriesWrist2ModelObject.Duration;

    wrist2TemperatureXArray.push(convertTimestamp(timeseriesWrist2ModelObject.LastUpdateTime))
    wrist2TemperatureYArray.push(timeseriesWrist2ModelObject.Wrist2TwinModel.Temperature)

    wrist2PositionXArray.push(convertTimestamp(timeseriesWrist2ModelObject.LastUpdateTime))
    wrist2PositionYArray.push(timeseriesWrist2ModelObject.Wrist2TwinModel.Position)

    wrist2VoltageXArray.push(convertTimestamp(timeseriesWrist2ModelObject.LastUpdateTime))
    wrist2VoltageYArray.push(timeseriesWrist2ModelObject.Wrist2TwinModel.Voltage)

    const wrist2TemperatureXArrayLength = wrist2TemperatureXArray.length;
    const wrist2PositionXArrayLength = wrist2PositionXArray.length;
    const wrist2VoltageXArrayLength = wrist2VoltageXArray.length;


    var newWrist2TemperatureGraph = [
        {
            x: [convertTimestamp(timeseriesWrist2ModelObject.LastUpdateTime)],
            y: [timeseriesWrist2ModelObject.Wrist2TwinModel.Temperature],
            type: 'scatter'
        }
    ];
    var newWrist2PositionGraph = [
        {
            x: [convertTimestamp(timeseriesWrist2ModelObject.LastUpdateTime)],
            y: [timeseriesWrist2ModelObject.Wrist2TwinModel.Position],
            type: 'scatter'
        }
    ];
    var newWrist2VoltageGraph = [
        {
            x: [convertTimestamp(timeseriesWrist2ModelObject.LastUpdateTime)],
            y: [timeseriesWrist2ModelObject.Wrist2TwinModel.Voltage],
            type: 'scatter'
        }
    ];
    var updateWrist2TemperatureGraph = {
        x: [wrist2TemperatureXArray],
        y: [wrist2TemperatureYArray],
        type: "scatter",
    };
    var updateWrist2PositionGraph = {
        x: [wrist2PositionXArray],
        y: [wrist2PositionYArray],
        type: "scatter",
    };
    var updateWrist2VoltageGraph = {
        x: [wrist2VoltageXArray],
        y: [wrist2VoltageYArray],
        type: "scatter",
    };
    if (wrist2TemperatureXArrayLength === 1) {
        Plotly.newPlot('wrist2TemperatureGraphDiv', newWrist2TemperatureGraph);
    }
    else {
        Plotly.restyle('wrist2TemperatureGraphDiv', updateWrist2TemperatureGraph);
    }
    if (wrist2PositionXArrayLength === 1) {
        Plotly.newPlot('wrist2PositionGraphDiv', newWrist2PositionGraph);
    }
    else {
        Plotly.restyle('wrist2PositionGraphDiv', updateWrist2PositionGraph);
    }
    if (wrist2VoltageXArrayLength === 1) {
        Plotly.newPlot('wrist2VoltageGraphDiv', newWrist2VoltageGraph);
    }
    else {
        Plotly.restyle('wrist2VoltageGraphDiv', updateWrist2VoltageGraph);
    }
    setTimeout(invokeTimeseriesWrist2Task, 5000);
});
function invokeTimeseriesWrist2Task() {
    timeseriesWrist2Spinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesWrist2Task").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}