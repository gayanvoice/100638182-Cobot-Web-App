"use strict";

var uploadDtdlModelHubConnection = new signalR.HubConnectionBuilder().withUrl("/adtModelHub").build();
var createAdtTwinHubConnection = new signalR.HubConnectionBuilder().withUrl("/adtTwinHub").build();
var createAdtRelationshipHubConnection = new signalR.HubConnectionBuilder().withUrl("/adtRelationshipHub").build();

document.getElementById("adtSyncButton").disabled = true;

const uploadIcon = "<i class=\"bi bi-cloud-upload\"></i>";
const replaceIcon = "<i class=\"bi bi-cloud\"></i>";
const syncIcon = "<i class=\"bi bi-arrow-repeat\"></i>";


const adtCobotDtdlModelElement = document.getElementById("adt-cobot-dtdl-model");
const adtControlBoxDtdlModelElement = document.getElementById("adt-control-box-dtdl-model");
const adtJointLoadDtdlModelElement = document.getElementById("adt-joint-load-dtdl-model");
const adtPayloadDtdlModelElement = document.getElementById("adt-payload-dtdl-model");
const adtBaseDtdlModelElement = document.getElementById("adt-base-dtdl-model");
const adtShoulderDtdlModelElement = document.getElementById("adt-shoulder-dtdl-model");
const adtElbowDtdlModelElement = document.getElementById("adt-elbow-dtdl-model");
const adtWrist1DtdlModelElement = document.getElementById("adt-wrist1-dtdl-model");
const adtWrist2DtdlModelElement = document.getElementById("adt-wrist2-dtdl-model");
const adtWrist3DtdlModelElement = document.getElementById("adt-wrist3-dtdl-model");
const adtToolDtdlModelElement = document.getElementById("adt-tool-dtdl-model");

const adtCobotAdtTwinElement = document.getElementById("adt-cobot-adt-twin");
const adtControlBoxAdtTwinElement = document.getElementById("adt-control-box-adt-twin");
const adtJointLoadAdtTwinElement = document.getElementById("adt-joint-load-adt-twin");
const adtPayloadAdtTwinElement = document.getElementById("adt-payload-adt-twin");
const adtBaseAdtTwinElement = document.getElementById("adt-base-adt-twin");
const adtShoulderAdtTwinElement = document.getElementById("adt-shoulder-adt-twin");
const adtElbowAdtTwinElement = document.getElementById("adt-elbow-adt-twin");
const adtWrist1AdtTwinElement = document.getElementById("adt-wrist1-adt-twin");
const adtWrist2AdtTwinElement = document.getElementById("adt-wrist2-adt-twin");
const adtWrist3AdtTwinElement = document.getElementById("adt-wrist3-adt-twin");
const adtToolAdtTwinElement = document.getElementById("adt-tool-adt-twin");

const adtCobotAdtRelationshipElement = document.getElementById("adt-cobot-adt-relationship");
const adtControlBoxAdtRelationshipElement = document.getElementById("adt-control-box-adt-relationship");
const adtJointLoadAdtRelationshipElement = document.getElementById("adt-joint-load-adt-relationship");
const adtPayloadAdtRelationshipElement = document.getElementById("adt-payload-adt-relationship");
const adtBaseAdtRelationshipElement = document.getElementById("adt-base-adt-relationship");
const adtShoulderAdtRelationshipElement = document.getElementById("adt-shoulder-adt-relationship");
const adtElbowAdtRelationshipElement = document.getElementById("adt-elbow-adt-relationship");
const adtWrist1AdtRelationshipElement = document.getElementById("adt-wrist1-adt-relationship");
const adtWrist2AdtRelationshipElement = document.getElementById("adt-wrist2-adt-relationship");
const adtWrist3AdtRelationshipElement = document.getElementById("adt-wrist3-adt-relationship");
const adtToolAdtRelationshipElement = document.getElementById("adt-tool-adt-relationship");

var totalDurationAdt = 0;

uploadDtdlModelHubConnection.start().then(function () {
    document.getElementById("adtSyncButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

createAdtTwinHubConnection.start().then(function () {
    document.getElementById("adtSyncButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

createAdtRelationshipHubConnection.start().then(function () {
    document.getElementById("adtSyncButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


uploadDtdlModelHubConnection.on("ReceiveUploadCobotMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotDtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotDtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadControlBoxMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtControlBoxDtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtControlBoxDtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadJointLoadMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtJointLoadDtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtJointLoadDtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadPayloadMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtPayloadDtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtPayloadDtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadBaseMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtBaseDtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtBaseDtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadShoulderMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtShoulderDtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtShoulderDtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadElbowMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtElbowDtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtElbowDtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadWrist1Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtWrist1DtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtWrist1DtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadWrist2Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtWrist2DtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtWrist2DtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadWrist3Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtWrist3DtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtWrist3DtdlModelElement.innerHTML = replaceIcon;
    }
});
uploadDtdlModelHubConnection.on("ReceiveUploadToolMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtToolDtdlModelElement.innerHTML = uploadIcon;
    }
    else {
        adtToolDtdlModelElement.innerHTML = replaceIcon;
    }
});

createAdtTwinHubConnection.on("ReceiveCreateCobotMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtTwinElement.innerHTML = replaceIcon;
    }
});

createAdtTwinHubConnection.on("ReceiveCreateControlBoxMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtControlBoxAdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtControlBoxAdtTwinElement.innerHTML = replaceIcon;
    }
});

createAdtTwinHubConnection.on("ReceiveCreateJointLoadMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtJointLoadAdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtJointLoadAdtTwinElement.innerHTML = replaceIcon;
    }
});
createAdtTwinHubConnection.on("ReceiveCreatePayloadMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtPayloadAdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtPayloadAdtTwinElement.innerHTML = replaceIcon;
    }
});
createAdtTwinHubConnection.on("ReceiveCreateBaseMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtBaseAdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtBaseAdtTwinElement.innerHTML = replaceIcon;
    }
});
createAdtTwinHubConnection.on("ReceiveCreateShoulderMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtShoulderAdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtShoulderAdtTwinElement.innerHTML = replaceIcon;
    }
});
createAdtTwinHubConnection.on("ReceiveCreateElbowMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtElbowAdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtElbowAdtTwinElement.innerHTML = replaceIcon;
    }
});
createAdtTwinHubConnection.on("ReceiveCreateWrist1Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtWrist1AdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtWrist1AdtTwinElement.innerHTML = replaceIcon;
    }
});
createAdtTwinHubConnection.on("ReceiveCreateWrist2Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtWrist2AdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtWrist2AdtTwinElement.innerHTML = replaceIcon;
    }
});
createAdtTwinHubConnection.on("ReceiveCreateWrist3Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtWrist3AdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtWrist3AdtTwinElement.innerHTML = replaceIcon;
    }
});
createAdtTwinHubConnection.on("ReceiveCreateToolMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtToolAdtTwinElement.innerHTML = uploadIcon;
    }
    else {
        adtToolAdtTwinElement.innerHTML = replaceIcon;
    }
});

createAdtRelationshipHubConnection.on("ReceiveCreateCobotToControlBoxMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtControlBoxAdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtControlBoxAdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateCobotToJointLoadMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtJointLoadAdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtJointLoadAdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateCobotToPayloadMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtPayloadAdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtPayloadAdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateJointLoadToBaseMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtBaseAdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtBaseAdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateJointLoadToShoulderMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtShoulderAdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtShoulderAdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateJointLoadToElbowMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtElbowAdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtElbowAdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateJointLoadToWrist1Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtWrist1AdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtWrist1AdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateJointLoadToWrist2Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtWrist2AdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtWrist2AdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateJointLoadToWrist3Message", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtWrist3AdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtWrist3AdtRelationshipElement.innerHTML = replaceIcon;
    }
});
createAdtRelationshipHubConnection.on("ReceiveCreateJointLoadToToolMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        adtCobotAdtRelationshipElement.innerHTML = uploadIcon;
        adtToolAdtRelationshipElement.innerHTML = uploadIcon;
    }
    else {
        adtCobotAdtRelationshipElement.innerHTML = replaceIcon;
        adtToolAdtRelationshipElement.innerHTML = replaceIcon;
    }
});
document.getElementById("adtSyncButton").addEventListener("click", function (event) {

    totalDurationAdt = 0;

    adtJointLoadDtdlModelElement.innerHTML = syncIcon;
    adtCobotDtdlModelElement.innerHTML = syncIcon;
    adtControlBoxDtdlModelElement.innerHTML = syncIcon;
    adtJointLoadDtdlModelElement.innerHTML = syncIcon;
    adtPayloadDtdlModelElement.innerHTML = syncIcon;
    adtBaseDtdlModelElement.innerHTML = syncIcon;
    adtShoulderDtdlModelElement.innerHTML = syncIcon;
    adtElbowDtdlModelElement.innerHTML = syncIcon;
    adtWrist1DtdlModelElement.innerHTML = syncIcon;
    adtWrist2DtdlModelElement.innerHTML = syncIcon;
    adtWrist3DtdlModelElement.innerHTML = syncIcon;
    adtToolDtdlModelElement.innerHTML = syncIcon;

    adtCobotAdtTwinElement.innerHTML = syncIcon;
    adtControlBoxAdtTwinElement.innerHTML = syncIcon;
    adtJointLoadAdtTwinElement.innerHTML = syncIcon;
    adtPayloadAdtTwinElement.innerHTML = syncIcon;
    adtBaseAdtTwinElement.innerHTML = syncIcon;
    adtShoulderAdtTwinElement.innerHTML = syncIcon;
    adtElbowAdtTwinElement.innerHTML = syncIcon;
    adtWrist1AdtTwinElement.innerHTML = syncIcon;
    adtWrist2AdtTwinElement.innerHTML = syncIcon;
    adtWrist3AdtTwinElement.innerHTML = syncIcon;
    adtToolAdtTwinElement.innerHTML = syncIcon;

    adtCobotAdtRelationshipElement.innerHTML = syncIcon;
    adtControlBoxAdtRelationshipElement.innerHTML = syncIcon;
    adtJointLoadAdtRelationshipElement.innerHTML = syncIcon;
    adtPayloadAdtRelationshipElement.innerHTML = syncIcon;
    adtBaseAdtRelationshipElement.innerHTML = syncIcon;
    adtShoulderAdtRelationshipElement.innerHTML = syncIcon;
    adtElbowAdtRelationshipElement.innerHTML = syncIcon;
    adtWrist1AdtRelationshipElement.innerHTML = syncIcon;
    adtWrist2AdtRelationshipElement.innerHTML = syncIcon;
    adtWrist3AdtRelationshipElement.innerHTML = syncIcon;
    adtToolAdtRelationshipElement.innerHTML = syncIcon;

    const uploadCobotPromise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadCobot").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadControlBoxPromise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadControlBox").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadJointLoadPromise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadJointLoad").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadPayloadPromise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadPayload").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadBasePromise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadBase").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadShoulderPromise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadShoulder").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadElbowPromise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadElbow").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadWrist1Promise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadWrist1").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadWrist2Promise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadWrist2").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadWrist3Promise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadWrist3").catch(function (err) {
            reject(err.toString());
        });
    });
    const uploadToolPromise = new Promise((resolve, reject) => {
        uploadDtdlModelHubConnection.invoke("UploadTool").catch(function (err) {
            reject(err.toString());
        });
    });
    const createCobotPromise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateCobot").catch(function (err) {
            reject(err.toString());
        });
    });
    const createControlBoxPromise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateControlBox").catch(function (err) {
            reject(err.toString());
        });
    });
    const createJointLoadPromise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateJointLoad").catch(function (err) {
            reject(err.toString());
        });
    });
    const createPayloadPromise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreatePayload").catch(function (err) {
            reject(err.toString());
        });
    });
    const createBasePromise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateBase").catch(function (err) {
            reject(err.toString());
        });
    });
    const createShoulderPromise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateShoulder").catch(function (err) {
            reject(err.toString());
        });
    });
    const createElbowPromise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateElbow").catch(function (err) {
            reject(err.toString());
        });
    });
    const createWrist1Promise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateWrist1").catch(function (err) {
            reject(err.toString());
        });
    });
    const createWrist2Promise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateWrist2").catch(function (err) {
            reject(err.toString());
        });
    });
    const createWrist3Promise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateWrist3").catch(function (err) {
            reject(err.toString());
        });
    });
    const createToolPromise = new Promise((resolve, reject) => {
        createAdtTwinHubConnection.invoke("CreateTool").catch(function (err) {
            reject(err.toString());
        });
    });
    const createCobotToControlBoxPromise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateCobotToControlBox").catch(function (err) {
            reject(err.toString());
        });
    });
    const createCobotToJointLoadPromise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateCobotToJointLoad").catch(function (err) {
            reject(err.toString());
        });
    });
    const createCobotToPayloadPromise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateCobotToPayload").catch(function (err) {
            reject(err.toString());
        });
    });
    const CreateJointLoadToBasePromise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateJointLoadToBase").catch(function (err) {
            reject(err.toString());
        });
    });
    const CreateJointLoadToShoulderPromise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateJointLoadToShoulder").catch(function (err) {
            reject(err.toString());
        });
    });
    const CreateJointLoadToElbowPromise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateJointLoadToElbow").catch(function (err) {
            reject(err.toString());
        });
    });
    const CreateJointLoadToWrist1Promise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateJointLoadToWrist1").catch(function (err) {
            reject(err.toString());
        });
    });
    const CreateJointLoadToWrist2Promise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateJointLoadToWrist2").catch(function (err) {
            reject(err.toString());
        });
    });
    const CreateJointLoadToWrist3Promise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateJointLoadToWrist3").catch(function (err) {
            reject(err.toString());
        });
    });
    const CreateJointLoadToolPromise = new Promise((resolve, reject) => {
        createAdtRelationshipHubConnection.invoke("CreateJointLoadToTool").catch(function (err) {
            reject(err.toString());
        });
    });
    new Promise(uploadCobotPromise)
        .then(uploadControlBoxPromise)
        .then(uploadJointLoadPromise)
        .then(uploadPayloadPromise)
        .then(uploadBasePromise)
        .then(uploadShoulderPromise)
        .then(uploadElbowPromise)
        .then(uploadWrist1Promise)
        .then(uploadWrist2Promise)
        .then(uploadWrist3Promise)
        .then(uploadToolPromise)
        .then(createCobotPromise)
        .then(createControlBoxPromise)
        .then(createJointLoadPromise)
        .then(createPayloadPromise)
        .then(createBasePromise)
        .then(createShoulderPromise)
        .then(createElbowPromise)
        .then(createWrist1Promise)
        .then(createWrist2Promise)
        .then(createWrist3Promise)
        .then(createToolPromise)
        .then(createCobotToControlBoxPromise)
        .then(createCobotToJointLoadPromise)
        .then(createCobotToPayloadPromise)
        .then(CreateJointLoadToBasePromise)
        .then(CreateJointLoadToShoulderPromise)
        .then(CreateJointLoadToElbowPromise)
        .then(CreateJointLoadToWrist1Promise)
        .then(CreateJointLoadToWrist2Promise)
        .then(CreateJointLoadToWrist3Promise)
        .then(CreateJointLoadToolPromise)
});


function getTotalDurationAdt(duration) {
    totalDurationAdt = totalDurationAdt + duration;
    var adtTitleElement = document.getElementById("adt-title");
    adtTitleElement.innerHTML = totalDurationAdt.toFixed(4) + "ms";
}