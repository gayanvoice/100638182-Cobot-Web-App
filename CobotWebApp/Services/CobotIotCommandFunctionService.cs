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
        public async Task<OpenPopupControlCommandResponseModel?> PostOpenPopupControlCommandResponseModelAsync(
         CobotIotCommandFunctionModel.RequestModel.OpenPopupControlCommandRequestModel openPopupControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(openPopupControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "Yr_VRczCSMJ35U_ZffmZmsiB8juekWUnlcsMVkBrvcchAzFugLDaGg==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/OpenPopupControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                OpenPopupControlCommandResponseModel? openPopupControlCommandResponseModel = JsonConvert
                    .DeserializeObject<OpenPopupControlCommandResponseModel>(jsonResponse);
                return openPopupControlCommandResponseModel;
            }
            catch
            {
                return new OpenPopupControlCommandResponseModel();
            }
        }
        public async Task<MoveJControlCommandResponseModel?> PostMoveJControlCommandResponseModelAsync(
         CobotIotCommandFunctionModel.RequestModel.MoveJControlCommandRequestModel moveJControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(moveJControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "Bj8YgnNUyj9mYo2a3trdKgKRHygM2tRoq_jVPpchAlEeAzFugbZzrg==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/MoveJControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                MoveJControlCommandResponseModel? moveJControlCommandResponseModel = JsonConvert
                    .DeserializeObject<MoveJControlCommandResponseModel>(jsonResponse);
                return moveJControlCommandResponseModel;
            }
            catch
            {
                return new MoveJControlCommandResponseModel();
            }
        }
        public async Task<MoveLControlCommandResponseModel?> PostMoveLControlCommandResponseModelAsync(
         CobotIotCommandFunctionModel.RequestModel.MoveLControlCommandRequestModel moveLControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(moveLControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "YDgIU-WMAQmtET3mgAWRC1qfabKHIzTWqTReUeIHNPrYAzFugqVgZQ==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/MoveLControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                MoveLControlCommandResponseModel? moveLControlCommandResponseModel = JsonConvert
                    .DeserializeObject<MoveLControlCommandResponseModel>(jsonResponse);
                return moveLControlCommandResponseModel;
            }
            catch
            {
                return new MoveLControlCommandResponseModel();
            }
        }
        public async Task<MovePControlCommandResponseModel?> PostMovePControlCommandResponseModelAsync(
         CobotIotCommandFunctionModel.RequestModel.MovePControlCommandRequestModel movePControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(movePControlCommandRequestModel), Encoding.UTF8, "application/json");
            _httpClient.DefaultRequestHeaders.Add("x-functions-key", "uEOHC6z99Ise7BPWumtdlJQ3adH1v-btH00T65PX4CV8AzFuodHyiA==");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/MovePControlCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                MovePControlCommandResponseModel? movePControlCommandResponseModel = JsonConvert
                    .DeserializeObject<MovePControlCommandResponseModel>(jsonResponse);
                return movePControlCommandResponseModel;
            }
            catch
            {
                return new MovePControlCommandResponseModel();
            }
        }
        public async Task<StartIotControlCommandResponseModel?> PostStartIotControlCommandResponseModelAsync(
         CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel startIotControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(startIotControlCommandRequestModel), Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/StartIotCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                StartIotControlCommandResponseModel? startIotControlCommandResponseModel = JsonConvert
                    .DeserializeObject<StartIotControlCommandResponseModel>(jsonResponse);
                return startIotControlCommandResponseModel;
            }
            catch
            {
                return new StartIotControlCommandResponseModel();
            }
        }
        public async Task<StopIotControlCommandResponseModel?> PostStopIotControlCommandResponseModelAsync(
        CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel stopIotControlCommandRequestModel)
        {
            using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(stopIotControlCommandRequestModel), Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await _httpClient.PostAsync("/api/StopIotCommandFunction", jsonContent);
            string jsonResponse = await response.Content.ReadAsStringAsync();
            try
            {
                StopIotControlCommandResponseModel? stopIotControlCommandResponseModel = JsonConvert
                    .DeserializeObject<StopIotControlCommandResponseModel>(jsonResponse);
                return stopIotControlCommandResponseModel;
            }
            catch
            {
                return new StopIotControlCommandResponseModel();
            }
        }
    }
}