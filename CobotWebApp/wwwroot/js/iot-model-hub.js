"use strict";

var iotTwinHubConnection = new signalR.HubConnectionBuilder().withUrl("/iotTwinHub").build();

document.getElementById("iotStartSyncButton").disabled = true;
document.getElementById("iotStopSyncButton").disabled = true;

const iotOkIcon = "<i class=\"bi bi-check-all\"></i>";
const iotErrorIcon = "<i class=\"bi bi-x\"></i>";
const iotSyncIcon = "<i class=\"bi bi-arrow-repeat\"></i>";

var iotOperationStatus = true;

const iotCobotElement = document.getElementById("iot-cobot");
const iotControlBoxElement = document.getElementById("iot-control-box");
const iotPayloadElement = document.getElementById("iot-payload");
const iotBaseElement = document.getElementById("iot-base");
const iotShoulderElement = document.getElementById("iot-shoulder");
const iotElbowElement = document.getElementById("iot-elbow");
const iotWrist1Element = document.getElementById("iot-wrist1");
const iotWrist2Element = document.getElementById("iot-wrist2");
const iotWrist3Element = document.getElementById("iot-wrist3");
const iotToolElement = document.getElementById("iot-tool");

var totalDurationIot = 0;

iotTwinHubConnection.start().then(function () {
    document.getElementById("iotStartSyncButton").disabled = false;
    document.getElementById("iotStopSyncButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


iotTwinHubConnection.on("ReceiveCobotStartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotCobotElement.innerHTML = iotOkIcon;
    }
    else {
        iotCobotElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveControlBoxStartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotControlBoxElement.innerHTML = iotOkIcon;
    }
    else {
        iotControlBoxElement.innerHTML = iotErrorIcon;
    }
});


iotTwinHubConnection.on("ReceivePayloadStartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotPayloadElement.innerHTML = iotOkIcon;
    }
    else {
        iotPayloadElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveBaseStartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotBaseElement.innerHTML = iotOkIcon;
    }
    else {
        iotBaseElement.innerHTML = iotErrorIcon;
    }
});

iotTwinHubConnection.on("ReceiveShoulderStartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotShoulderElement.innerHTML = iotOkIcon;
    }
    else {
        iotShoulderElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveElbowStartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotElbowElement.innerHTML = iotOkIcon;
    }
    else {
        iotElbowElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveWrist1StartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotWrist1Element.innerHTML = iotOkIcon;
    }
    else {
        iotWrist1Element.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveWrist2StartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotWrist2Element.innerHTML = iotOkIcon;
    }
    else {
        iotWrist2Element.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveWrist3StartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotWrist3Element.innerHTML = iotOkIcon;
    }
    else {
        iotWrist3Element.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveToolStartIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotToolElement.innerHTML = iotOkIcon;
    }
    else {
        iotToolElement.innerHTML = iotErrorIcon;
    }
});


iotTwinHubConnection.on("ReceiveCobotStopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotCobotElement.innerHTML = iotOkIcon;
    }
    else {
        iotCobotElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveControlBoxStopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotControlBoxElement.innerHTML = iotOkIcon;
    }
    else {
        iotControlBoxElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceivePayloadStopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotPayloadElement.innerHTML = iotOkIcon;
    }
    else {
        iotPayloadElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveBaseStopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotBaseElement.innerHTML = iotOkIcon;
    }
    else {
        iotBaseElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveShoulderStopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotShoulderElement.innerHTML = iotOkIcon;
    }
    else {
        iotShoulderElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveElbowStopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotElbowElement.innerHTML = iotOkIcon;
    }
    else {
        iotElbowElement.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveWrist1StopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotWrist1Element.innerHTML = iotOkIcon;
    }
    else {
        iotWrist1Element.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveWrist2StopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotWrist2Element.innerHTML = iotOkIcon;
    }
    else {
        iotWrist2Element.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveWrist3StopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotWrist3Element.innerHTML = iotOkIcon;
    }
    else {
        iotWrist3Element.innerHTML = iotErrorIcon;
    }
});
iotTwinHubConnection.on("ReceiveToolStopIotCommandMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationIot(messageObject.Duration);
    if (messageObject.Status == 200) {
        iotToolElement.innerHTML = iotOkIcon;
    }
    else {
        iotToolElement.innerHTML = iotErrorIcon;
    }
});
document.getElementById("iotStartSyncButton").addEventListener("click", function (event) {

    document.getElementById("iotStartSyncButton").disabled = true;
    document.getElementById("iotStopSyncButton").disabled = false;

    totalDurationIot = 0;

    iotCobotElement.innerHTML = iotSyncIcon;
    iotControlBoxElement.innerHTML = iotSyncIcon;
    iotPayloadElement.innerHTML = iotSyncIcon;
    iotBaseElement.innerHTML = iotSyncIcon;
    iotShoulderElement.innerHTML = iotSyncIcon;
    iotElbowElement.innerHTML = iotSyncIcon;
    iotWrist1Element.innerHTML = iotSyncIcon;
    iotWrist2Element.innerHTML = iotSyncIcon;
    iotWrist3Element.innerHTML = iotSyncIcon;
    iotToolElement.innerHTML = iotSyncIcon;

    iotTwinHubConnection.invoke("cobotStartIotCommand").catch(function (err) {
        reject(err.toString());
    });

    iotTwinHubConnection.invoke("controlBoxStartIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("payloadStartIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("baseStartIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("shoulderStartIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("elbowStartIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("wrist1StartIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("wrist2StartIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("wrist3StartIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("toolStartIotCommand").catch(function (err) {
        reject(err.toString());
    });
});
document.getElementById("iotStopSyncButton").addEventListener("click", function (event) {

    document.getElementById("iotStartSyncButton").disabled = false;
    document.getElementById("iotStopSyncButton").disabled = true;

    totalDurationIot = 0;

    iotCobotElement.innerHTML = iotSyncIcon;
    iotControlBoxElement.innerHTML = iotSyncIcon;
    iotPayloadElement.innerHTML = iotSyncIcon;
    iotBaseElement.innerHTML = iotSyncIcon;
    iotShoulderElement.innerHTML = iotSyncIcon;
    iotElbowElement.innerHTML = iotSyncIcon;
    iotWrist1Element.innerHTML = iotSyncIcon;
    iotWrist2Element.innerHTML = iotSyncIcon;
    iotWrist3Element.innerHTML = iotSyncIcon;
    iotToolElement.innerHTML = iotSyncIcon;

    iotTwinHubConnection.invoke("cobotStopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("controlBoxStopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("payloadStopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("baseStopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("shoulderStopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("elbowStopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("wrist1StopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("wrist2StopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("wrist3StopIotCommand").catch(function (err) {
        reject(err.toString());
    });
    iotTwinHubConnection.invoke("toolStopIotCommand").catch(function (err) {
        reject(err.toString());
    });
});
function getTotalDurationIot(duration) {
    totalDurationIot = totalDurationIot + duration;
    var iotTitleElement = document.getElementById("iot-title");
    iotTitleElement.innerHTML = totalDurationIot.toFixed(4) + "ms";
}