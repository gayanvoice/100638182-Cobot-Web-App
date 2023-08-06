"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesControlBoxElapsedSpan = document.getElementById("timeseriesControlBoxElapsedSpan");
const timeseriesControlBoxSpinner = document.getElementById("timeseriesControlBoxSpinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesControlBoxTask();
}).catch(function (err) {
    return console.error(err.toString());
});
var controlBoxVoltageXArray = [];
var controlBoxVoltageYArray = [];

timeseriesHubConnection.on("TimeseriesControlBoxResponse", function (message) {

    timeseriesControlBoxSpinner.style.display = 'none';

    const timeseriesControlBoxModelObject = JSON.parse(message);

    timeseriesControlBoxElapsedSpan.innerHTML = timeseriesControlBoxModelObject.Duration;

    controlBoxVoltageXArray.push(convertTimestamp(timeseriesControlBoxModelObject.LastUpdateTime))
    controlBoxVoltageYArray.push(timeseriesControlBoxModelObject.ControlBoxTwinModel.Voltage)

    const controlBoxVoltageXArrayLength = controlBoxVoltageXArray.length;

    var newControlBoxVoltageGraph = [
        {
            x: [convertTimestamp(timeseriesControlBoxModelObject.LastUpdateTime)],
            y: [timeseriesControlBoxModelObject.ControlBoxTwinModel.Voltage],
            type: 'scatter'
        }
    ];
    var updateControlBoxVoltageGraph = {
        x: [controlBoxVoltageXArray],
        y: [controlBoxVoltageYArray],
        type: "scatter",
    };
    if (controlBoxVoltageXArrayLength === 1) {
        Plotly.newPlot('controlBoxVotlageGraphDiv', newControlBoxVoltageGraph);
    }
    else {
        Plotly.restyle('controlBoxVotlageGraphDiv', updateControlBoxVoltageGraph);
    }
    setTimeout(invokeTimeseriesControlBoxTask, 5000);
});
function invokeTimeseriesControlBoxTask() {
    timeseriesControlBoxSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesControlBoxTask").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}