"use strict";

const twinsHubConnection = new signalR.HubConnectionBuilder().withUrl("/twinsHub").build();

const twinsSimulationElapsedSpan = document.getElementById("twinsSimulationElapsedSpan");
const twinsSimulationSpinner = document.getElementById("twinsSimulationSpinner");

twinsHubConnection.start().then(function () {
    invokeTwinsSimulationTask();
}).catch(function (err) {
    return console.error(err.toString());
});
var elbowXArray = [];
var elbowYArray = [];
var elbowZArray = [];

var toolXArray = [];
var toolYArray = [];
var toolZArray = [];

twinsHubConnection.on("TwinsSimulationResponse", function (message) {

    twinsSimulationSpinner.style.display = 'none';
    const twinsSimulationModelObject = JSON.parse(message);
    twinsSimulationElapsedSpan.innerHTML = twinsSimulationModelObject.Duration;

    elbowXArray.push(twinsSimulationModelObject.ElbowTwinModel.X)
    elbowYArray.push(twinsSimulationModelObject.ElbowTwinModel.Y)
    elbowZArray.push(twinsSimulationModelObject.ElbowTwinModel.Z)

    toolXArray.push(twinsSimulationModelObject.ToolTwinModel.X)
    toolYArray.push(twinsSimulationModelObject.ToolTwinModel.Y)
    toolZArray.push(twinsSimulationModelObject.ToolTwinModel.Z)

    const elbowArrayLength = elbowXArray.length;
    const toolArrayLength = toolXArray.length;

    var elbow = {
        x: [0],
        y: [0],
        z: [0],
        name: 'elbow',
        type: 'scatter3d'
    };
    var elbowUpdate = {
        x: [elbowXArray],
        y: [elbowYArray],
        z: [elbowZArray],
        name: 'elbow'
    };

    var tool = {
        x: [0],
        y: [0],
        z: [0],
        name: 'tool',
        type: 'scatter3d'
    };

    var toolUpdate = {
        x: [toolXArray],
        y: [toolYArray],
        z: [toolZArray],
        name: 'tool'
    };
    var layout = {
        autosize: true,
        margin: {
            l: 0,
            r: 0,
            b: 0,
            t: 0
        },
        xaxis: {
            title: "This",
        },
        yaxis: {
            title: "That"
        },
        zaxis: {
            title: "where"
        }
    };
    if (elbowArrayLength === 1) {
        var data = [elbow, tool];
        Plotly.newPlot('elbowGraphDiv', data, layout);
    }
    else {
        Plotly.restyle('elbowGraphDiv', elbowUpdate);
    }

    if (toolArrayLength === 1) {
        var data = [elbow, tool];
        Plotly.newPlot('toolGraphDiv', data, layout);
    }
    else {
        Plotly.restyle('toolGraphDiv', toolUpdate);
    }
    setTimeout(invokeTwinsSimulationTask, 5000);
});
function invokeTwinsSimulationTask() {
    twinsSimulationSpinner.style.display = 'block';
    twinsHubConnection.invoke("TwinsSimulationTask").catch(function (err) {
        console.log(err.toString());
        reject(err.toString());
    });
}
