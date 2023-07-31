
using CobotWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;
using System.Text.Json;

namespace CobotWebApp.Hubs
{
    [Authorize]
    public class IotCommandHub : Hub
    {
        string url = "https://100638182-cobot-iot-ingestion-function-app.azurewebsites.net";
        public async Task cobotStartCommand(string payload)
        {
            HubResponseModel hubResponseModel = await GetPayload(url, "Cobot", "StartCobotCommand", payload);
            await Clients.All.SendAsync("cobotStartCommandResponse", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task cobotStopCommand()
        {
            HubResponseModel hubResponseModel = await Get(url, "Cobot", "StopCobotCommand");
            await Clients.All.SendAsync("cobotStopCommandResponse", JsonSerializer.Serialize(hubResponseModel));
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
                hubResponseModel.Message = "Command executed successfully";
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
        public async Task<HubResponseModel> GetPayload(string url, string device, string method, string payload)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            HttpClient httpClient = new() { BaseAddress = new Uri(url) };

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync($"/api/cobot-iot-http-trigger?device={device}&method={method}&payload={payload}");
            stopwatch.Stop();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                HubResponseModel hubResponseModel = new HubResponseModel();
                hubResponseModel.Message = "Command executed successfully";
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