namespace CobotWebApp.Models.Hub
{
    public class TimeseriesPayloadModel
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public PayloadTwinHubModel.PayloadTwinModel? PayloadTwinModel { get; set; }
        public static TimeseriesPayloadModel GetPayloadTwinHubModel(
            double duration,
            PayloadTwinHubModel? payloadTwinHubModel)
        { 
            PayloadTwinHubModel.PayloadTwinModel payloadTwinModel = PayloadTwinHubModel.PayloadTwinModel
                .GetPayloadTwinModel(payloadTwinHubModel: payloadTwinHubModel);
            TimeseriesPayloadModel timeseriesPayloadModel = new TimeseriesPayloadModel();
            timeseriesPayloadModel.Duration = duration;
            if (payloadTwinHubModel is not null &&
                payloadTwinHubModel.Value is not null &&
                payloadTwinHubModel.Value.Metadata is not null)
            {
                timeseriesPayloadModel.LastUpdateTime = payloadTwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesPayloadModel.PayloadTwinModel = payloadTwinModel;
            return timeseriesPayloadModel;
        }
    }
}