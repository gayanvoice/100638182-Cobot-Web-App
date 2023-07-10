using CobotWebApp.Models;
using CobotWebApp.Models.HttpResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Text.Json;

namespace CobotWebApp.Hubs
{
    [Authorize]
    public class AdtRelationshipHub : Hub
    {
        string url = "https://100638182-cobot-adt-initialize-function-app.azurewebsites.net";
        public async Task CreateCobotToControlBox()
        {
            HubResponseModel hubResponseModel = await Get(url, "CobotToControlBox");
            await Clients.All.SendAsync("ReceiveCreateCobotToControlBoxMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateCobotToJointLoad()
        {
            HubResponseModel hubResponseModel = await Get(url, "CobotToJointLoad");
            await Clients.All.SendAsync("ReceiveCreateCobotToJointLoadMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateCobotToPayload()
        {
            HubResponseModel hubResponseModel = await Get(url, "CobotToPayload");
            await Clients.All.SendAsync("ReceiveCreateCobotToPayloadMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateJointLoadToBase()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoadToBase");
            await Clients.All.SendAsync("ReceiveCreateJointLoadToBaseMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateJointLoadToShoulder()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoadToShoulder");
            await Clients.All.SendAsync("ReceiveCreateJointLoadToShoulderMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateJointLoadToElbow()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoadToElbow");
            await Clients.All.SendAsync("ReceiveCreateJointLoadToElbowMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateJointLoadToWrist1()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoadToWrist1");
            await Clients.All.SendAsync("ReceiveCreateJointLoadToWrist1Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateJointLoadToWrist2()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoadToWrist2");
            await Clients.All.SendAsync("ReceiveCreateJointLoadToWrist2Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateJointLoadToWrist3()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoadToWrist3");
            await Clients.All.SendAsync("ReceiveCreateJointLoadToWrist3Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task CreateJointLoadToTool()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoadToTool");
            await Clients.All.SendAsync("ReceiveCreateJointLoadToToolMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task<HubResponseModel> Get(string url, string adtModelName)
        {
            HttpClient httpClient = new() { BaseAddress = new Uri(url) };

            using HttpResponseMessage httpResponseMessage = await httpClient
                .GetAsync($"/api/CreateAdtRelationshipFunction?adtRelationshipName={adtModelName}");

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