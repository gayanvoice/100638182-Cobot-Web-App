namespace CobotWebApp.Models.Hub
{
    public class TwinsTelemetryModel
    {
        public double Duration { get; set; }
        public CobotTwinHubModel.CobotTwinModel? CobotTwinModel { get; set; }
        public ControlBoxTwinHubModel.ControlBoxTwinModel? ControlBoxTwinModel { get; set; }
        public PayloadTwinHubModel.PayloadTwinModel? PayloadTwinModel { get; set; }
        public BaseTwinHubModel.BaseTwinModel? BaseTwinModel { get; set; }
        public ShoulderTwinHubModel.ShoulderTwinModel? ShoulderTwinModel { get; set; }
        public ElbowTwinHubModel.ElbowTwinModel? ElbowTwinModel { get; set; }
        public Wrist1TwinHubModel.Wrist1TwinModel? Wrist1TwinModel { get; set; }
        public Wrist2TwinHubModel.Wrist2TwinModel? Wrist2TwinModel { get; set; }
        public Wrist3TwinHubModel.Wrist3TwinModel? Wrist3TwinModel { get; set; }
        public ToolTwinHubModel.ToolTwinModel? ToolTwinModel { get; set; }
        public static TwinsTelemetryModel GetTwinsTelemetryModel(
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
            CobotTwinHubModel.CobotTwinModel cobotTwinModel = CobotTwinHubModel.CobotTwinModel.GetCobotTwinModel(cobotTwinHubModel: cobotTwinHubModel);
            ControlBoxTwinHubModel.ControlBoxTwinModel controlBoxTwinModel = ControlBoxTwinHubModel.ControlBoxTwinModel.GetControlBoxTwinModel(controlBoxTwinHubModel: controlBoxTwinHubModel);
            PayloadTwinHubModel.PayloadTwinModel payloadTwinModel = PayloadTwinHubModel.PayloadTwinModel.GetPayloadTwinModel(payloadTwinHubModel: payloadTwinHubModel);
            BaseTwinHubModel.BaseTwinModel baseTwinModel = BaseTwinHubModel.BaseTwinModel.GetBaseTwinModel(baseTwinHubModel: baseTwinHubModel);
            ShoulderTwinHubModel.ShoulderTwinModel shoulderTwinModel = ShoulderTwinHubModel.ShoulderTwinModel.GetShoulderTwinModel(shoulderTwinHubModel: shoulderTwinHubModel);
            ElbowTwinHubModel.ElbowTwinModel elbowTwinModel = ElbowTwinHubModel.ElbowTwinModel.GetElbowTwinModel(elbowTwinHubModel: elbowTwinHubModel);
            Wrist1TwinHubModel.Wrist1TwinModel wrist1TwinModel = Wrist1TwinHubModel.Wrist1TwinModel.GetWrist1TwinModel(wrist1TwinHubModel: wrist1TwinHubModel);
            Wrist2TwinHubModel.Wrist2TwinModel wrist2TwinModel = Wrist2TwinHubModel.Wrist2TwinModel.GetWrist2TwinModel(wrist2TwinHubModel: wrist2TwinHubModel);
            Wrist3TwinHubModel.Wrist3TwinModel wrist3TwinModel = Wrist3TwinHubModel.Wrist3TwinModel.GetWrist3TwinModel(wrist3TwinHubModel: wrist3TwinHubModel);
            ToolTwinHubModel.ToolTwinModel toolTwinModel = ToolTwinHubModel.ToolTwinModel.GetToolTwinModel(toolTwinHubModel: toolTwinHubModel);

            TwinsTelemetryModel twinsTelemetryModel = new TwinsTelemetryModel();
            twinsTelemetryModel.Duration = duration;
            twinsTelemetryModel.CobotTwinModel = cobotTwinModel;
            twinsTelemetryModel.ControlBoxTwinModel = controlBoxTwinModel;
            twinsTelemetryModel.PayloadTwinModel = payloadTwinModel;
            twinsTelemetryModel.BaseTwinModel = baseTwinModel;
            twinsTelemetryModel.ShoulderTwinModel = shoulderTwinModel;
            twinsTelemetryModel.ElbowTwinModel = elbowTwinModel;
            twinsTelemetryModel.Wrist1TwinModel = wrist1TwinModel;
            twinsTelemetryModel.Wrist2TwinModel = wrist2TwinModel;
            twinsTelemetryModel.Wrist3TwinModel = wrist3TwinModel;
            twinsTelemetryModel.ToolTwinModel = toolTwinModel;
            return twinsTelemetryModel;
        }
    }
}