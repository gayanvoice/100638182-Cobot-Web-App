namespace CobotWebApp.Models.Hub
{
    public class TimeseriesCobotModel
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public CobotTwinHubModel.CobotTwinModel? CobotTwinModel{ get; set; }
        public static TimeseriesCobotModel GetCobotTwinHubModel(
            double duration,
            CobotTwinHubModel? cobotTwinHubModel)
        { 
            CobotTwinHubModel.CobotTwinModel cobotTwinModel = CobotTwinHubModel.CobotTwinModel.GetCobotTwinModel(cobotTwinHubModel: cobotTwinHubModel);
            TimeseriesCobotModel timeseriesCobotModel = new TimeseriesCobotModel();
            timeseriesCobotModel.Duration = duration;
            if (cobotTwinHubModel is not null &&
                cobotTwinHubModel.Value is not null &&
                cobotTwinHubModel.Value.Metadata is not null)
            {
                timeseriesCobotModel.LastUpdateTime = cobotTwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesCobotModel.CobotTwinModel = cobotTwinModel;
            return timeseriesCobotModel;
        }
    }
}