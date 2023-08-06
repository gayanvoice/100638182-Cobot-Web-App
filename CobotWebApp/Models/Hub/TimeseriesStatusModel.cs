using CobotWebApp.Helper;

namespace CobotWebApp.Models.Hub
{
    public class TimeseriesStatusModel
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
        public static TimeseriesStatusModel GetTimeseriesStatusModel(
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
            TimeseriesStatusModel timeseriesStatusModel = new TimeseriesStatusModel();
            timeseriesStatusModel.Duration = duration;
            timeseriesStatusModel.CobotStatusLabel = TimeseriesHubHelper.IsCobotRunning(cobotTwinHubModel);
            timeseriesStatusModel.ControlBoxStatusLabel = TimeseriesHubHelper.IsControlBoxRunning(controlBoxTwinHubModel);
            timeseriesStatusModel.PayloadStatusLabel = TimeseriesHubHelper.IsPayloadRunning(payloadTwinHubModel);
            timeseriesStatusModel.BaseStatusLabel = TimeseriesHubHelper.IsBaseRunning(baseTwinHubModel);
            timeseriesStatusModel.ShoulderStatusLabel = TimeseriesHubHelper.IsShoulderRunning(shoulderTwinHubModel);
            timeseriesStatusModel.ElbowStatusLabel = TimeseriesHubHelper.IsElbowRunning(elbowTwinHubModel);
            timeseriesStatusModel.Wrist1StatusLabel = TimeseriesHubHelper.IsWrist1Running(wrist1TwinHubModel);
            timeseriesStatusModel.Wrist2StatusLabel = TimeseriesHubHelper.IsWrist2Running(wrist2TwinHubModel);
            timeseriesStatusModel.Wrist3StatusLabel = TimeseriesHubHelper.IsWrist3Running(wrist3TwinHubModel);
            timeseriesStatusModel.ToolStatusLabel = TimeseriesHubHelper.IsToolRunning(toolTwinHubModel);
            return timeseriesStatusModel;
        }
    }
}