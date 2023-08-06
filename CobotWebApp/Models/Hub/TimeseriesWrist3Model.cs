namespace CobotWebApp.Models.Hub
{
    public class TimeseriesWrist3Model
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public Wrist3TwinHubModel.Wrist3TwinModel? Wrist3TwinModel { get; set; }
        public static TimeseriesWrist3Model GetWrist3TwinHubModel(
            double duration,
            Wrist3TwinHubModel? wrist3TwinHubModel)
        { 
            Wrist3TwinHubModel.Wrist3TwinModel wrist3TwinModel = Wrist3TwinHubModel.Wrist3TwinModel
                .GetWrist3TwinModel(wrist3TwinHubModel: wrist3TwinHubModel);
            TimeseriesWrist3Model timeseriesWrist3Model = new TimeseriesWrist3Model();
            timeseriesWrist3Model.Duration = duration;
            if (wrist3TwinHubModel is not null &&
                wrist3TwinHubModel.Value is not null &&
                wrist3TwinHubModel.Value.Metadata is not null)
            {
                timeseriesWrist3Model.LastUpdateTime = wrist3TwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesWrist3Model.Wrist3TwinModel = wrist3TwinModel;
            return timeseriesWrist3Model;
        }
    }
}