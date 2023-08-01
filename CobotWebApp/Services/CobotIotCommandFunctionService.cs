using CobotWebApp.Models.Request;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using static CobotWebApp.Models.Request.CobotIotCommandFunctionModel.ResponseModel;

namespace CobotWebApp.Services
{
    public class CobotIotCommandFunctionService
    {
        private readonly HttpClient _httpClient;

        public CobotIotCommandFunctionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://100638182-cobot-iot-command-function-app.azurewebsites.net");
        }

        public async Task<EnableControlCommandResponseModel?> PostEnableControlCommandResponseModelAsync(
            CobotIotCommandFunctionModel.RequestModel.EnableControlCommandRequestModel enableControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(enableControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "8MXtnAHRMQgg4R50hEk8FqXmPwepZV-0h5GeKvS5pPjdAzFuagusFA==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/EnableControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                EnableControlCommandResponseModel? enableControlCommandResponseModel = JsonConvert.DeserializeObject<EnableControlCommandResponseModel>(jsonResponse);
                return enableControlCommandResponseModel;
           
            }
            catch
            {
                return new EnableControlCommandResponseModel();
            }
        }
        public async Task<DisableControlCommandResponseModel?> PostDisableControlCommandResponseModelAsync(
            CobotIotCommandFunctionModel.RequestModel.DisableControlCommandRequestModel disableControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(disableControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "hr93hoBxZguhu_UGh6oFQ_OkMeAtMdvjDNgEiFJc07r9AzFuxKbbXQ==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/DisableControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                DisableControlCommandResponseModel? disableControlCommandResponseModel = JsonConvert.DeserializeObject<DisableControlCommandResponseModel>(jsonResponse);
                return disableControlCommandResponseModel;

            }
            catch
            {
                return new DisableControlCommandResponseModel();
            }
        }
        public async Task<PowerOnControlCommandResponseModel?> PostPowerOnControlCommandResponseModelAsync(
            CobotIotCommandFunctionModel.RequestModel.PowerOnControlCommandRequestModel powerOnControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(powerOnControlCommandRequestModel),
                Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "GjPI6O8b4DMOoOUl8ip2YApuiPjoAL-ko9FcfsL-PNdXAzFuFpmQ8A==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/PowerOnControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                PowerOnControlCommandResponseModel? powerOnControlCommandResponseModel = JsonConvert
                    .DeserializeObject<PowerOnControlCommandResponseModel>(jsonResponse);
                return powerOnControlCommandResponseModel;

            }
            catch
            {
                return new PowerOnControlCommandResponseModel();
            }
        }
        public async Task<PowerOffControlCommandResponseModel?> PostPowerOffControlCommandResponseModelAsync(
            CobotIotCommandFunctionModel.RequestModel.PowerOffControlCommandRequestModel powerOffControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(powerOffControlCommandRequestModel),
                Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "oExZV1mN6FiVPYuTWnx0alQyS8Z9jMRVzbxjuFgEUvStAzFumDhVIQ==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/PowerOffControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                PowerOffControlCommandResponseModel? powerOffControlCommandResponseModel = JsonConvert
                    .DeserializeObject<PowerOffControlCommandResponseModel>(jsonResponse);
                return powerOffControlCommandResponseModel;

            }
            catch
            {
                return new PowerOffControlCommandResponseModel();
            }
        }
    }
}
