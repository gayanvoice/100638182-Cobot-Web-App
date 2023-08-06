namespace CobotWebApp.Models.Hub
{
    public class TimeseriesWrist1Model
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public Wrist1TwinHubModel.Wrist1TwinModel? Wrist1TwinModel { get; set; }
        public static TimeseriesWrist1Model GetWrist1TwinHubModel(
            double duration,
            Wrist1TwinHubModel? wrist1TwinHubModel)
        { 
            Wrist1TwinHubModel.Wrist1TwinModel wrist1TwinModel = Wrist1TwinHubModel.Wrist1TwinModel
                .GetWrist1TwinModel(wrist1TwinHubModel: wrist1TwinHubModel);
            TimeseriesWrist1Model timeseriesWrist1Model = new TimeseriesWrist1Model();
            timeseriesWrist1Model.Duration = duration;
            if (wrist1TwinHubModel is not null &&
                wrist1TwinHubModel.Value is not null &&
                wrist1TwinHubModel.Value.Metadata is not null)
            {
                timeseriesWrist1Model.LastUpdateTime = wrist1TwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesWrist1Model.Wrist1TwinModel = wrist1TwinModel;
            return timeseriesWrist1Model;
        }
    }
}