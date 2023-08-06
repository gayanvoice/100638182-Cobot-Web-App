namespace CobotWebApp.Models.Hub
{
    public class TimeseriesBaseModel
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public BaseTwinHubModel.BaseTwinModel? BaseTwinModel { get; set; }
        public static TimeseriesBaseModel GetBaseTwinHubModel(
            double duration,
            BaseTwinHubModel? baseTwinHubModel)
        { 
            BaseTwinHubModel.BaseTwinModel BaseTwinModel = BaseTwinHubModel.BaseTwinModel
                .GetBaseTwinModel(baseTwinHubModel: baseTwinHubModel);
            TimeseriesBaseModel timeseriesBaseModel = new TimeseriesBaseModel();
            timeseriesBaseModel.Duration = duration;
            if (baseTwinHubModel is not null &&
                baseTwinHubModel.Value is not null &&
                baseTwinHubModel.Value.Metadata is not null)
            {
                timeseriesBaseModel.LastUpdateTime = baseTwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesBaseModel.BaseTwinModel = BaseTwinModel;
            return timeseriesBaseModel;
        }
    }
}