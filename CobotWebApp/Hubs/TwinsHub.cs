using CobotWebApp.Models;
using CobotWebApp.Models.HttpResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Text.Json;

namespace CobotWebApp.Hubs
{
    [Authorize]
    public class TwinsHub : Hub
    {
       
        public async Task UploadCobot()
        {
            //HubResponseModel hubResponseModel = await Get(url, "Cobot");
            await Clients.All.SendAsync("ReceiveUploadCobotMessage", JsonSerializer.Serialize("hubResponseModel"));
        }
    }
}