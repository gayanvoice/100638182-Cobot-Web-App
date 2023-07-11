"use strict";

var iotCommandHubConnection = new signalR.HubConnectionBuilder().withUrl("/iotCommandHub").build();

document.getElementById("cobotStartCommandButton").disabled = true;
document.getElementById("cobotStopCommandButton").disabled = true;
document.getElementById("cobotSendPayloadButton").disabled = true;

const cobotCommandStatusElement = document.getElementById("cobotCommandStatus");

var totalDurationIot = 0;

iotCommandHubConnection.start().then(function () {
    document.getElementById("cobotStartCommandButton").disabled = false;
    document.getElementById("cobotStopCommandButton").disabled = false;
    document.getElementById("cobotSendPayloadButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

iotCommandHubConnection.on("cobotStartCommandResponse", function (message) {
    const messageObject = JSON.parse(message);
    if (messageObject.Status == 200) {
        document.getElementById("cobotCommandStatus").innerHTML = "Cobot started! " + messageObject.Duration.toFixed(4) + "ms";
    }
    else {
        document.getElementById("cobotCommandStatus").innerHTML = "Cobot offline! " + messageObject.Duration.toFixed(4) + "ms";
    }
    document.getElementById("cobotStartCommandButton").disabled = true;
    document.getElementById("cobotStopCommandButton").disabled = false;

});
iotCommandHubConnection.on("cobotStopCommandResponse", function (message) {
    const messageObject = JSON.parse(message);
    if (messageObject.Status == 200) {
        document.getElementById("cobotCommandStatus").innerHTML = "Cobot stopped! " + messageObject.Duration.toFixed(4) + "ms";
    }
    else {
        document.getElementById("cobotCommandStatus").innerHTML = "Cobot offline! " + messageObject.Duration.toFixed(4) + "ms";
    }
    document.getElementById("cobotStartCommandButton").disabled = false;
    document.getElementById("cobotSendPayloadButton").disabled = false;
    document.getElementById("cobotStopCommandButton").disabled = true;
});
document.getElementById("cobotSendPayloadButton").addEventListener("click", function (event) {

    document.getElementById("cobotSendPayloadButton").disabled = true;
    document.getElementById("cobotCommandStatus").innerHTML = "Starting the Cobot...";

    var payloadText = document.getElementById("payloadText").value;
    iotCommandHubConnection.invoke("cobotStartCommand", payloadText).catch(function (err) {
        reject(err.toString());
    });
});
document.getElementById("cobotStopCommandButton").addEventListener("click", function (event) {

    document.getElementById("cobotStartCommandButton").disabled = false;
    document.getElementById("cobotStopCommandButton").disabled = true;

    document.getElementById("cobotCommandStatus").innerHTML = "Stopping the Cobot...";

    iotCommandHubConnection.invoke("cobotStopCommand").catch(function (err) {
        reject(err.toString());
    });
});

const exampleModal = document.getElementById('exampleModal')
if (exampleModal) {
    exampleModal.addEventListener('show.bs.modal', event => {
        const button = event.relatedTarget
        const recipient = button.getAttribute('data-bs-whatever')
        const modalTitle = exampleModal.querySelector('.modal-title')
        const modalBodyInput = exampleModal.querySelector('.modal-body input')

        modalTitle.textContent = `New payload`
        modalBodyInput.value = recipient
    })
}