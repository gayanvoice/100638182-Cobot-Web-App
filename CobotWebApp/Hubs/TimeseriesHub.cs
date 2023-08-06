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
        public async Task TimeseriesControlBoxTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<ControlBoxTwinHubModel?> controlBoxTwinHubModelTask = TwinsHubHelper.GetControlBoxTwinHubModel();

            await Task.WhenAll(controlBoxTwinHubModelTask);

            ControlBoxTwinHubModel? controlBoxTwinHubModel = controlBoxTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesControlBoxModel timeseriesControlBoxModel = TimeseriesControlBoxModel.GetControlBoxTwinHubModel(
                duration: duration,
                controlBoxTwinHubModel: controlBoxTwinHubModel);

            await Clients.All.SendAsync("TimeseriesControlBoxResponse", System.Text.Json.JsonSerializer.Serialize(timeseriesControlBoxModel));
        }
        public async Task TimeseriesPayloadTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<PayloadTwinHubModel?> payloadTwinHubModelTask = TwinsHubHelper.GetPayloadTwinHubModel();

            await Task.WhenAll(payloadTwinHubModelTask);

            PayloadTwinHubModel? payloadTwinHubModel = payloadTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesPayloadModel timeseriesPayloadModel = TimeseriesPayloadModel.GetPayloadTwinHubModel(
                duration: duration,
                payloadTwinHubModel: payloadTwinHubModel);

            await Clients.All.SendAsync("TimeseriesPayloadResponse", System.Text.Json.JsonSerializer.Serialize(timeseriesPayloadModel));
        }
        public async Task TimeseriesBaseTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<BaseTwinHubModel?> baseTwinHubModelTask = TwinsHubHelper.GetBaseTwinHubModel();

            await Task.WhenAll(baseTwinHubModelTask);

            BaseTwinHubModel? baseTwinHubModel = baseTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesBaseModel timeseriesBaseModel = TimeseriesBaseModel.GetBaseTwinHubModel(
                duration: duration,
                baseTwinHubModel: baseTwinHubModel);

            await Clients.All.SendAsync("TimeseriesBaseResponse", System.Text.Json.JsonSerializer.Serialize(timeseriesBaseModel));
        }
        public async Task TimeseriesShoulderTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<ShoulderTwinHubModel?> shoulderTwinHubModelTask = TwinsHubHelper.GetShoulderTwinHubModel();

            await Task.WhenAll(shoulderTwinHubModelTask);

            ShoulderTwinHubModel? shoulderTwinHubModel = shoulderTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesShoulderModel timeseriesShoulderModel = TimeseriesShoulderModel.GetShoulderTwinHubModel(
                duration: duration,
                shoulderTwinHubModel: shoulderTwinHubModel);

            await Clients.All.SendAsync("TimeseriesShoulderResponse", System.Text.Json.JsonSerializer.Serialize(timeseriesShoulderModel));
        }
        public async Task TimeseriesElbowTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<ElbowTwinHubModel?> elbowTwinHubModelTask = TwinsHubHelper.GetElbowTwinHubModel();

            await Task.WhenAll(elbowTwinHubModelTask);

            ElbowTwinHubModel? elbowTwinHubModel = elbowTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesElbowModel timeseriesElbowModel = TimeseriesElbowModel.GetElbowTwinHubModel(
                duration: duration,
                elbowTwinHubModel: elbowTwinHubModel);

            await Clients.All.SendAsync("TimeseriesElbowResponse", System.Text.Json.JsonSerializer.Serialize(timeseriesElbowModel));
        }
        public async Task TimeseriesWrist1Task()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<Wrist1TwinHubModel?> wrist1TwinHubModelTask = TwinsHubHelper.GetWrist1TwinHubModel();

            await Task.WhenAll(wrist1TwinHubModelTask);

            Wrist1TwinHubModel? wrist1TwinHubModel = wrist1TwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesWrist1Model timeseriesWrist1Model = TimeseriesWrist1Model.GetWrist1TwinHubModel(
                duration: duration,
                wrist1TwinHubModel: wrist1TwinHubModel);

            await Clients.All.SendAsync("TimeseriesWrist1Response", System.Text.Json.JsonSerializer.Serialize(timeseriesWrist1Model));
        }
        public async Task TimeseriesWrist2Task()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<Wrist2TwinHubModel?> wrist2TwinHubModelTask = TwinsHubHelper.GetWrist2TwinHubModel();

            await Task.WhenAll(wrist2TwinHubModelTask);

            Wrist2TwinHubModel? wrist2TwinHubModel = wrist2TwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesWrist2Model timeseriesWrist2Model = TimeseriesWrist2Model.GetWrist2TwinHubModel(
                duration: duration,
                wrist2TwinHubModel: wrist2TwinHubModel);

            await Clients.All.SendAsync("TimeseriesWrist2Response", System.Text.Json.JsonSerializer.Serialize(timeseriesWrist2Model));
        }
        public async Task TimeseriesWrist3Task()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<Wrist3TwinHubModel?> wrist3TwinHubModelTask = TwinsHubHelper.GetWrist3TwinHubModel();

            await Task.WhenAll(wrist3TwinHubModelTask);

            Wrist3TwinHubModel? wrist3TwinHubModel = wrist3TwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesWrist3Model timeseriesWrist3Model = TimeseriesWrist3Model.GetWrist3TwinHubModel(
                duration: duration,
                wrist3TwinHubModel: wrist3TwinHubModel);

            await Clients.All.SendAsync("TimeseriesWrist3Response", System.Text.Json.JsonSerializer.Serialize(timeseriesWrist3Model));
        }
        public async Task TimeseriesToolTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<ToolTwinHubModel?> toolTwinHubModelTask = TwinsHubHelper.GetToolTwinHubModel();

            await Task.WhenAll(toolTwinHubModelTask);

            ToolTwinHubModel? toolTwinHubModel = toolTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TimeseriesToolModel timeseriesToolModel = TimeseriesToolModel.GetToolTwinHubModel(
                duration: duration,
                toolTwinHubModel: toolTwinHubModel);

            await Clients.All.SendAsync("TimeseriesToolResponse", System.Text.Json.JsonSerializer.Serialize(timeseriesToolModel));
        }

    }
}