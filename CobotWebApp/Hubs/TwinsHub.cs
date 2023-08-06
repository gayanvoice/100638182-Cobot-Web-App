using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using CobotWebApp.Helper;
using CobotWebApp.Models.Hub;
using System.Diagnostics;

namespace CobotWebApp.Hubs
{
    [Authorize]
    public class TwinsHub : Hub
    {
        public async Task TwinsTelemetryTask()
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
            TwinsTelemetryModel twinsTelemetryModel = TwinsTelemetryModel.GetTwinsTelemetryModel(
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
                toolTwinHubModel: toolTwinHubModel
                );

            await Clients.All.SendAsync("TwinsTelemetryResponse", System.Text.Json.JsonSerializer.Serialize(twinsTelemetryModel));
        }
        public async Task TwinOfTwinTask()
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

            Task<CobotTwinHubModel?> tCobotTwinHubModelTask = TwinsHubHelper.GetTCobotTwinHubModel();
            Task<ControlBoxTwinHubModel?> tControlBoxTwinHubModelTask = TwinsHubHelper.GetTControlBoxTwinHubModel();
            Task<PayloadTwinHubModel?> tPayloadTwinHubModelTask = TwinsHubHelper.GetTPayloadTwinHubModel();
            Task<BaseTwinHubModel?> tBaseTwinHubModelTask = TwinsHubHelper.GetTBaseTwinHubModel();
            Task<ShoulderTwinHubModel?> tShoulderTwinHubModelTask = TwinsHubHelper.GetTShoulderTwinHubModel();
            Task<ElbowTwinHubModel?> tElbowTwinHubModelTask = TwinsHubHelper.GetTElbowTwinHubModel();
            Task<Wrist1TwinHubModel?> tWrist1TwinHubModelTask = TwinsHubHelper.GetTWrist1TwinHubModel();
            Task<Wrist2TwinHubModel?> tWrist2TwinHubModelTask = TwinsHubHelper.GetTWrist2TwinHubModel();
            Task<Wrist3TwinHubModel?> tWrist3TwinHubModelTask = TwinsHubHelper.GetTWrist3TwinHubModel();
            Task<ToolTwinHubModel?> tToolTwinHubModelTask = TwinsHubHelper.GetTToolTwinHubModel();

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
                toolTwinHubModelTask,
                tCobotTwinHubModelTask,
                tControlBoxTwinHubModelTask,
                tPayloadTwinHubModelTask,
                tBaseTwinHubModelTask,
                tShoulderTwinHubModelTask,
                tElbowTwinHubModelTask,
                tWrist1TwinHubModelTask,
                tWrist2TwinHubModelTask,
                tWrist3TwinHubModelTask,
                tToolTwinHubModelTask);

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

            CobotTwinHubModel? tCobotTwinHubModel = tCobotTwinHubModelTask.Result;
            ControlBoxTwinHubModel? tControlBoxTwinHubModel = tControlBoxTwinHubModelTask.Result;
            PayloadTwinHubModel? tPayloadTwinHubModel = tPayloadTwinHubModelTask.Result;
            BaseTwinHubModel? tBaseTwinHubModel = tBaseTwinHubModelTask.Result;
            ShoulderTwinHubModel? tShoulderTwinHubModel = tShoulderTwinHubModelTask.Result;
            ElbowTwinHubModel? tElbowTwinHubModel = tElbowTwinHubModelTask.Result;
            Wrist1TwinHubModel? tWrist1TwinHubModel = tWrist1TwinHubModelTask.Result;
            Wrist2TwinHubModel? tWrist2TwinHubModel = tWrist2TwinHubModelTask.Result;
            Wrist3TwinHubModel? tWrist3TwinHubModel = tWrist3TwinHubModelTask.Result;
            ToolTwinHubModel? tToolTwinHubModel = tToolTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TwinOfTwinModel twinOfTwinModel = TwinOfTwinModel.GetTwinOfTwinModel(
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
                toolTwinHubModel: toolTwinHubModel,
                tCobotTwinHubModel: tCobotTwinHubModel,
                tControlBoxTwinHubModel: tControlBoxTwinHubModel,
                tPayloadTwinHubModel: tPayloadTwinHubModel,
                tBaseTwinHubModel: tBaseTwinHubModel,
                tShoulderTwinHubModel: tShoulderTwinHubModel,
                tElbowTwinHubModel: tElbowTwinHubModel,
                tWrist1TwinHubModel: tWrist1TwinHubModel,
                tWrist2TwinHubModel: tWrist2TwinHubModel,
                tWrist3TwinHubModel: tWrist3TwinHubModel,
                tToolTwinHubModel: tToolTwinHubModel);
            await Clients.All.SendAsync("TwinOfTwinResponse", System.Text.Json.JsonSerializer.Serialize(twinOfTwinModel));
        }
        public async Task TwinsStatusTask()
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
            TwinsStatusModel twinsStatusModel = TwinsStatusModel.GetTwinsStatusModel(
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
                toolTwinHubModel: toolTwinHubModel
                );

            await Clients.All.SendAsync("TwinsStatusResponse", System.Text.Json.JsonSerializer.Serialize(twinsStatusModel));
        }
        public async Task TwinsSimulationTask()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task<ElbowTwinHubModel?> elbowTwinHubModelTask = TwinsHubHelper.GetElbowTwinHubModel();
            Task<ToolTwinHubModel?> toolTwinHubModelTask = TwinsHubHelper.GetToolTwinHubModel();

            await Task.WhenAll(
                elbowTwinHubModelTask,
                toolTwinHubModelTask);

            ElbowTwinHubModel? elbowTwinHubModel = elbowTwinHubModelTask.Result;
            ToolTwinHubModel? toolTwinHubModel = toolTwinHubModelTask.Result;

            stopwatch.Stop();
            double duration = stopwatch.Elapsed.TotalMilliseconds;
            TwinsSimulationModel twinsSimulationModel = TwinsSimulationModel.GetTwinSimulationModel(
                duration: duration,
                elbowTwinHubModel: elbowTwinHubModel,
                toolTwinHubModel: toolTwinHubModel
                );

            await Clients.All.SendAsync("TwinsSimulationResponse", System.Text.Json.JsonSerializer.Serialize(twinsSimulationModel));
        }
    }
}