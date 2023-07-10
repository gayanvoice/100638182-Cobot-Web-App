using CobotWebApp.Models.HttpResponse;

namespace CobotWebApp.Models
{
    public class HubResponseModel
    {
        public string? Message{ get; set; }
        public int Status { get; set; }
        public double Duration { get; set; }

        public static HubResponseModel FromHttpResponseModel(HttpResponseModel httpResponseModel)
        {
            HubResponseModel hubResponseModel = new HubResponseModel();
            hubResponseModel.Message = httpResponseModel.Message;
            hubResponseModel.Status = httpResponseModel.HttpStatusCode;
            hubResponseModel.Duration = httpResponseModel.Duration;
            return hubResponseModel;
        }
        public static HubResponseModel FromHttpResponseMessage(HttpResponseMessage httpResponseMessage)
        {
            HubResponseModel hubResponseModel = new HubResponseModel();
            hubResponseModel.Message = httpResponseMessage.ReasonPhrase;
            hubResponseModel.Status = 400;
            hubResponseModel.Duration = 0.0;
            return hubResponseModel;
        }
    }
}