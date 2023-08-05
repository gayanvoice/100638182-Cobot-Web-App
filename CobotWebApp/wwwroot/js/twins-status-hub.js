"use strict";

const twinsHubConnection = new signalR.HubConnectionBuilder().withUrl("/twinsHub").build();

const twinsStatusElapsedSpan = document.getElementById("twinsStatusElapsedSpan");
const twinsStatusSpinner = document.getElementById("twinsStatusSpinner");

const cobotDtIdDiv = document.getElementById("cobotDtIdDiv");
const cobotEtagDiv = document.getElementById("cobotEtagDiv");
const cobotModelDiv = document.getElementById("cobotModelDiv");
const cobotLastUpdateTimeDiv = document.getElementById("cobotLastUpdateTimeDiv");

const controlBoxDtIdDiv = document.getElementById("controlBoxDtIdDiv");
const controlBoxEtagDiv = document.getElementById("controlBoxEtagDiv");
const controlBoxModelDiv = document.getElementById("controlBoxModelDiv");
const controlBoxLastUpdateTimeDiv = document.getElementById("controlBoxLastUpdateTimeDiv");

const payloadDtIdDiv = document.getElementById("payloadDtIdDiv");
const payloadEtagDiv = document.getElementById("payloadEtagDiv");
const payloadModelDiv = document.getElementById("payloadModelDiv");
const payloadLastUpdateTimeDiv = document.getElementById("payloadLastUpdateTimeDiv");

const baseDtIdDiv = document.getElementById("baseDtIdDiv");
const baseEtagDiv = document.getElementById("baseEtagDiv");
const baseModelDiv = document.getElementById("baseModelDiv");
const baseLastUpdateTimeDiv = document.getElementById("baseLastUpdateTimeDiv");

const shoulderDtIdDiv = document.getElementById("shoulderDtIdDiv");
const shoulderEtagDiv = document.getElementById("shoulderEtagDiv");
const shoulderModelDiv = document.getElementById("shoulderModelDiv");
const shoulderLastUpdateTimeDiv = document.getElementById("shoulderLastUpdateTimeDiv");

const elbowDtIdDiv = document.getElementById("elbowDtIdDiv");
const elbowEtagDiv = document.getElementById("elbowEtagDiv");
const elbowModelDiv = document.getElementById("elbowModelDiv");
const elbowLastUpdateTimeDiv = document.getElementById("elbowLastUpdateTimeDiv");

const wrist1DtIdDiv = document.getElementById("wrist1DtIdDiv");
const wrist1EtagDiv = document.getElementById("wrist1EtagDiv");
const wrist1ModelDiv = document.getElementById("wrist1ModelDiv");
const wrist1LastUpdateTimeDiv = document.getElementById("wrist1LastUpdateTimeDiv");

const wrist2DtIdDiv = document.getElementById("wrist2DtIdDiv");
const wrist2EtagDiv = document.getElementById("wrist2EtagDiv");
const wrist2ModelDiv = document.getElementById("wrist2ModelDiv");
const wrist2LastUpdateTimeDiv = document.getElementById("wrist2LastUpdateTimeDiv");

const wrist3DtIdDiv = document.getElementById("wrist3DtIdDiv");
const wrist3EtagDiv = document.getElementById("wrist3EtagDiv");
const wrist3ModelDiv = document.getElementById("wrist3ModelDiv");
const wrist3LastUpdateTimeDiv = document.getElementById("wrist3LastUpdateTimeDiv");

const toolDtIdDiv = document.getElementById("toolDtIdDiv");
const toolEtagDiv = document.getElementById("toolEtagDiv");
const toolModelDiv = document.getElementById("toolModelDiv");
const toolLastUpdateTimeDiv = document.getElementById("toolLastUpdateTimeDiv");

twinsHubConnection.start().then(function () {
    invokeTwinsStatusTask();
}).catch(function (err) {
    return console.error(err.toString());
});

twinsHubConnection.on("TwinsStatusResponse", function (message) {

    twinsStatusSpinner.style.display = 'none';
    const twinsStatusModelObject = JSON.parse(message);

    twinsStatusElapsedSpan.innerHTML = twinsStatusModelObject.Duration;

    cobotDtIdDiv.innerHTML = twinsStatusModelObject.CobotTwinHubModel.Value.DtId;
    cobotEtagDiv.innerHTML = twinsStatusModelObject.CobotTwinHubModel.Value.Etag;
    cobotModelDiv.innerHTML = twinsStatusModelObject.CobotTwinHubModel.Value.Metadata.Model;
    cobotLastUpdateTimeDiv.innerHTML = twinsStatusModelObject.CobotTwinHubModel.Value.Metadata.LastUpdateTime;

    controlBoxDtIdDiv.innerHTML = twinsStatusModelObject.ControlBoxTwinHubModel.Value.DtId;
    controlBoxEtagDiv.innerHTML = twinsStatusModelObject.ControlBoxTwinHubModel.Value.Etag;
    controlBoxModelDiv.innerHTML = twinsStatusModelObject.ControlBoxTwinHubModel.Value.Metadata.Model;
    controlBoxLastUpdateTimeDiv.innerHTML = twinsStatusModelObject.ControlBoxTwinHubModel.Value.Metadata.LastUpdateTime;

    payloadDtIdDiv.innerHTML = twinsStatusModelObject.PayloadTwinHubModel.Value.DtId;
    payloadEtagDiv.innerHTML = twinsStatusModelObject.PayloadTwinHubModel.Value.Etag;
    payloadModelDiv.innerHTML = twinsStatusModelObject.PayloadTwinHubModel.Value.Metadata.Model;
    payloadLastUpdateTimeDiv.innerHTML = twinsStatusModelObject.PayloadTwinHubModel.Value.Metadata.LastUpdateTime;

    baseDtIdDiv.innerHTML = twinsStatusModelObject.BaseTwinHubModel.Value.DtId;
    baseEtagDiv.innerHTML = twinsStatusModelObject.BaseTwinHubModel.Value.Etag;
    baseModelDiv.innerHTML = twinsStatusModelObject.BaseTwinHubModel.Value.Metadata.Model;
    baseLastUpdateTimeDiv.innerHTML = twinsStatusModelObject.BaseTwinHubModel.Value.Metadata.LastUpdateTime;

    shoulderDtIdDiv.innerHTML = twinsStatusModelObject.ShoulderTwinHubModel.Value.DtId;
    shoulderEtagDiv.innerHTML = twinsStatusModelObject.ShoulderTwinHubModel.Value.Etag;
    shoulderModelDiv.innerHTML = twinsStatusModelObject.ShoulderTwinHubModel.Value.Metadata.Model;
    shoulderLastUpdateTimeDiv.innerHTML = twinsStatusModelObject.ShoulderTwinHubModel.Value.Metadata.LastUpdateTime;

    elbowDtIdDiv.innerHTML = twinsStatusModelObject.ElbowTwinHubModel.Value.DtId;
    elbowEtagDiv.innerHTML = twinsStatusModelObject.ElbowTwinHubModel.Value.Etag;
    elbowModelDiv.innerHTML = twinsStatusModelObject.ElbowTwinHubModel.Value.Metadata.Model;
    elbowLastUpdateTimeDiv.innerHTML = twinsStatusModelObject.ElbowTwinHubModel.Value.Metadata.LastUpdateTime;

    wrist1DtIdDiv.innerHTML = twinsStatusModelObject.Wrist1TwinHubModel.Value.DtId;
    wrist1EtagDiv.innerHTML = twinsStatusModelObject.Wrist1TwinHubModel.Value.Etag;
    wrist1ModelDiv.innerHTML = twinsStatusModelObject.Wrist1TwinHubModel.Value.Metadata.Model;
    wrist1LastUpdateTimeDiv.innerHTML = twinsStatusModelObject.Wrist1TwinHubModel.Value.Metadata.LastUpdateTime;

    wrist2DtIdDiv.innerHTML = twinsStatusModelObject.Wrist2TwinHubModel.Value.DtId;
    wrist2EtagDiv.innerHTML = twinsStatusModelObject.Wrist2TwinHubModel.Value.Etag;
    wrist2ModelDiv.innerHTML = twinsStatusModelObject.Wrist2TwinHubModel.Value.Metadata.Model;
    wrist2LastUpdateTimeDiv.innerHTML = twinsStatusModelObject.Wrist2TwinHubModel.Value.Metadata.LastUpdateTime;

    wrist3DtIdDiv.innerHTML = twinsStatusModelObject.Wrist3TwinHubModel.Value.DtId;
    wrist3EtagDiv.innerHTML = twinsStatusModelObject.Wrist3TwinHubModel.Value.Etag;
    wrist3ModelDiv.innerHTML = twinsStatusModelObject.Wrist3TwinHubModel.Value.Metadata.Model;
    wrist3LastUpdateTimeDiv.innerHTML = twinsStatusModelObject.Wrist3TwinHubModel.Value.Metadata.LastUpdateTime;

    toolDtIdDiv.innerHTML = twinsStatusModelObject.ToolTwinHubModel.Value.DtId;
    toolEtagDiv.innerHTML = twinsStatusModelObject.ToolTwinHubModel.Value.Etag;
    toolModelDiv.innerHTML = twinsStatusModelObject.ToolTwinHubModel.Value.Metadata.Model;
    toolLastUpdateTimeDiv.innerHTML = twinsStatusModelObject.ToolTwinHubModel.Value.Metadata.LastUpdateTime;

    setTimeout(invokeTwinsStatusTask, 5000);
});
function invokeTwinsStatusTask() {
    twinsStatusSpinner.style.display = 'block';
    twinsHubConnection.invoke("TwinsStatusTask").catch(function (err) {
        console.log(err.toString());

        cobotDtIdDiv.innerHTML = "Not Syncing";
        cobotEtagDiv.innerHTML = "Not Syncing";
        cobotModelDiv.innerHTML = "Not Syncing";
        cobotLastUpdateTimeDiv.innerHTML = "Not Syncing";

        controlBoxDtIdDiv.innerHTML = "Not Syncing";
        controlBoxEtagDiv.innerHTML = "Not Syncing";
        controlBoxModelDiv.innerHTML = "Not Syncing";
        controlBoxLastUpdateTimeDiv.innerHTML = "Not Syncing";

        payloadDtIdDiv.innerHTML = "Not Syncing";
        payloadEtagDiv.innerHTML = "Not Syncing";
        payloadModelDiv.innerHTML = "Not Syncing";
        payloadLastUpdateTimeDiv.innerHTML = "Not Syncing";

        baseDtIdDiv.innerHTML = "Not Syncing";
        baseEtagDiv.innerHTML = "Not Syncing";
        baseModelDiv.innerHTML = "Not Syncing";
        baseLastUpdateTimeDiv.innerHTML = "Not Syncing";

        shoulderDtIdDiv.innerHTML = "Not Syncing";
        shoulderEtagDiv.innerHTML = "Not Syncing";
        shoulderModelDiv.innerHTML = "Not Syncing";
        shoulderLastUpdateTimeDiv.innerHTML = "Not Syncing";

        elbowDtIdDiv.innerHTML = "Not Syncing";
        elbowEtagDiv.innerHTML = "Not Syncing";
        elbowModelDiv.innerHTML = "Not Syncing";
        elbowLastUpdateTimeDiv.innerHTML = "Not Syncing";

        wrist1DtIdDiv.innerHTML = "Not Syncing";
        wrist1EtagDiv.innerHTML = "Not Syncing";
        wrist1ModelDiv.innerHTML = "Not Syncing";
        wrist1LastUpdateTimeDiv.innerHTML = "Not Syncing";

        wrist2DtIdDiv.innerHTML = "Not Syncing";
        wrist2EtagDiv.innerHTML = "Not Syncing";
        wrist2ModelDiv.innerHTML = "Not Syncing";
        wrist2LastUpdateTimeDiv.innerHTML = "Not Syncing";

        wrist3DtIdDiv.innerHTML = "Not Syncing";
        wrist3EtagDiv.innerHTML = "Not Syncing";
        wrist3ModelDiv.innerHTML = "Not Syncing";
        wrist3LastUpdateTimeDiv.innerHTML = "Not Syncing";

        toolDtIdDiv.innerHTML = "Not Syncing";
        toolEtagDiv.innerHTML = "Not Syncing";
        toolModelDiv.innerHTML = "Not Syncing";
        toolLastUpdateTimeDiv.innerHTML = "Not Syncing";

        reject(err.toString());
    });
}
