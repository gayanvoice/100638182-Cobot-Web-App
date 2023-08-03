using CobotWebApp.Models.Hub;
using Newtonsoft.Json;
using CobotWebApp.Models.Request;

namespace CobotWebApp.Helper
{
    public class TwinsHubHelper
    {
        private static HttpClient httpClient = new()
        {
            BaseAddress = new Uri("https://100638182-cobot-adt-initialize-function-app.azurewebsites.net/api/SelectADTModelFunction"),
        };
        public static async Task<CobotTwinHubModel?> GetCobotTwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Cobot");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
                .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);        
            return JsonConvert.DeserializeObject<CobotTwinHubModel>(responseModel.Message);
        }
        public static async Task<ControlBoxTwinHubModel?> GetControlBoxTwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=ControlBox");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
             .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<ControlBoxTwinHubModel>(responseModel.Message);
        }
        public static async Task<PayloadTwinHubModel?> GetPayloadTwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Payload");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
            .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<PayloadTwinHubModel>(responseModel.Message);
        }
        public static async Task<BaseTwinHubModel?> GetBaseTwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Base");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
            .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<BaseTwinHubModel>(responseModel.Message);
        }
        public static async Task<ShoulderTwinHubModel?> GetShoulderTwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Shoulder");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
           .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<ShoulderTwinHubModel>(responseModel.Message);
        }
        public static async Task<ElbowTwinHubModel?> GetElbowTwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Elbow");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
           .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<ElbowTwinHubModel>(responseModel.Message);
        }
        public static async Task<Wrist1TwinHubModel?> GetWrist1TwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Wrist1");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
           .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<Wrist1TwinHubModel>(responseModel.Message);
        }
        public static async Task<Wrist2TwinHubModel?> GetWrist2TwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Wrist2");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
           .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<Wrist2TwinHubModel>(responseModel.Message);
        }
        public static async Task<Wrist3TwinHubModel?> GetWrist3TwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Wrist3");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
           .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<Wrist3TwinHubModel>(responseModel.Message);
        }
        public static async Task<ToolTwinHubModel?> GetToolTwinHubModel()
        {
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("?id=Tool");
            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
            CobotAdtInitializeFunctionModel.ResponseModel? responseModel = JsonConvert
           .DeserializeObject<CobotAdtInitializeFunctionModel.ResponseModel>(jsonResponse);
            return JsonConvert.DeserializeObject<ToolTwinHubModel>(responseModel.Message);
        }
    }
}