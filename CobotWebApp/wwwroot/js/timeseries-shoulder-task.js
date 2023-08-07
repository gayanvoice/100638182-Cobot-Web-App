"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesShoulderElapsedSpan = document.getElementById("timeseriesShoulderElapsedSpan");
const timeseriesShoulderSpinner = document.getElementById("timeseriesShoulderSpinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesShoulderTask();
}).catch(function (err) {
    return console.error(err.toString());
});
var shoulderTemperatureXArray = [];
var shoulderTemperatureYArray = [];

var shoulderPositionXArray = [];
var shoulderPositionYArray = [];

var shoulderVoltageXArray = [];
var shoulderVoltageYArray = [];

timeseriesHubConnection.on("TimeseriesShoulderResponse", function (message) {

    timeseriesShoulderSpinner.style.display = 'none';

    const timeseriesShoulderModelObject = JSON.parse(message);

    timeseriesShoulderElapsedSpan.innerHTML = timeseriesShoulderModelObject.Duration;

    shoulderTemperatureXArray.push(convertTimestamp(timeseriesShoulderModelObject.LastUpdateTime))
    shoulderTemperatureYArray.push(timeseriesShoulderModelObject.ShoulderTwinModel.Temperature)

    shoulderPositionXArray.push(convertTimestamp(timeseriesShoulderModelObject.LastUpdateTime))
    shoulderPositionYArray.push(timeseriesShoulderModelObject.ShoulderTwinModel.Position)

    shoulderVoltageXArray.push(convertTimestamp(timeseriesShoulderModelObject.LastUpdateTime))
    shoulderVoltageYArray.push(timeseriesShoulderModelObject.ShoulderTwinModel.Voltage)

    const shoulderTemperatureXArrayLength = shoulderTemperatureXArray.length;
    const shoulderPositionXArrayLength = shoulderPositionXArray.length;
    const shoulderVoltageXArrayLength = shoulderVoltageXArray.length;


    var newShoulderTemperatureGraph = [
        {
            x: [convertTimestamp(timeseriesShoulderModelObject.LastUpdateTime)],
            y: [timeseriesShoulderModelObject.ShoulderTwinModel.Temperature],
            type: 'scatter'
        }
    ];
    var newShoulderPositionGraph = [
        {
            x: [convertTimestamp(timeseriesShoulderModelObject.LastUpdateTime)],
            y: [timeseriesShoulderModelObject.ShoulderTwinModel.Position],
            type: 'scatter'
        }
    ];
    var newShoulderVoltageGraph = [
        {
            x: [convertTimestamp(timeseriesShoulderModelObject.LastUpdateTime)],
            y: [timeseriesShoulderModelObject.ShoulderTwinModel.Voltage],
            type: 'scatter'
        }
    ];
    var updateShoulderTemperatureGraph = {
        x: [shoulderTemperatureXArray],
        y: [shoulderTemperatureYArray],
        type: "scatter",
    };
    var updateShoulderPositionGraph = {
        x: [shoulderPositionXArray],
        y: [shoulderPositionYArray],
        type: "scatter",
    };
    var updateShoulderVoltageGraph = {
        x: [shoulderVoltageXArray],
        y: [shoulderVoltageYArray],
        type: "scatter",
    };
    if (shoulderTemperatureXArrayLength === 1) {
        Plotly.newPlot('shoulderTemperatureGraphDiv', newShoulderTemperatureGraph);
    }
    else {
        Plotly.restyle('shoulderTemperatureGraphDiv', updateShoulderTemperatureGraph);
    }
    if (shoulderPositionXArrayLength === 1) {
        Plotly.newPlot('shoulderPositionGraphDiv', newShoulderPositionGraph);
    }
    else {
        Plotly.restyle('shoulderPositionGraphDiv', updateShoulderPositionGraph);
    }
    if (shoulderVoltageXArrayLength === 1) {
        Plotly.newPlot('shoulderVoltageGraphDiv', newShoulderVoltageGraph);
    }
    else {
        Plotly.restyle('shoulderVoltageGraphDiv', updateShoulderVoltageGraph);
    }
    setTimeout(invokeTimeseriesShoulderTask, 5000);
});
function invokeTimeseriesShoulderTask() {
    timeseriesShoulderSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesShoulderTask").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}