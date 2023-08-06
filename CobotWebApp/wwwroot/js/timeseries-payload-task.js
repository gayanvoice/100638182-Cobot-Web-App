"use strict";

const timeseriesHubConnection = new signalR.HubConnectionBuilder().withUrl("/timeseriesHub").build();

const timeseriesPayloadElapsedSpan = document.getElementById("timeseriesPayloadElapsedSpan");
const timeseriesPayloadSpinner = document.getElementById("timeseriesPayloadSpinner");

timeseriesHubConnection.start().then(function () {
    invokeTimeseriesPayloadTask();
}).catch(function (err) {
    return console.error(err.toString());
});
var payloadCogXXArray = [];
var payloadCogXYArray = [];

var payloadCogYXArray = [];
var payloadCogYYArray = [];

var payloadCogZXArray = [];
var payloadCogZYArray = [];

var payloadMassXArray = [];
var payloadMassYArray = [];


timeseriesHubConnection.on("TimeseriesPayloadResponse", function (message) {

    timeseriesPayloadSpinner.style.display = 'none';

    const timeseriesPayloadModelObject = JSON.parse(message);

    timeseriesPayloadElapsedSpan.innerHTML = timeseriesPayloadModelObject.Duration;

    payloadCogXXArray.push(convertTimestamp(timeseriesPayloadModelObject.LastUpdateTime))
    payloadCogXYArray.push(timeseriesPayloadModelObject.PayloadTwinModel.CogX)

    payloadCogYXArray.push(convertTimestamp(timeseriesPayloadModelObject.LastUpdateTime))
    payloadCogYYArray.push(timeseriesPayloadModelObject.PayloadTwinModel.CogY)

    payloadCogZXArray.push(convertTimestamp(timeseriesPayloadModelObject.LastUpdateTime))
    payloadCogZYArray.push(timeseriesPayloadModelObject.PayloadTwinModel.CogZ)

    payloadMassXArray.push(convertTimestamp(timeseriesPayloadModelObject.LastUpdateTime))
    payloadMassYArray.push(timeseriesPayloadModelObject.PayloadTwinModel.Mass)

    const payloadCogXXArrayLength = payloadCogXXArray.length;
    const payloadCogYXArrayLength = payloadCogYXArray.length;
    const payloadCogZXArrayLength = payloadCogZXArray.length;
    const payloadMassXArrayLength = payloadMassXArray.length;


    var newPayloadCogXGraph = [
        {
            x: [convertTimestamp(timeseriesPayloadModelObject.LastUpdateTime)],
            y: [timeseriesPayloadModelObject.PayloadTwinModel.CogX],
            type: 'scatter'
        }
    ];
    var newPayloadCogYGraph = [
        {
            x: [convertTimestamp(timeseriesPayloadModelObject.LastUpdateTime)],
            y: [timeseriesPayloadModelObject.PayloadTwinModel.CogY],
            type: 'scatter'
        }
    ];
    var newPayloadCogZGraph = [
        {
            x: [convertTimestamp(timeseriesPayloadModelObject.LastUpdateTime)],
            y: [timeseriesPayloadModelObject.PayloadTwinModel.CogZ],
            type: 'scatter'
        }
    ];
    var newPayloadMassGraph = [
        {
            x: [convertTimestamp(timeseriesPayloadModelObject.LastUpdateTime)],
            y: [timeseriesPayloadModelObject.PayloadTwinModel.Mass],
            type: 'scatter'
        }
    ];
    var updatePayloadCogXGraph = {
        x: [payloadCogXXArray],
        y: [payloadCogXYArray],
        type: "scatter",
    };
    var updatePayloadCogYGraph = {
        x: [payloadCogYXArray],
        y: [payloadCogYYArray],
        type: "scatter",
    };
    var updatePayloadCogZGraph = {
        x: [payloadCogZXArray],
        y: [payloadCogZYArray],
        type: "scatter",
    };
    var updatePayloadMassGraph = {
        x: [payloadMassXArray],
        y: [payloadMassYArray],
        type: "scatter",
    };
    if (payloadCogXXArrayLength === 1) {
        Plotly.newPlot('payloadCogXGraphDiv', newPayloadCogXGraph);
    }
    else {
        Plotly.restyle('payloadCogXGraphDiv', updatePayloadCogXGraph);
    }
    if (payloadCogYXArrayLength === 1) {
        Plotly.newPlot('payloadCogYGraphDiv', newPayloadCogYGraph);
    }
    else {
        Plotly.restyle('payloadCogYGraphDiv', updatePayloadCogYGraph);
    }
    if (payloadCogZXArrayLength === 1) {
        Plotly.newPlot('payloadCogZGraphDiv', newPayloadCogZGraph);
    }
    else {
        Plotly.restyle('payloadCogZGraphDiv', updatePayloadCogZGraph);
    }
    if (payloadMassXArrayLength === 1) {
        Plotly.newPlot('payloadMassGraphDiv', newPayloadMassGraph);
    }
    else {
        Plotly.restyle('payloadMassGraphDiv', updatePayloadMassGraph);
    }
    setTimeout(invokeTimeseriesPayloadTask, 5000);
});
function invokeTimeseriesPayloadTask() {
    timeseriesPayloadSpinner.style.display = 'block';
    timeseriesHubConnection.invoke("timeseriesPayloadTask").catch(function (err) {

        console.log(err.toString());
        reject(err.toString());
    });
}
function convertTimestamp(inputTimestamp) {
    const date = new Date(inputTimestamp);
    const formattedDate = `${date.getUTCFullYear()}-${(date.getUTCMonth() + 1).toString().padStart(2, '0')}-${date.getUTCDate().toString().padStart(2, '0')} ${date.getUTCHours().toString().padStart(2, '0')}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
    return formattedDate;
}