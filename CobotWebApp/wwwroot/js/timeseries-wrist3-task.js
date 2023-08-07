"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesWrist3ElapsedSpan = document.getElementById("timeseriesWrist3ElapsedSpan");
const timeseriesWrist3Spinner = document.getElementById("timeseriesWrist3Spinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesWrist3Task();
}).catch(function (err) {
    return console.error(err.toString());
});
var wrist3TemperatureXArray = [];
var wrist3TemperatureYArray = [];

var wrist3PositionXArray = [];
var wrist3PositionYArray = [];

var wrist3VoltageXArray = [];
var wrist3VoltageYArray = [];

timeseriesHubConnection.on("TimeseriesWrist3Response", function (message) {

    timeseriesWrist3Spinner.style.display = 'none';

    const timeseriesWrist3ModelObject = JSON.parse(message);

    timeseriesWrist3ElapsedSpan.innerHTML = timeseriesWrist3ModelObject.Duration;

    wrist3TemperatureXArray.push(convertTimestamp(timeseriesWrist3ModelObject.LastUpdateTime))
    wrist3TemperatureYArray.push(timeseriesWrist3ModelObject.Wrist3TwinModel.Temperature)

    wrist3PositionXArray.push(convertTimestamp(timeseriesWrist3ModelObject.LastUpdateTime))
    wrist3PositionYArray.push(timeseriesWrist3ModelObject.Wrist3TwinModel.Position)

    wrist3VoltageXArray.push(convertTimestamp(timeseriesWrist3ModelObject.LastUpdateTime))
    wrist3VoltageYArray.push(timeseriesWrist3ModelObject.Wrist3TwinModel.Voltage)

    const wrist3TemperatureXArrayLength = wrist3TemperatureXArray.length;
    const wrist3PositionXArrayLength = wrist3PositionXArray.length;
    const wrist3VoltageXArrayLength = wrist3VoltageXArray.length;


    var newWrist3TemperatureGraph = [
        {
            x: [convertTimestamp(timeseriesWrist3ModelObject.LastUpdateTime)],
            y: [timeseriesWrist3ModelObject.Wrist3TwinModel.Temperature],
            type: 'scatter'
        }
    ];
    var newWrist3PositionGraph = [
        {
            x: [convertTimestamp(timeseriesWrist3ModelObject.LastUpdateTime)],
            y: [timeseriesWrist3ModelObject.Wrist3TwinModel.Position],
            type: 'scatter'
        }
    ];
    var newWrist3VoltageGraph = [
        {
            x: [convertTimestamp(timeseriesWrist3ModelObject.LastUpdateTime)],
            y: [timeseriesWrist3ModelObject.Wrist3TwinModel.Voltage],
            type: 'scatter'
        }
    ];
    var updateWrist3TemperatureGraph = {
        x: [wrist3TemperatureXArray],
        y: [wrist3TemperatureYArray],
        type: "scatter",
    };
    var updateWrist3PositionGraph = {
        x: [wrist3PositionXArray],
        y: [wrist3PositionYArray],
        type: "scatter",
    };
    var updateWrist3VoltageGraph = {
        x: [wrist3VoltageXArray],
        y: [wrist3VoltageYArray],
        type: "scatter",
    };
    if (wrist3TemperatureXArrayLength === 1) {
        Plotly.newPlot('wrist3TemperatureGraphDiv', newWrist3TemperatureGraph);
    }
    else {
        Plotly.restyle('wrist3TemperatureGraphDiv', updateWrist3TemperatureGraph);
    }
    if (wrist3PositionXArrayLength === 1) {
        Plotly.newPlot('wrist3PositionGraphDiv', newWrist3PositionGraph);
    }
    else {
        Plotly.restyle('wrist3PositionGraphDiv', updateWrist3PositionGraph);
    }
    if (wrist3VoltageXArrayLength === 1) {
        Plotly.newPlot('wrist3VoltageGraphDiv', newWrist3VoltageGraph);
    }
    else {
        Plotly.restyle('wrist3VoltageGraphDiv', updateWrist3VoltageGraph);
    }
    setTimeout(invokeTimeseriesWrist3Task, 5000);
});
function invokeTimeseriesWrist3Task() {
    timeseriesWrist3Spinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesWrist3Task").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}