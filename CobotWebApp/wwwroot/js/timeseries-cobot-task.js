"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesCobotElapsedSpan = document.getElementById("timeseriesCobotElapsedSpan");
const timeseriesCobotSpinner = document.getElementById("timeseriesCobotSpinner");

timeseriesHubConnection.start().then(function () {
    invokeTwinsSimulationTask();
}).catch(function (err) {
    return console.error(err.toString());
});
var cobotElapsedTimeXArray = [];
var cobotElapsedTimeYArray = [];

timeseriesHubConnection.on("TimeseriesCobotResponse", function (message) {

    timeseriesCobotSpinner.style.display = 'none';

    const timeseriesCobotModelObject = JSON.parse(message);

    timeseriesCobotElapsedSpan.innerHTML = timeseriesCobotModelObject.Duration;

    cobotElapsedTimeXArray.push(convertTimestamp(timeseriesCobotModelObject.LastUpdateTime))
    cobotElapsedTimeYArray.push(timeseriesCobotModelObject.CobotTwinModel.ElapsedTime)

    const elbowArrayLength = cobotElapsedTimeXArray.length;

    var newCobotElapsedTimeGraph = [
        {
            x: [convertTimestamp(timeseriesCobotModelObject.LastUpdateTime)],
            y: [timeseriesCobotModelObject.CobotTwinModel.ElapsedTime],
            type: 'scatter'
        }
    ];
    var updateCobotElapsedTimeGraph = {
        x: [cobotElapsedTimeXArray],
        y: [cobotElapsedTimeYArray],
        type: "scatter",
    };
    if (elbowArrayLength === 1) {
        Plotly.newPlot('cobotElapsedTimeGraphDiv', newCobotElapsedTimeGraph);
    }
    else {
        Plotly.restyle('cobotElapsedTimeGraphDiv', updateCobotElapsedTimeGraph);
    }
    setTimeout(invokeTwinsSimulationTask, 5000);
});
function invokeTwinsSimulationTask() {
    timeseriesCobotSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesCobotTask").catch(function (err) {
        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}