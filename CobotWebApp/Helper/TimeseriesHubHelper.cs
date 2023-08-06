using CobotWebApp.Models.Hub;

namespace CobotWebApp.Helper
{
    public class TimeseriesHubHelper
    {
        public static double MAX_SECONDS = 10;
        public static string IsCobotRunning(CobotTwinHubModel? cobotTwinHubModel)
        {
            if (cobotTwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (cobotTwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (cobotTwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (cobotTwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(cobotTwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsControlBoxRunning(ControlBoxTwinHubModel? controlBoxTwinHubModel)
        {
            if (controlBoxTwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (controlBoxTwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (controlBoxTwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (controlBoxTwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(controlBoxTwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsPayloadRunning(PayloadTwinHubModel? payloadTwinHubModel)
        {
            if (payloadTwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (payloadTwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (payloadTwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (payloadTwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(payloadTwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsBaseRunning(BaseTwinHubModel? baseTwinHubModel)
        {
            if (baseTwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (baseTwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (baseTwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (baseTwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(baseTwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsShoulderRunning(ShoulderTwinHubModel? shoulderTwinHubModel)
        {
            if (shoulderTwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (shoulderTwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (shoulderTwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (shoulderTwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(shoulderTwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsElbowRunning(ElbowTwinHubModel? elbowTwinHubModel)
        {
            if (elbowTwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (elbowTwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (elbowTwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (elbowTwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(elbowTwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsWrist1Running(Wrist1TwinHubModel? wrist1TwinHubModel)
        {
            if (wrist1TwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (wrist1TwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (wrist1TwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (wrist1TwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(wrist1TwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsWrist2Running(Wrist2TwinHubModel? wrist2TwinHubModel)
        {
            if (wrist2TwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (wrist2TwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (wrist2TwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (wrist2TwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(wrist2TwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsWrist3Running(Wrist3TwinHubModel? wrist3TwinHubModel)
        {
            if (wrist3TwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (wrist3TwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (wrist3TwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (wrist3TwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(wrist3TwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
        public static string IsToolRunning(ToolTwinHubModel? toolTwinHubModel)
        {
            if (toolTwinHubModel is null)
            {
                return "Not Syncing";
            }
            if (toolTwinHubModel.Value is null)
            {
                return "Not Syncing";
            }
            if (toolTwinHubModel.Value.Metadata is null)
            {
                return "Not Syncing";
            }
            if (toolTwinHubModel.Value.Metadata.LastUpdateTime is null)
            {
                return "Not Syncing";
            }
            DateTime lastUpdateTime = DateTime.Parse(toolTwinHubModel.Value.Metadata.LastUpdateTime);
            TimeSpan timeDifference = DateTime.Now - lastUpdateTime;
            if (timeDifference.TotalSeconds <= MAX_SECONDS)
            {
                return "Running";
            }
            else
            {
                return "Idle";
            }
        }
    }
}