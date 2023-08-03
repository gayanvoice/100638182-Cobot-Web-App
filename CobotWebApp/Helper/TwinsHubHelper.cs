using Azure.DigitalTwins.Core;
using Azure;
using Azure.Identity;
using CobotWebApp.Models.Hub;
using Newtonsoft.Json;

namespace CobotWebApp.Helper
{
    public class TwinsHubHelper
    {
        public static async Task<Response<BasicDigitalTwin>> GetBasicDigitalTwinResponse(string digitalTwinId)
        {
            string? adtInstanceUrl = "https://100638182AzureDigitalTwins.api.uks.digitaltwins.azure.net";
            DefaultAzureCredential defaultAzureCredential = new DefaultAzureCredential(new DefaultAzureCredentialOptions { ExcludeEnvironmentCredential = true });
            DigitalTwinsClient digitalTwinsClient = new DigitalTwinsClient(new Uri(adtInstanceUrl), defaultAzureCredential);
            Response<BasicDigitalTwin> twinResponse = await digitalTwinsClient.GetDigitalTwinAsync<BasicDigitalTwin>(digitalTwinId);
            return twinResponse;
        }
        public static async Task<CobotTwinHubModel?> GetCobotTwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Cobot");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<CobotTwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<ControlBoxTwinHubModel?> GetControlBoxTwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("ControlBox");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<ControlBoxTwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<PayloadTwinHubModel?> GetPayloadTwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Payload");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<PayloadTwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<BaseTwinHubModel?> GetBaseTwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Base");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<BaseTwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<ShoulderTwinHubModel?> GetShoulderTwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Shoulder");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<ShoulderTwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<ElbowTwinHubModel?> GetElbowTwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Elbow");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<ElbowTwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<Wrist1TwinHubModel?> GetWrist1TwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Wrist1");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<Wrist1TwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<Wrist2TwinHubModel?> GetWrist2TwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Wrist2");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<Wrist2TwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<Wrist3TwinHubModel?> GetWrist3TwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Wrist3");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<Wrist3TwinHubModel>(basicDigitalTwinResponseJson);
        }
        public static async Task<ToolTwinHubModel?> GetToolTwinHubModel()
        {
            Response<BasicDigitalTwin> basicDigitalTwinResponse = await GetBasicDigitalTwinResponse("Tool");
            string basicDigitalTwinResponseJson = System.Text.Json.JsonSerializer.Serialize(basicDigitalTwinResponse);
            return JsonConvert.DeserializeObject<ToolTwinHubModel>(basicDigitalTwinResponseJson);
        }
    }
}