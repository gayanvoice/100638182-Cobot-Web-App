using Azure.DigitalTwins.Core;
using Azure.Identity;
using Azure;
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
            string? adtInstanceUrl = "https://100638182AzureDigitalTwins.api.uks.digitaltwins.azure.net";
            DefaultAzureCredential defaultAzureCredential = new DefaultAzureCredential(new DefaultAzureCredentialOptions { ExcludeEnvironmentCredential = true });
            DigitalTwinsClient digitalTwinsClient = new DigitalTwinsClient(new Uri(adtInstanceUrl), defaultAzureCredential);
            Response<BasicDigitalTwin> twinResponse = await digitalTwinsClient.GetDigitalTwinAsync<BasicDigitalTwin>("Cobot");
            BasicDigitalTwin basicDigitalTwin = twinResponse.Value;
            Console.WriteLine($"Model id: {basicDigitalTwin.Metadata.ModelId}");
            foreach (string prop in basicDigitalTwin.Contents.Keys)
            {
                if (basicDigitalTwin.Contents.TryGetValue(prop, out object value))
                    Console.WriteLine($"Property '{prop}': {value}");
            }
            await Clients.All.SendAsync("ReceiveUploadCobotMessage", JsonSerializer.Serialize("basicDigitalTwin"));
        }
    }
}