using CobotWebApp.Models;
using CobotWebApp.Models.HttpResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Text.Json;

namespace CobotWebApp.Hubs
{
    [Authorize]
    public class AdtTwinHub : Hub
    {
        string url = "https://100638182-cobot-adt-initialize-function-app.azurewebsites.net";
        public async Task CreateCobot()
        {
            HubResponseModel hubResponseModel = await Get(url, "Cobot");
            await Clients.All.SendAsync("ReceiveCreateCobotMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateControlBox()
        {
            HubResponseModel hubResponseModel = await Get(url, "ControlBox");
            await Clients.All.SendAsync("ReceiveCreateControlBoxMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateJointLoad()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoad");
            await Clients.All.SendAsync("ReceiveCreateJointLoadMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreatePayload()
        {
            HubResponseModel hubResponseModel = await Get(url, "Payload");
            await Clients.All.SendAsync("ReceiveCreatePayloadMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateBase()
        {
            HubResponseModel hubResponseModel = await Get(url, "Base");
            await Clients.All.SendAsync("ReceiveCreateBaseMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateShoulder()
        {
            HubResponseModel hubResponseModel = await Get(url, "Shoulder");
            await Clients.All.SendAsync("ReceiveCreateShoulderMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateElbow()
        {
            HubResponseModel hubResponseModel = await Get(url, "Elbow");
            await Clients.All.SendAsync("ReceiveCreateElbowMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateWrist1()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist1");
            await Clients.All.SendAsync("ReceiveCreateWrist1Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateWrist2()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist2");
            await Clients.All.SendAsync("ReceiveCreateWrist2Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateWrist3()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist3");
            await Clients.All.SendAsync("ReceiveCreateWrist3Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateTool()
        {
            HubResponseModel hubResponseModel = await Get(url, "Tool");
            await Clients.All.SendAsync("ReceiveCreateToolMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task<HubResponseModel> Get(string url, string adtModelName)
        {
            HttpClient httpClient = new() { BaseAddress = new Uri(url) };

            using HttpResponseMessage httpResponseMessage = await httpClient
                .GetAsync($"/api/CreateADTModelFunction?name={adtModelName}");

            HttpResponseModel? httpResponseModel = await httpResponseMessage.Content
                .ReadFromJsonAsync<HttpResponseModel>();

            if (httpResponseModel is not null)
            {
                return HubResponseModel.FromHttpResponseModel(httpResponseModel);
            }
            else
            {
                HubResponseModel hubResponseModel = new HubResponseModel();
                hubResponseModel.Message = "HttpResponseModel is empty";
                hubResponseModel.Status = 403;
                hubResponseModel.Duration = 0.0;
                return hubResponseModel;
            }
        }
    }
}