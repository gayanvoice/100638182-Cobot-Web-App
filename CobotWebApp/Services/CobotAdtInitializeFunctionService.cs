using CobotWebApp.Models.Request;

namespace CobotWebApp.Services
{
    public class CobotAdtInitializeFunctionService
    {
        private readonly HttpClient _httpClient;

        public CobotAdtInitializeFunctionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://100638182-cobot-adt-initialize-function-app.azurewebsites.net");
        }

        public async Task<CobotAdtInitializeFunctionModel.ResponseModel?> GetUploadDtdlModelResponseModelAsync(
            CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel uploadDtdlModelRequestModel)
        {
            return await _httpClient.GetFromJsonAsync<CobotAdtInitializeFunctionModel.ResponseModel>(
               $"/api/UploadDtdlModelFunction?name={uploadDtdlModelRequestModel.Name}");
        }
        public async Task<CobotAdtInitializeFunctionModel.ResponseModel?> GetDeleteAdtRelationshipResponseModelAsync(
            CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel deleteAdtRelationshipRequestModel)
        {
            return await _httpClient.GetFromJsonAsync<CobotAdtInitializeFunctionModel.ResponseModel>(
               $"/api/DeleteADTRelationshipFunction?from={deleteAdtRelationshipRequestModel.From}&id={deleteAdtRelationshipRequestModel.Id}");
        }
        public async Task<CobotAdtInitializeFunctionModel.ResponseModel?> GetDeleteAdtModelResponseModelAsync(
            CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel deleteAdtModelRequestModel)
        {
            return await _httpClient.GetFromJsonAsync<CobotAdtInitializeFunctionModel.ResponseModel>(
               $"/api/DeleteADTModelFunction?id={deleteAdtModelRequestModel.Id}");
        }
        public async Task<CobotAdtInitializeFunctionModel.ResponseModel?> GetCreateAdtModelResponseModelAsync(
            CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel createAdtModelRequestModel)
        {
            return await _httpClient.GetFromJsonAsync<CobotAdtInitializeFunctionModel.ResponseModel>(
               $"/api/CreateAdtModelFunction?name={createAdtModelRequestModel.Name}&id={createAdtModelRequestModel.Id}");
        }
        public async Task<CobotAdtInitializeFunctionModel.ResponseModel?> GetCreateAdtRelationshipResponseModelAsync(
           CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel createAdtRelationshipRequestModel)
        {
            return await _httpClient.GetFromJsonAsync<CobotAdtInitializeFunctionModel.ResponseModel>(
               $"/api/CreateAdtRelationshipFunction?name={createAdtRelationshipRequestModel.Name}&from={createAdtRelationshipRequestModel.From}&to={createAdtRelationshipRequestModel.To}");
        }
    }
}
