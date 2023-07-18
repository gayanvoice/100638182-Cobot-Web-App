using CobotWebApp.Models;
using CobotWebApp.Models.HttpResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Text.Json;

namespace CobotWebApp.Hubs
{
    [Authorize]
    public class AdtModelHub : Hub
    {
        string url = "https://100638182-cobot-adt-initialize-function-app.azurewebsites.net";
        public async Task UploadCobot()
        {
            HubResponseModel hubResponseModel = await Get(url, "Cobot");
            await Clients.All.SendAsync("ReceiveUploadCobotMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadControlBox()
        {
            HubResponseModel hubResponseModel = await Get(url, "ControlBox");
            await Clients.All.SendAsync("ReceiveUploadControlBoxMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadJointLoad()
        {
            HubResponseModel hubResponseModel = await Get(url, "JointLoad");
            await Clients.All.SendAsync("ReceiveUploadJointLoadMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadPayload()
        {
            HubResponseModel hubResponseModel = await Get(url, "Payload");
            await Clients.All.SendAsync("ReceiveUploadPayloadMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadBase()
        {
            HubResponseModel hubResponseModel = await Get(url, "Base");
            await Clients.All.SendAsync("ReceiveUploadBaseMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadShoulder()
        {
            HubResponseModel hubResponseModel = await Get(url, "Shoulder");
            await Clients.All.SendAsync("ReceiveUploadShoulderMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadElbow()
        {
            HubResponseModel hubResponseModel = await Get(url, "Elbow");
            await Clients.All.SendAsync("ReceiveUploadElbowMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadWrist1()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist1");
            await Clients.All.SendAsync("ReceiveUploadWrist1Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadWrist2()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist2");
            await Clients.All.SendAsync("ReceiveUploadWrist2Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadWrist3()
        {
            HubResponseModel hubResponseModel = await Get(url, "Wrist3");
            await Clients.All.SendAsync("ReceiveUploadWrist3Message", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task UploadTool()
        {
            HubResponseModel hubResponseModel = await Get(url, "Tool");
            await Clients.All.SendAsync("ReceiveUploadToolMessage", JsonSerializer.Serialize(hubResponseModel));
        }
        public async Task<HubResponseModel> Get(string url, string dtdlModelName)
        {
            HttpClient httpClient = new() { BaseAddress = new Uri(url) };

            using HttpResponseMessage httpResponseMessage = await httpClient
                .GetAsync($"/api/UploadDTDLModelFunction?name={dtdlModelName}");

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