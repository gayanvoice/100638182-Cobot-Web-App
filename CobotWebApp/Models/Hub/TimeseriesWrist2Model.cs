namespace CobotWebApp.Models.Hub
{
    public class TimeseriesWrist2Model
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public Wrist2TwinHubModel.Wrist2TwinModel? Wrist2TwinModel { get; set; }
        public static TimeseriesWrist2Model GetWrist2TwinHubModel(
            double duration,
            Wrist2TwinHubModel? wrist2TwinHubModel)
        { 
            Wrist2TwinHubModel.Wrist2TwinModel wrist2TwinModel = Wrist2TwinHubModel.Wrist2TwinModel
                .GetWrist2TwinModel(wrist2TwinHubModel: wrist2TwinHubModel);
            TimeseriesWrist2Model timeseriesWrist2Model = new TimeseriesWrist2Model();
            timeseriesWrist2Model.Duration = duration;
            if (wrist2TwinHubModel is not null &&
                wrist2TwinHubModel.Value is not null &&
                wrist2TwinHubModel.Value.Metadata is not null)
            {
                timeseriesWrist2Model.LastUpdateTime = wrist2TwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesWrist2Model.Wrist2TwinModel = wrist2TwinModel;
            return timeseriesWrist2Model;
        }
    }
}