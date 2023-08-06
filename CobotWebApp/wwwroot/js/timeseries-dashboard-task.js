"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesDashboardElapsedSpan = document.getElementById("timeseriesDashboardElapsedSpan");
const timeseriesDashboardSpinner = document.getElementById("timeseriesDashboardSpinner");

const cobotStatusLabelDiv = document.getElementById("cobotStatusLabelDiv");
const controlBoxStatusLabelDiv = document.getElementById("controlBoxStatusLabelDiv");
const payloadStatusLabelDiv = document.getElementById("payloadStatusLabelDiv");
const baseStatusLabelDiv = document.getElementById("baseStatusLabelDiv");
const shoulderStatusLabelDiv = document.getElementById("shoulderStatusLabelDiv");
const elbowStatusLabelDiv = document.getElementById("elbowStatusLabelDiv");
const wrist1StatusLabelDiv = document.getElementById("wrist1StatusLabelDiv");
const wrist2StatusLabelDiv = document.getElementById("wrist2StatusLabelDiv");
const wrist3StatusLabelDiv = document.getElementById("wrist3StatusLabelDiv");
const toolStatusLabelDiv = document.getElementById("toolStatusLabelDiv");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesDashboardTask();
}).catch(function (err) {
    return console.error(err.toString());
});

timeseriesHubConnection.on("TimeseriesDashboardResponse", function (message) {
    timeseriesDashboardSpinner.style.display = 'none';
    const timeseriesDashboardModelObject = JSON.parse(message);

    timeseriesDashboardElapsedSpan.innerHTML = timeseriesDashboardModelObject.Duration;

    cobotStatusLabelDiv.innerHTML = timeseriesDashboardModelObject.CobotStatusLabel;
    controlBoxStatusLabelDiv.innerHTML = timeseriesDashboardModelObject.ControlBoxStatusLabel;
    payloadStatusLabelDiv.innerHTML = timeseriesDashboardModelObject.PayloadStatusLabel;
    baseStatusLabelDiv.innerHTML = timeseriesDashboardModelObject.BaseStatusLabel;
    shoulderStatusLabelDiv.innerHTML = timeseriesDashboardModelObject.ShoulderStatusLabel;
    elbowStatusLabelDiv.innerHTML = timeseriesDashboardModelObject.ElbowStatusLabel;
    wrist1StatusLabelDiv.innerHTML = timeseriesDashboardModelObject.Wrist1StatusLabel;
    wrist2StatusLabelDiv.innerHTML = timeseriesDashboardModelObject.Wrist2StatusLabel;
    wrist3StatusLabelDiv.innerHTML = timeseriesDashboardModelObject.Wrist3StatusLabel;
    toolStatusLabelDiv.innerHTML = timeseriesDashboardModelObject.ToolStatusLabel;

    setTimeout(invokeTimeseriesDashboardTask, 5000);
});
function invokeTimeseriesDashboardTask() {
    timeseriesDashboardSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("TimeseriesDashboardTask").catch(function (err) {
        console.log(err.toString());

        cobotStatusLabelDiv.innerHTML = "Not Syncing";
        controlBoxStatusLabelDiv.innerHTML = "Not Syncing";
        payloadStatusLabelDiv.innerHTML = "Not Syncing";
        baseStatusLabelDiv.innerHTML = "Not Syncing";
        shoulderStatusLabelDiv.innerHTML = "Not Syncing";
        elbowStatusLabelDiv.innerHTML = "Not Syncing";
        wrist1StatusLabelDiv.innerHTML = "Not Syncing";
        wrist2StatusLabelDiv.innerHTML = "Not Syncing";
        wrist3StatusLabelDiv.innerHTML = "Not Syncing";
        toolStatusLabelDiv.innerHTML = "Not Syncing";

        reject(err.toString());
    });
}
