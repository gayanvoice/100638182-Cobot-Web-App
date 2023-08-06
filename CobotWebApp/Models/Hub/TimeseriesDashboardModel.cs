using CobotWebApp.Helper;

namespace CobotWebApp.Models.Hub
{
    public class TimeseriesDashboardModel
    {
        public double Duration { get; set; }
        public string? CobotStatusLabel { get; set; }
        public string? ControlBoxStatusLabel { get; set; }
        public string? PayloadStatusLabel { get; set; }
        public string? BaseStatusLabel { get; set; }
        public string? ShoulderStatusLabel { get; set; }
        public string? ElbowStatusLabel { get; set; }
        public string? Wrist1StatusLabel { get; set; }
        public string? Wrist2StatusLabel { get; set; }
        public string? Wrist3StatusLabel { get; set; }
        public string? ToolStatusLabel { get; set; }
        public static TimeseriesDashboardModel GetTimeseriesDashboardModel(
            double duration,
            CobotTwinHubModel? cobotTwinHubModel,
            ControlBoxTwinHubModel? controlBoxTwinHubModel,
            PayloadTwinHubModel? payloadTwinHubModel,
            BaseTwinHubModel? baseTwinHubModel,
            ShoulderTwinHubModel? shoulderTwinHubModel,
            ElbowTwinHubModel? elbowTwinHubModel,
            Wrist1TwinHubModel? wrist1TwinHubModel,
            Wrist2TwinHubModel? wrist2TwinHubModel,
            Wrist3TwinHubModel? wrist3TwinHubModel,
            ToolTwinHubModel? toolTwinHubModel)
        {
            TimeseriesDashboardModel timeseriesDashboardModel = new TimeseriesDashboardModel();
            timeseriesDashboardModel.Duration = duration;
            timeseriesDashboardModel.CobotStatusLabel = TimeseriesHubHelper.IsCobotRunning(cobotTwinHubModel);
            timeseriesDashboardModel.ControlBoxStatusLabel = TimeseriesHubHelper.IsControlBoxRunning(controlBoxTwinHubModel);
            timeseriesDashboardModel.PayloadStatusLabel = TimeseriesHubHelper.IsPayloadRunning(payloadTwinHubModel);
            timeseriesDashboardModel.BaseStatusLabel = TimeseriesHubHelper.IsBaseRunning(baseTwinHubModel);
            timeseriesDashboardModel.ShoulderStatusLabel = TimeseriesHubHelper.IsShoulderRunning(shoulderTwinHubModel);
            timeseriesDashboardModel.ElbowStatusLabel = TimeseriesHubHelper.IsElbowRunning(elbowTwinHubModel);
            timeseriesDashboardModel.Wrist1StatusLabel = TimeseriesHubHelper.IsWrist1Running(wrist1TwinHubModel);
            timeseriesDashboardModel.Wrist2StatusLabel = TimeseriesHubHelper.IsWrist2Running(wrist2TwinHubModel);
            timeseriesDashboardModel.Wrist3StatusLabel = TimeseriesHubHelper.IsWrist3Running(wrist3TwinHubModel);
            timeseriesDashboardModel.ToolStatusLabel = TimeseriesHubHelper.IsToolRunning(toolTwinHubModel);
            return timeseriesDashboardModel;
        }
    }
}