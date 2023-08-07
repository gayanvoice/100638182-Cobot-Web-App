"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesWrist1ElapsedSpan = document.getElementById("timeseriesWrist1ElapsedSpan");
const timeseriesWrist1Spinner = document.getElementById("timeseriesWrist1Spinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesWrist1Task();
}).catch(function (err) {
    return console.error(err.toString());
});
var wrist1TemperatureXArray = [];
var wrist1TemperatureYArray = [];

var wrist1PositionXArray = [];
var wrist1PositionYArray = [];

var wrist1VoltageXArray = [];
var wrist1VoltageYArray = [];

timeseriesHubConnection.on("TimeseriesWrist1Response", function (message) {

    timeseriesWrist1Spinner.style.display = 'none';

    const timeseriesWrist1ModelObject = JSON.parse(message);

    timeseriesWrist1ElapsedSpan.innerHTML = timeseriesWrist1ModelObject.Duration;

    wrist1TemperatureXArray.push(convertTimestamp(timeseriesWrist1ModelObject.LastUpdateTime))
    wrist1TemperatureYArray.push(timeseriesWrist1ModelObject.Wrist1TwinModel.Temperature)

    wrist1PositionXArray.push(convertTimestamp(timeseriesWrist1ModelObject.LastUpdateTime))
    wrist1PositionYArray.push(timeseriesWrist1ModelObject.Wrist1TwinModel.Position)

    wrist1VoltageXArray.push(convertTimestamp(timeseriesWrist1ModelObject.LastUpdateTime))
    wrist1VoltageYArray.push(timeseriesWrist1ModelObject.Wrist1TwinModel.Voltage)

    const wrist1TemperatureXArrayLength = wrist1TemperatureXArray.length;
    const wrist1PositionXArrayLength = wrist1PositionXArray.length;
    const wrist1VoltageXArrayLength = wrist1VoltageXArray.length;


    var newWrist1TemperatureGraph = [
        {
            x: [convertTimestamp(timeseriesWrist1ModelObject.LastUpdateTime)],
            y: [timeseriesWrist1ModelObject.Wrist1TwinModel.Temperature],
            type: 'scatter'
        }
    ];
    var newWrist1PositionGraph = [
        {
            x: [convertTimestamp(timeseriesWrist1ModelObject.LastUpdateTime)],
            y: [timeseriesWrist1ModelObject.Wrist1TwinModel.Position],
            type: 'scatter'
        }
    ];
    var newWrist1VoltageGraph = [
        {
            x: [convertTimestamp(timeseriesWrist1ModelObject.LastUpdateTime)],
            y: [timeseriesWrist1ModelObject.Wrist1TwinModel.Voltage],
            type: 'scatter'
        }
    ];
    var updateWrist1TemperatureGraph = {
        x: [wrist1TemperatureXArray],
        y: [wrist1TemperatureYArray],
        type: "scatter",
    };
    var updateWrist1PositionGraph = {
        x: [wrist1PositionXArray],
        y: [wrist1PositionYArray],
        type: "scatter",
    };
    var updateWrist1VoltageGraph = {
        x: [wrist1VoltageXArray],
        y: [wrist1VoltageYArray],
        type: "scatter",
    };
    if (wrist1TemperatureXArrayLength === 1) {
        Plotly.newPlot('wrist1TemperatureGraphDiv', newWrist1TemperatureGraph);
    }
    else {
        Plotly.restyle('wrist1TemperatureGraphDiv', updateWrist1TemperatureGraph);
    }
    if (wrist1PositionXArrayLength === 1) {
        Plotly.newPlot('wrist1PositionGraphDiv', newWrist1PositionGraph);
    }
    else {
        Plotly.restyle('wrist1PositionGraphDiv', updateWrist1PositionGraph);
    }
    if (wrist1VoltageXArrayLength === 1) {
        Plotly.newPlot('wrist1VoltageGraphDiv', newWrist1VoltageGraph);
    }
    else {
        Plotly.restyle('wrist1VoltageGraphDiv', updateWrist1VoltageGraph);
    }
    setTimeout(invokeTimeseriesWrist1Task, 5000);
});
function invokeTimeseriesWrist1Task() {
    timeseriesWrist1Spinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesWrist1Task").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}