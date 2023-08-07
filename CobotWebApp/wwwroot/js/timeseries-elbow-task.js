"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesElbowElapsedSpan = document.getElementById("timeseriesElbowElapsedSpan");
const timeseriesElbowSpinner = document.getElementById("timeseriesElbowSpinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesElbowTask();
}).catch(function (err) {
    return console.error(err.toString());
});
var elbowTemperatureXArray = [];
var elbowTemperatureYArray = [];

var elbowPositionXArray = [];
var elbowPositionYArray = [];

var elbowVoltageXArray = [];
var elbowVoltageYArray = [];

var elbowXXArray = [];
var elbowXYArray = [];

var elbowYXArray = [];
var elbowYYArray = [];

var elbowZXArray = [];
var elbowZYArray = [];

timeseriesHubConnection.on("TimeseriesElbowResponse", function (message) {

    timeseriesElbowSpinner.style.display = 'none';

    const timeseriesElbowModelObject = JSON.parse(message);

    timeseriesElbowElapsedSpan.innerHTML = timeseriesElbowModelObject.Duration;

    elbowTemperatureXArray.push(convertTimestamp(timeseriesElbowModelObject.LastUpdateTime))
    elbowTemperatureYArray.push(timeseriesElbowModelObject.ElbowTwinModel.Temperature)

    elbowPositionXArray.push(convertTimestamp(timeseriesElbowModelObject.LastUpdateTime))
    elbowPositionYArray.push(timeseriesElbowModelObject.ElbowTwinModel.Position)

    elbowVoltageXArray.push(convertTimestamp(timeseriesElbowModelObject.LastUpdateTime))
    elbowVoltageYArray.push(timeseriesElbowModelObject.ElbowTwinModel.Voltage)

    elbowXXArray.push(convertTimestamp(timeseriesElbowModelObject.LastUpdateTime))
    elbowXYArray.push(timeseriesElbowModelObject.ElbowTwinModel.X)

    elbowYXArray.push(convertTimestamp(timeseriesElbowModelObject.LastUpdateTime))
    elbowYYArray.push(timeseriesElbowModelObject.ElbowTwinModel.Y)

    elbowZXArray.push(convertTimestamp(timeseriesElbowModelObject.LastUpdateTime))
    elbowZYArray.push(timeseriesElbowModelObject.ElbowTwinModel.Z)

    const elbowTemperatureXArrayLength = elbowTemperatureXArray.length;
    const elbowPositionXArrayLength = elbowPositionXArray.length;
    const elbowVoltageXArrayLength = elbowVoltageXArray.length;
    const elbowXXArrayLength = elbowXXArray.length;
    const elbowYXArrayLength = elbowYXArray.length;
    const elbowZXArrayLength = elbowZXArray.length;


    var newElbowTemperatureGraph = [
        {
            x: [convertTimestamp(timeseriesElbowModelObject.LastUpdateTime)],
            y: [timeseriesElbowModelObject.ElbowTwinModel.Temperature],
            type: 'scatter'
        }
    ];
    var newElbowPositionGraph = [
        {
            x: [convertTimestamp(timeseriesElbowModelObject.LastUpdateTime)],
            y: [timeseriesElbowModelObject.ElbowTwinModel.Position],
            type: 'scatter'
        }
    ];
    var newElbowVoltageGraph = [
        {
            x: [convertTimestamp(timeseriesElbowModelObject.LastUpdateTime)],
            y: [timeseriesElbowModelObject.ElbowTwinModel.Voltage],
            type: 'scatter'
        }
    ];
    var newElbowXGraph = [
        {
            x: [convertTimestamp(timeseriesElbowModelObject.LastUpdateTime)],
            y: [timeseriesElbowModelObject.ElbowTwinModel.X],
            type: 'scatter'
        }
    ];
    var newElbowYGraph = [
        {
            x: [convertTimestamp(timeseriesElbowModelObject.LastUpdateTime)],
            y: [timeseriesElbowModelObject.ElbowTwinModel.Y],
            type: 'scatter'
        }
    ];
    var newElbowZGraph = [
        {
            x: [convertTimestamp(timeseriesElbowModelObject.LastUpdateTime)],
            y: [timeseriesElbowModelObject.ElbowTwinModel.Z],
            type: 'scatter'
        }
    ];
    var updateElbowTemperatureGraph = {
        x: [elbowTemperatureXArray],
        y: [elbowTemperatureYArray],
        type: "scatter",
    };
    var updateElbowPositionGraph = {
        x: [elbowPositionXArray],
        y: [elbowPositionYArray],
        type: "scatter",
    };
    var updateElbowVoltageGraph = {
        x: [elbowVoltageXArray],
        y: [elbowVoltageYArray],
        type: "scatter",
    };
    var updateElbowXGraph = {
        x: [elbowXXArray],
        y: [elbowXYArray],
        type: "scatter",
    };
    var updateElbowYGraph = {
        x: [elbowYXArray],
        y: [elbowYYArray],
        type: "scatter",
    };
    var updateElbowZGraph = {
        x: [elbowZXArray],
        y: [elbowZYArray],
        type: "scatter",
    };
    if (elbowTemperatureXArrayLength === 1) {
        Plotly.newPlot('elbowTemperatureGraphDiv', newElbowTemperatureGraph);
    }
    else {
        Plotly.restyle('elbowTemperatureGraphDiv', updateElbowTemperatureGraph);
    }
    if (elbowPositionXArrayLength === 1) {
        Plotly.newPlot('elbowPositionGraphDiv', newElbowPositionGraph);
    }
    else {
        Plotly.restyle('elbowPositionGraphDiv', updateElbowPositionGraph);
    }
    if (elbowVoltageXArrayLength === 1) {
        Plotly.newPlot('elbowVoltageGraphDiv', newElbowVoltageGraph);
    }
    else {
        Plotly.restyle('elbowVoltageGraphDiv', updateElbowVoltageGraph);
    }
    if (elbowXXArrayLength === 1) {
        Plotly.newPlot('elbowXGraphDiv', newElbowXGraph);
    }
    else {
        Plotly.restyle('elbowXGraphDiv', updateElbowXGraph);
    }
    if (elbowYXArrayLength === 1) {
        Plotly.newPlot('elbowYGraphDiv', newElbowYGraph);
    }
    else {
        Plotly.restyle('elbowYGraphDiv', updateElbowYGraph);
    }
    if (elbowZXArrayLength === 1) {
        Plotly.newPlot('elbowZGraphDiv', newElbowZGraph);
    }
    else {
        Plotly.restyle('elbowZGraphDiv', updateElbowZGraph);
    }
    setTimeout(invokeTimeseriesElbowTask, 5000);
});
function invokeTimeseriesElbowTask() {
    timeseriesElbowSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesElbowTask").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}