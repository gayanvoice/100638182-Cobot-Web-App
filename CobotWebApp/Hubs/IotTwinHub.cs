﻿using CobotWebApp.Models;
using CobotWebApp.Models.HttpResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;
using System.Text.Json;

namespace CobotWebApp.Hubs
{
    [Authorize]
    public class IotTwinHub : Hub
    {
        string url = "https://100638182-cobot-iot-ingestion-function-app.azurewebsites.net/";
        public async Task cobotStartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Cobot", "startIotCommand");
            await Clients.All.SendAsync("ReceiveCobotStartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }

        public async Task controlBoxStartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "ControlBox", "startIotCommand");
            await Clients.All.SendAsync("ReceiveControlBoxStartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task jointLoadStartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoad", "startIotCommand");
            await Clients.All.SendAsync("ReceiveJointLoadStartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task payloadStartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Payload", "startIotCommand");
            await Clients.All.SendAsync("ReceivePayloadStartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task baseStartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Base", "startIotCommand");
            await Clients.All.SendAsync("ReceiveBaseStartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task shoulderStartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Shoulder", "startIotCommand");
            await Clients.All.SendAsync("ReceiveShoulderStartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task elbowStartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Elbow", "startIotCommand");
            await Clients.All.SendAsync("ReceiveElbowStartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task wrist1StartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist1", "startIotCommand");
            await Clients.All.SendAsync("ReceiveWrist1StartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task wrist2StartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist2", "startIotCommand");
            await Clients.All.SendAsync("ReceiveWrist2StartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task wrist3StartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist3", "startIotCommand");
            await Clients.All.SendAsync("ReceiveWrist3StartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task toolStartIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Tool", "startIotCommand");
            await Clients.All.SendAsync("ReceiveToolStartIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task cobotStopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Cobot", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveCobotStopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }

        public async Task controlBoxStopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "ControlBox", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveControlBoxStopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task jointLoadStopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoad", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveJointLoadStopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task payloadStopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Payload", "stopIotCommand");
            await Clients.All.SendAsync("ReceivePayloadStopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task baseStopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Base", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveBaseStopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task shoulderStopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Shoulder", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveShoulderStopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task elbowStopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Elbow", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveElbowStopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task wrist1StopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist1", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveWrist1StopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task wrist2StopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist2", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveWrist2StopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task wrist3StopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist3", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveWrist3StopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task toolStopIotCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Tool", "stopIotCommand");
            await Clients.All.SendAsync("ReceiveToolStopIotCommandMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task<HubResponseModel> Get(string url, string device, string method)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HttpClient httpClient = new() { BaseAddress = new Uri(url) };

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"/api/cobot-iot-http-trigger?device={device}&method={method}");
            stopwatch.Stop();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                HubResponseModel hubResponseModel = new HubResponseModel();
                hubResponseModel.Message = "Service is started";
                hubResponseModel.Status = 200;
                hubResponseModel.Duration = stopwatch.Elapsed.TotalMilliseconds;
                return hubResponseModel;
            }
            else
            {
                HubResponseModel hubResponseModel = new HubResponseModel();
                hubResponseModel.Message = "Service is offline";
                hubResponseModel.Status = 400;
                hubResponseModel.Duration = stopwatch.Elapsed.TotalMilliseconds;
                return hubResponseModel;
            }
        }
    }
}