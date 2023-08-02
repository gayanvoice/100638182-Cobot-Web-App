"use strict";

var uploadDtdlModelHubConnection = new signalR.HubConnectionBuilder().withUrl("/twinsHub").build();


const cobotElapedTime = document.getElementById("cobotElapedTime");


uploadDtdlModelHubConnection.start().then(function () {
}).catch(function (err) {
    return console.error(err.toString());
});

uploadDtdlModelHubConnection.on("ReceiveUploadCobotMessage", function (message) {
    const messageObject = JSON.parse(message);
    getTotalDurationAdt(messageObject.Duration);
    if (messageObject.Status == 200) {
        cobotElapedTime.innerHTML = uploadIcon;
    }
    else {
        cobotElapedTime.innerHTML = replaceIcon;
    }
});
function foo() {
    uploadDtdlModelHubConnection.invoke("UploadCobot").catch(function (err) {
        reject(err.toString());
    });
}

setInterval(foo, 10000);