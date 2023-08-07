"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesBaseElapsedSpan = document.getElementById("timeseriesBaseElapsedSpan");
const timeseriesBaseSpinner = document.getElementById("timeseriesBaseSpinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesBaseTask();
}).catch(function (err) {
    return console.error(err.toString());
});
var baseTemperatureXArray = [];
var baseTemperatureYArray = [];

var basePositionXArray = [];
var basePositionYArray = [];

var baseVoltageXArray = [];
var baseVoltageYArray = [];

timeseriesHubConnection.on("TimeseriesBaseResponse", function (message) {

    timeseriesBaseSpinner.style.display = 'none';

    const timeseriesBaseModelObject = JSON.parse(message);

    timeseriesBaseElapsedSpan.innerHTML = timeseriesBaseModelObject.Duration;

    baseTemperatureXArray.push(convertTimestamp(timeseriesBaseModelObject.LastUpdateTime))
    baseTemperatureYArray.push(timeseriesBaseModelObject.BaseTwinModel.Temperature)

    basePositionXArray.push(convertTimestamp(timeseriesBaseModelObject.LastUpdateTime))
    basePositionYArray.push(timeseriesBaseModelObject.BaseTwinModel.Position)

    baseVoltageXArray.push(convertTimestamp(timeseriesBaseModelObject.LastUpdateTime))
    baseVoltageYArray.push(timeseriesBaseModelObject.BaseTwinModel.Voltage)

    const baseTemperatureXArrayLength = baseTemperatureXArray.length;
    const basePositionXArrayLength = basePositionXArray.length;
    const baseVoltageXArrayLength = baseVoltageXArray.length;


    var newBaseTemperatureGraph = [
        {
            x: [convertTimestamp(timeseriesBaseModelObject.LastUpdateTime)],
            y: [timeseriesBaseModelObject.BaseTwinModel.Temperature],
            type: 'scatter'
        }
    ];
    var newBasePositionGraph = [
        {
            x: [convertTimestamp(timeseriesBaseModelObject.LastUpdateTime)],
            y: [timeseriesBaseModelObject.BaseTwinModel.Position],
            type: 'scatter'
        }
    ];
    var newBaseVoltageGraph = [
        {
            x: [convertTimestamp(timeseriesBaseModelObject.LastUpdateTime)],
            y: [timeseriesBaseModelObject.BaseTwinModel.Voltage],
            type: 'scatter'
        }
    ];
    var updateBaseTemperatureGraph = {
        x: [baseTemperatureXArray],
        y: [baseTemperatureYArray],
        type: "scatter",
    };
    var updateBasePositionGraph = {
        x: [basePositionXArray],
        y: [basePositionYArray],
        type: "scatter",
    };
    var updateBaseVoltageGraph = {
        x: [baseVoltageXArray],
        y: [baseVoltageYArray],
        type: "scatter",
    };
    if (baseTemperatureXArrayLength === 1) {
        Plotly.newPlot('baseTemperatureGraphDiv', newBaseTemperatureGraph);
    }
    else {
        Plotly.restyle('baseTemperatureGraphDiv', updateBaseTemperatureGraph);
    }
    if (basePositionXArrayLength === 1) {
        Plotly.newPlot('basePositionGraphDiv', newBasePositionGraph);
    }
    else {
        Plotly.restyle('basePositionGraphDiv', updateBasePositionGraph);
    }
    if (baseVoltageXArrayLength === 1) {
        Plotly.newPlot('baseVoltageGraphDiv', newBaseVoltageGraph);
    }
    else {
        Plotly.restyle('baseVoltageGraphDiv', updateBaseVoltageGraph);
    }
    setTimeout(invokeTimeseriesBaseTask, 5000);
});
function invokeTimeseriesBaseTask() {
    timeseriesBaseSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesBaseTask").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}