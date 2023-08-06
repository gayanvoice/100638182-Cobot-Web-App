using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using CobotWebApp.Helper;
using CobotWebApp.Models.Hub;
using System.Diagnostics;

namespace CobotWebApp.Hubs
{
    [Authorize]
    public class TimeseriesHub : Hub
    {
        public async Task TimeseriesDashboardTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<CobotTwinHubModel?> cobotTwinHubModelTask = TwinsHubHelper.GetCobotTwinHubModel();
            Task<ControlBoxTwinHubModel?> controlBoxTwinHubModelTask = TwinsHubHelper.GetControlBoxTwinHubModel();
            Task<PayloadTwinHubModel?> payloadTwinHubModelTask = TwinsHubHelper.GetPayloadTwinHubModel();
            Task<BaseTwinHubModel?> baseTwinHubModelTask = TwinsHubHelper.GetBaseTwinHubModel();
            Task<ShoulderTwinHubModel?> shoulderTwinHubModelTask = TwinsHubHelper.GetShoulderTwinHubModel();
            Task<ElbowTwinHubModel?> elbowTwinHubModelTask = TwinsHubHelper.GetElbowTwinHubModel();
            Task<Wrist1TwinHubModel?> wrist1TwinHubModelTask = TwinsHubHelper.GetWrist1TwinHubModel();
            Task<Wrist2TwinHubModel?> wrist2TwinHubModelTask = TwinsHubHelper.GetWrist2TwinHubModel();
            Task<Wrist3TwinHubModel?> wrist3TwinHubModelTask = TwinsHubHelper.GetWrist3TwinHubModel();
            Task<ToolTwinHubModel?> toolTwinHubModelTask = TwinsHubHelper.GetToolTwinHubModel();

            await Task.WhenAll(
                cobotTwinHubModelTask,
                controlBoxTwinHubModelTask,
                payloadTwinHubModelTask,
                baseTwinHubModelTask,
                shoulderTwinHubModelTask,
                elbowTwinHubModelTask,
                wrist1TwinHubModelTask,
                wrist2TwinHubModelTask,
                wrist3TwinHubModelTask,
                toolTwinHubModelTask);

            CobotTwinHubModel? cobotTwinHubModel = cobotTwinHubModelTask.Result;
            ControlBoxTwinHubModel? controlBoxTwinHubModel = controlBoxTwinHubModelTask.Result;
            PayloadTwinHubModel? payloadTwinHubModel = payloadTwinHubModelTask.Result;
            BaseTwinHubModel? baseTwinHubModel = baseTwinHubModelTask.Result;
            ShoulderTwinHubModel? shoulderTwinHubModel = shoulderTwinHubModelTask.Result;
            ElbowTwinHubModel? elbowTwinHubModel = elbowTwinHubModelTask.Result;
            Wrist1TwinHubModel? wrist1TwinHubModel = wrist1TwinHubModelTask.Result;
            Wrist2TwinHubModel? wrist2TwinHubModel = wrist2TwinHubModelTask.Result;
            Wrist3TwinHubModel? wrist3TwinHubModel = wrist3TwinHubModelTask.Result;
            ToolTwinHubModel? toolTwinHubModel = toolTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;

            TimeseriesDashboardModel timeseriesStatusModel = TimeseriesDashboardModel.GetTimeseriesDashboardModel(
                duration: duration,
                cobotTwinHubModel: cobotTwinHubModel,
                controlBoxTwinHubModel: controlBoxTwinHubModel,
                payloadTwinHubModel: payloadTwinHubModel,
                baseTwinHubModel: baseTwinHubModel,
                shoulderTwinHubModel: shoulderTwinHubModel,
                elbowTwinHubModel: elbowTwinHubModel,
                wrist1TwinHubModel: wrist1TwinHubModel,
                wrist2TwinHubModel: wrist2TwinHubModel,
                wrist3TwinHubModel: wrist3TwinHubModel,
                toolTwinHubModel: toolTwinHubModel);

            await Clients.All.SendAsync("TimeseriesDashboardResponse", System.Text.Json.JsonSerializer.Serialize(timeseriesStatusModel));
        }
        public async Task TimeseriesCobotTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<CobotTwinHubModel?> cobotTwinHubModelTask = TwinsHubHelper.GetCobotTwinHubModel();

            await Task.WhenAll(cobotTwinHubModelTask);

            CobotTwinHubModel? cobotTwinHubModel = cobotTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesCobotModel timeseriesCobotModel = TimeseriesCobotModel.GetCobotTwinHubModel(
                duration: duration,
                cobotTwinHubModel: cobotTwinHubModel);

            await Clients.All.SendAsync("TimeseriesCobotResponse", System.Text.Json.JsonSerializer.Serialize(timeseriesCobotModel));
        }
    }
}