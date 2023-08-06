namespace CobotWebApp.Models.Hub
{
    public class TimeseriesShoulderModel
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public ShoulderTwinHubModel.ShoulderTwinModel? ShoulderTwinModel { get; set; }
        public static TimeseriesShoulderModel GetShoulderTwinHubModel(
            double duration,
            ShoulderTwinHubModel? shoulderTwinHubModel)
        { 
            ShoulderTwinHubModel.ShoulderTwinModel ShoulderTwinModel = ShoulderTwinHubModel.ShoulderTwinModel
                .GetShoulderTwinModel(shoulderTwinHubModel: shoulderTwinHubModel);
            TimeseriesShoulderModel timeseriesShoulderModel = new TimeseriesShoulderModel();
            timeseriesShoulderModel.Duration = duration;
            if (shoulderTwinHubModel is not null &&
                shoulderTwinHubModel.Value is not null &&
                shoulderTwinHubModel.Value.Metadata is not null)
            {
                timeseriesShoulderModel.LastUpdateTime = shoulderTwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesShoulderModel.ShoulderTwinModel = ShoulderTwinModel;
            return timeseriesShoulderModel;
        }
    }
}