using CobotWebApp.Models.Request;
using Newtonsoft.Json;
using System.Text;
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
        public async Task<StartFreeDriveControlCommandResponseModel?> PostStartFreeDriveControlCommandResponseModelAsync(
           CobotIotCommandFunctionModel.RequestModel.StartFreeDriveControlCommandRequestModel startFreeDriveControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(startFreeDriveControlCommandRequestModel),
                Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "RZuK-DJw43yDafagYgwPoLKS0e9zvZmOZcrJfki4E3fHAzFu4ZigvA==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/StartFreeDriveControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                StartFreeDriveControlCommandResponseModel? startFreeDriveControlCommandResponseModel = JsonConvert
                    .DeserializeObject<StartFreeDriveControlCommandResponseModel>(jsonResponse);
                return startFreeDriveControlCommandResponseModel;
            }
            catch
            {
                return new StartFreeDriveControlCommandResponseModel();
            }
        }
        public async Task<StopFreeDriveControlCommandResponseModel?> PostStopFreeDriveControlCommandResponseModelAsync(
           CobotIotCommandFunctionModel.RequestModel.StopFreeDriveControlCommandRequestModel stopFreeDriveControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(stopFreeDriveControlCommandRequestModel),
                Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "H3sHEAkHAy7gZlTcozc1UJgvII947DGLXTiS1D_77FvcAzFuXWi0kg==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/StopFreeDriveControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                StopFreeDriveControlCommandResponseModel? stopFreeDriveControlCommandResponseModel = JsonConvert
                    .DeserializeObject<StopFreeDriveControlCommandResponseModel>(jsonResponse);
                return stopFreeDriveControlCommandResponseModel;
            }
            catch
            {
                return new StopFreeDriveControlCommandResponseModel();
            }
        }
        public async Task<PlayControlCommandResponseModel?> PostPlayControlCommandResponseModelAsync(
           CobotIotCommandFunctionModel.RequestModel.PlayControlCommandRequestModel playControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(playControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "KBA19uZoURzFeyMAaeTkCBRn2Pa4FRWusIrY8z82jU1aAzFuD5hbSQ==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/PlayControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                PlayControlCommandResponseModel? playControlCommandResponseModel = JsonConvert
                    .DeserializeObject<PlayControlCommandResponseModel>(jsonResponse);
                return playControlCommandResponseModel;
            }
            catch
            {
                return new PlayControlCommandResponseModel();
            }
        }
        public async Task<PauseControlCommandResponseModel?> PostPauseControlCommandResponseModelAsync(
           CobotIotCommandFunctionModel.RequestModel.PauseControlCommandRequestModel pauseControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(pauseControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "2CJqm6W0EShULpnhn2LGtpxM8WQ7d7PkjcBmcE_E6R2_AzFu8lf6Hg==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/PauseControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                PauseControlCommandResponseModel? pauseControlCommandResponseModel = JsonConvert
                    .DeserializeObject<PauseControlCommandResponseModel>(jsonResponse);
                return pauseControlCommandResponseModel;
            }
            catch
            {
                return new PauseControlCommandResponseModel();
            }
        }
        public async Task<CloseSafetyPopupControlCommandResponseModel?> PostCloseSafetyPopupControlCommandResponseModelAsync(
           CobotIotCommandFunctionModel.RequestModel.CloseSafetyPopupControlCommandRequestModel closeSafetyPopupControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(closeSafetyPopupControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "JffhmBQIXz6ETmbMXn2CAp1x1mBNvvn72ExXFFqg9Rr7AzFuFcHnMw==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/CloseSafetyPopupControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                CloseSafetyPopupControlCommandResponseModel? closeSafetyPopupControlCommandResponseModel = JsonConvert
                    .DeserializeObject<CloseSafetyPopupControlCommandResponseModel>(jsonResponse);
                return closeSafetyPopupControlCommandResponseModel;
            }
            catch
            {
                return new CloseSafetyPopupControlCommandResponseModel();
            }
        }
        public async Task<UnlockProtectiveStopControlCommandResponseModel?> PostUnlockProtectiveStopControlCommandResponseModelAsync(
          CobotIotCommandFunctionModel.RequestModel.UnlockProtectiveStopControlCommandRequestModel unlockProtectiveStopControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(unlockProtectiveStopControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "JQsdLxV29hQCOtiYpKou8Zl_OI7OotQvhkQPiUg9-iFKAzFu27Ea5g==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/UnlockProtectiveStopControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                UnlockProtectiveStopControlCommandResponseModel? unlockProtectiveStopControlCommandResponseModel = JsonConvert
                    .DeserializeObject<UnlockProtectiveStopControlCommandResponseModel>(jsonResponse);
                return unlockProtectiveStopControlCommandResponseModel;
            }
            catch
            {
                return new UnlockProtectiveStopControlCommandResponseModel();
            }
        }
        public async Task<ClosePopupControlCommandResponseModel?> PostClosePopupControlCommandResponseModelAsync(
          CobotIotCommandFunctionModel.RequestModel.ClosePopupControlCommandRequestModel closePopupControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(closePopupControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "7UwPoG53-FQsQ1ttd_ZXr1B1OrBuJ_ZNV0AnLTNw4XZWAzFubG2OUw==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/ClosePopupControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                ClosePopupControlCommandResponseModel? closePopupControlCommandResponseModel = JsonConvert
                    .DeserializeObject<ClosePopupControlCommandResponseModel>(jsonResponse);
                return closePopupControlCommandResponseModel;
            }
            catch
            {
                return new ClosePopupControlCommandResponseModel();
            }
        }
    }
}