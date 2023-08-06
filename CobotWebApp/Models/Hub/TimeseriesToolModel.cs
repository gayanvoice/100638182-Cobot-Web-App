namespace CobotWebApp.Models.Hub
{
    public class TimeseriesToolModel
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public ToolTwinHubModel.ToolTwinModel? ToolTwinModel { get; set; }
        public static TimeseriesToolModel GetToolTwinHubModel(
            double duration,
            ToolTwinHubModel? toolTwinHubModel)
        { 
            ToolTwinHubModel.ToolTwinModel ToolTwinModel = ToolTwinHubModel.ToolTwinModel
                .GetToolTwinModel(toolTwinHubModel: toolTwinHubModel);
            TimeseriesToolModel timeseriesToolModel = new TimeseriesToolModel();
            timeseriesToolModel.Duration = duration;
            if (toolTwinHubModel is not null &&
                toolTwinHubModel.Value is not null &&
                toolTwinHubModel.Value.Metadata is not null)
            {
                timeseriesToolModel.LastUpdateTime = toolTwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesToolModel.ToolTwinModel = ToolTwinModel;
            return timeseriesToolModel;
        }
    }
}