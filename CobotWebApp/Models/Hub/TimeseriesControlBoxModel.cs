namespace CobotWebApp.Models.Hub
{
    public class TimeseriesControlBoxModel
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public ControlBoxTwinHubModel.ControlBoxTwinModel? ControlBoxTwinModel { get; set; }
        public static TimeseriesControlBoxModel GetControlBoxTwinHubModel(
            double duration,
            ControlBoxTwinHubModel? controlBoxTwinHubModel)
        { 
            ControlBoxTwinHubModel.ControlBoxTwinModel cobotTwinModel = ControlBoxTwinHubModel.ControlBoxTwinModel
                .GetControlBoxTwinModel(controlBoxTwinHubModel: controlBoxTwinHubModel);
            TimeseriesControlBoxModel timeseriesControlBoxModel = new TimeseriesControlBoxModel();
            timeseriesControlBoxModel.Duration = duration;
            if (controlBoxTwinHubModel is not null &&
                controlBoxTwinHubModel.Value is not null &&
                controlBoxTwinHubModel.Value.Metadata is not null)
            {
                timeseriesControlBoxModel.LastUpdateTime = controlBoxTwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesControlBoxModel.ControlBoxTwinModel = cobotTwinModel;
            return timeseriesControlBoxModel;
        }
    }
}