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
    invokeTimeseriesStatusTask();
}).catch(function (err) {
    return console.error(err.toString());
});

timeseriesHubConnection.on("TimeseriesStatusResponse", function (message) {
    timeseriesDashboardSpinner.style.display = 'none';
    const timeseriesStatusModelObject = JSON.parse(message);

    timeseriesDashboardElapsedSpan.innerHTML = timeseriesStatusModelObject.Duration;

    cobotStatusLabelDiv.innerHTML = timeseriesStatusModelObject.CobotStatusLabel;
    controlBoxStatusLabelDiv.innerHTML = timeseriesStatusModelObject.ControlBoxStatusLabel;
    payloadStatusLabelDiv.innerHTML = timeseriesStatusModelObject.PayloadStatusLabel;
    baseStatusLabelDiv.innerHTML = timeseriesStatusModelObject.BaseStatusLabel;
    shoulderStatusLabelDiv.innerHTML = timeseriesStatusModelObject.ShoulderStatusLabel;
    elbowStatusLabelDiv.innerHTML = timeseriesStatusModelObject.ElbowStatusLabel;
    wrist1StatusLabelDiv.innerHTML = timeseriesStatusModelObject.Wrist1StatusLabel;
    wrist2StatusLabelDiv.innerHTML = timeseriesStatusModelObject.Wrist2StatusLabel;
    wrist3StatusLabelDiv.innerHTML = timeseriesStatusModelObject.Wrist3StatusLabel;
    toolStatusLabelDiv.innerHTML = timeseriesStatusModelObject.ToolStatusLabel;

    setTimeout(invokeTimeseriesStatusTask, 5000);
});
function invokeTimeseriesStatusTask() {
    timeseriesDashboardSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("TimeseriesStatusTask").catch(function (err) {
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
