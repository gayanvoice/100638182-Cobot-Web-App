"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesToolElapsedSpan = document.getElementById("timeseriesToolElapsedSpan");
const timeseriesToolSpinner = document.getElementById("timeseriesToolSpinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesToolTask();
}).catch(function (err) {
    return console.error(err.toString());
});
var toolTemperatureXArray = [];
var toolTemperatureYArray = [];

var toolVoltageXArray = [];
var toolVoltageYArray = [];

var toolXXArray = [];
var toolXYArray = [];

var toolYXArray = [];
var toolYYArray = [];

var toolZXArray = [];
var toolZYArray = [];

var toolRxXArray = [];
var toolRxYArray = [];

var toolRyXArray = [];
var toolRyYArray = [];

var toolRzXArray = [];
var toolRzYArray = [];

timeseriesHubConnection.on("TimeseriesToolResponse", function (message) {

    timeseriesToolSpinner.style.display = 'none';

    const timeseriesToolModelObject = JSON.parse(message);

    timeseriesToolElapsedSpan.innerHTML = timeseriesToolModelObject.Duration;

    toolTemperatureXArray.push(convertTimestamp(timeseriesToolModelObject.LastUpdateTime))
    toolTemperatureYArray.push(timeseriesToolModelObject.ToolTwinModel.Temperature)

    toolVoltageXArray.push(convertTimestamp(timeseriesToolModelObject.LastUpdateTime))
    toolVoltageYArray.push(timeseriesToolModelObject.ToolTwinModel.Voltage)

    toolXXArray.push(convertTimestamp(timeseriesToolModelObject.LastUpdateTime))
    toolXYArray.push(timeseriesToolModelObject.ToolTwinModel.X)

    toolYXArray.push(convertTimestamp(timeseriesToolModelObject.LastUpdateTime))
    toolYYArray.push(timeseriesToolModelObject.ToolTwinModel.Y)

    toolZXArray.push(convertTimestamp(timeseriesToolModelObject.LastUpdateTime))
    toolZYArray.push(timeseriesToolModelObject.ToolTwinModel.Z)

    toolRxXArray.push(convertTimestamp(timeseriesToolModelObject.LastUpdateTime))
    toolRxYArray.push(timeseriesToolModelObject.ToolTwinModel.Rx)

    toolRyXArray.push(convertTimestamp(timeseriesToolModelObject.LastUpdateTime))
    toolRyYArray.push(timeseriesToolModelObject.ToolTwinModel.Ry)

    toolRzXArray.push(convertTimestamp(timeseriesToolModelObject.LastUpdateTime))
    toolRzYArray.push(timeseriesToolModelObject.ToolTwinModel.Rz)

    const toolTemperatureXArrayLength = toolTemperatureXArray.length;
    const toolVoltageXArrayLength = toolVoltageXArray.length;
    const toolXXArrayLength = toolXXArray.length;
    const toolYXArrayLength = toolYXArray.length;
    const toolZXArrayLength = toolZXArray.length;
    const toolRxXArrayLength = toolRxXArray.length;
    const toolRyXArrayLength = toolRyXArray.length;
    const toolRzXArrayLength = toolRzXArray.length;

    var newToolTemperatureGraph = [
        {
            x: [convertTimestamp(timeseriesToolModelObject.LastUpdateTime)],
            y: [timeseriesToolModelObject.ToolTwinModel.Temperature],
            type: 'scatter'
        }
    ];
    var newToolVoltageGraph = [
        {
            x: [convertTimestamp(timeseriesToolModelObject.LastUpdateTime)],
            y: [timeseriesToolModelObject.ToolTwinModel.Voltage],
            type: 'scatter'
        }
    ];
    var newToolXGraph = [
        {
            x: [convertTimestamp(timeseriesToolModelObject.LastUpdateTime)],
            y: [timeseriesToolModelObject.ToolTwinModel.X],
            type: 'scatter'
        }
    ];
    var newToolYGraph = [
        {
            x: [convertTimestamp(timeseriesToolModelObject.LastUpdateTime)],
            y: [timeseriesToolModelObject.ToolTwinModel.Y],
            type: 'scatter'
        }
    ];
    var newToolZGraph = [
        {
            x: [convertTimestamp(timeseriesToolModelObject.LastUpdateTime)],
            y: [timeseriesToolModelObject.ToolTwinModel.Z],
            type: 'scatter'
        }
    ];
    var newToolRxGraph = [
        {
            x: [convertTimestamp(timeseriesToolModelObject.LastUpdateTime)],
            y: [timeseriesToolModelObject.ToolTwinModel.Rx],
            type: 'scatter'
        }
    ];
    var newToolRyGraph = [
        {
            x: [convertTimestamp(timeseriesToolModelObject.LastUpdateTime)],
            y: [timeseriesToolModelObject.ToolTwinModel.Ry],
            type: 'scatter'
        }
    ];
    var newToolRzGraph = [
        {
            x: [convertTimestamp(timeseriesToolModelObject.LastUpdateTime)],
            y: [timeseriesToolModelObject.ToolTwinModel.Rz],
            type: 'scatter'
        }
    ];
    var updateToolTemperatureGraph = {
        x: [toolTemperatureXArray],
        y: [toolTemperatureYArray],
        type: "scatter",
    };
    var updateToolVoltageGraph = {
        x: [toolVoltageXArray],
        y: [toolVoltageYArray],
        type: "scatter",
    };
    var updateToolXGraph = {
        x: [toolXXArray],
        y: [toolXYArray],
        type: "scatter",
    };
    var updateToolYGraph = {
        x: [toolYXArray],
        y: [toolYYArray],
        type: "scatter",
    };
    var updateToolZGraph = {
        x: [toolZXArray],
        y: [toolZYArray],
        type: "scatter",
    };
    var updateToolRxGraph = {
        x: [toolRxXArray],
        y: [toolRxYArray],
        type: "scatter",
    };
    var updateToolRyGraph = {
        x: [toolRyXArray],
        y: [toolRyYArray],
        type: "scatter",
    };
    var updateToolRzGraph = {
        x: [toolRzXArray],
        y: [toolRzYArray],
        type: "scatter",
    };
    if (toolTemperatureXArrayLength === 1) {
        Plotly.newPlot('toolTemperatureGraphDiv', newToolTemperatureGraph);
    }
    else {
        Plotly.restyle('toolTemperatureGraphDiv', updateToolTemperatureGraph);
    }
    if (toolVoltageXArrayLength === 1) {
        Plotly.newPlot('toolVoltageGraphDiv', newToolVoltageGraph);
    }
    else {
        Plotly.restyle('toolVoltageGraphDiv', updateToolVoltageGraph);
    }
    if (toolXXArrayLength === 1) {
        Plotly.newPlot('toolXGraphDiv', newToolXGraph);
    }
    else {
        Plotly.restyle('toolXGraphDiv', updateToolXGraph);
    }
    if (toolYXArrayLength === 1) {
        Plotly.newPlot('toolYGraphDiv', newToolYGraph);
    }
    else {
        Plotly.restyle('toolYGraphDiv', updateToolYGraph);
    }
    if (toolZXArrayLength === 1) {
        Plotly.newPlot('toolZGraphDiv', newToolZGraph);
    }
    else {
        Plotly.restyle('toolZGraphDiv', updateToolZGraph);
    }
    if (toolRxXArrayLength === 1) {
        Plotly.newPlot('toolRxGraphDiv', newToolRxGraph);
    }
    else {
        Plotly.restyle('toolRxGraphDiv', updateToolRxGraph);
    }
    if (toolRyXArrayLength === 1) {
        Plotly.newPlot('toolRyGraphDiv', newToolRyGraph);
    }
    else {
        Plotly.restyle('toolRyGraphDiv', updateToolRyGraph);
    }
    if (toolRzXArrayLength === 1) {
        Plotly.newPlot('toolRzGraphDiv', newToolRzGraph);
    }
    else {
        Plotly.restyle('toolRzGraphDiv', updateToolRzGraph);
    }
    setTimeout(invokeTimeseriesToolTask, 5000);
});
function invokeTimeseriesToolTask() {
    timeseriesToolSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesToolTask").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}