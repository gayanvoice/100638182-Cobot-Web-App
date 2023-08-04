namespace CobotWebApp.Models.Hub
{
    public class TwinOfTwinModel
    {
        public double Duration { get; set; }
        public CobotTwinHubModel.CobotTwinModel? CobotTwinModel { get; set; }
        public CobotTwinHubModel.CobotTwinModel? TCobotTwinModel { get; set; }
        public ControlBoxTwinHubModel.ControlBoxTwinModel? ControlBoxTwinModel { get; set; }
        public ControlBoxTwinHubModel.ControlBoxTwinModel? TControlBoxTwinModel { get; set; }
        public PayloadTwinHubModel.PayloadTwinModel? PayloadTwinModel { get; set; }
        public PayloadTwinHubModel.PayloadTwinModel? TPayloadTwinModel { get; set; }
        public BaseTwinHubModel.BaseTwinModel? BaseTwinModel { get; set; }
        public BaseTwinHubModel.BaseTwinModel? TBaseTwinModel { get; set; }
        public ShoulderTwinHubModel.ShoulderTwinModel? ShoulderTwinModel { get; set; }
        public ShoulderTwinHubModel.ShoulderTwinModel? TShoulderTwinModel { get; set; }
        public ElbowTwinHubModel.ElbowTwinModel? ElbowTwinModel { get; set; }
        public ElbowTwinHubModel.ElbowTwinModel? TElbowTwinModel { get; set; }
        public Wrist1TwinHubModel.Wrist1TwinModel? Wrist1TwinModel { get; set; }
        public Wrist1TwinHubModel.Wrist1TwinModel? TWrist1TwinModel { get; set; }
        public Wrist2TwinHubModel.Wrist2TwinModel? Wrist2TwinModel { get; set; }
        public Wrist2TwinHubModel.Wrist2TwinModel? TWrist2TwinModel { get; set; }
        public Wrist3TwinHubModel.Wrist3TwinModel? Wrist3TwinModel { get; set; }
        public Wrist3TwinHubModel.Wrist3TwinModel? TWrist3TwinModel { get; set; }
        public ToolTwinHubModel.ToolTwinModel? ToolTwinModel { get; set; }
        public ToolTwinHubModel.ToolTwinModel? TToolTwinModel { get; set; }
        public static TwinOfTwinModel GetTwinOfTwinModel(
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
            ToolTwinHubModel? toolTwinHubModel,
            CobotTwinHubModel? tCobotTwinHubModel,
            ControlBoxTwinHubModel? tControlBoxTwinHubModel,
            PayloadTwinHubModel? tPayloadTwinHubModel,
            BaseTwinHubModel? tBaseTwinHubModel,
            ShoulderTwinHubModel? tShoulderTwinHubModel,
            ElbowTwinHubModel? tElbowTwinHubModel,
            Wrist1TwinHubModel? tWrist1TwinHubModel,
            Wrist2TwinHubModel? tWrist2TwinHubModel,
            Wrist3TwinHubModel? tWrist3TwinHubModel,
            ToolTwinHubModel? tToolTwinHubModel)
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

            CobotTwinHubModel.CobotTwinModel tCobotTwinModel = CobotTwinHubModel.CobotTwinModel.GetCobotTwinModel(cobotTwinHubModel: tCobotTwinHubModel);
            ControlBoxTwinHubModel.ControlBoxTwinModel tControlBoxTwinModel = ControlBoxTwinHubModel.ControlBoxTwinModel.GetControlBoxTwinModel(controlBoxTwinHubModel: tControlBoxTwinHubModel);
            PayloadTwinHubModel.PayloadTwinModel tPayloadTwinModel = PayloadTwinHubModel.PayloadTwinModel.GetPayloadTwinModel(payloadTwinHubModel: tPayloadTwinHubModel);
            BaseTwinHubModel.BaseTwinModel tBaseTwinModel = BaseTwinHubModel.BaseTwinModel.GetBaseTwinModel(baseTwinHubModel: tBaseTwinHubModel);
            ShoulderTwinHubModel.ShoulderTwinModel tShoulderTwinModel = ShoulderTwinHubModel.ShoulderTwinModel.GetShoulderTwinModel(shoulderTwinHubModel: tShoulderTwinHubModel);
            ElbowTwinHubModel.ElbowTwinModel tElbowTwinModel = ElbowTwinHubModel.ElbowTwinModel.GetElbowTwinModel(elbowTwinHubModel: tElbowTwinHubModel);
            Wrist1TwinHubModel.Wrist1TwinModel tWrist1TwinModel = Wrist1TwinHubModel.Wrist1TwinModel.GetWrist1TwinModel(wrist1TwinHubModel: tWrist1TwinHubModel);
            Wrist2TwinHubModel.Wrist2TwinModel tWrist2TwinModel = Wrist2TwinHubModel.Wrist2TwinModel.GetWrist2TwinModel(wrist2TwinHubModel: tWrist2TwinHubModel);
            Wrist3TwinHubModel.Wrist3TwinModel tWrist3TwinModel = Wrist3TwinHubModel.Wrist3TwinModel.GetWrist3TwinModel(wrist3TwinHubModel: tWrist3TwinHubModel);
            ToolTwinHubModel.ToolTwinModel tToolTwinModel = ToolTwinHubModel.ToolTwinModel.GetToolTwinModel(toolTwinHubModel: tToolTwinHubModel);

            TwinOfTwinModel twinOfTwinModel = new TwinOfTwinModel();
            twinOfTwinModel.Duration = duration;
            twinOfTwinModel.CobotTwinModel = cobotTwinModel;
            twinOfTwinModel.ControlBoxTwinModel = controlBoxTwinModel;
            twinOfTwinModel.PayloadTwinModel = payloadTwinModel;
            twinOfTwinModel.BaseTwinModel = baseTwinModel;
            twinOfTwinModel.ShoulderTwinModel = shoulderTwinModel;
            twinOfTwinModel.ElbowTwinModel = elbowTwinModel;
            twinOfTwinModel.Wrist1TwinModel = wrist1TwinModel;
            twinOfTwinModel.Wrist2TwinModel = wrist2TwinModel;
            twinOfTwinModel.Wrist3TwinModel = wrist3TwinModel;
            twinOfTwinModel.ToolTwinModel = tToolTwinModel;
            twinOfTwinModel.TCobotTwinModel = tCobotTwinModel;
            twinOfTwinModel.TControlBoxTwinModel = tControlBoxTwinModel;
            twinOfTwinModel.TPayloadTwinModel = tPayloadTwinModel;
            twinOfTwinModel.TBaseTwinModel = tBaseTwinModel;
            twinOfTwinModel.TShoulderTwinModel = tShoulderTwinModel;
            twinOfTwinModel.TElbowTwinModel = tElbowTwinModel;
            twinOfTwinModel.TWrist1TwinModel = tWrist1TwinModel;
            twinOfTwinModel.TWrist2TwinModel = tWrist2TwinModel;
            twinOfTwinModel.TWrist3TwinModel = tWrist3TwinModel;
            twinOfTwinModel.TToolTwinModel = tToolTwinModel;
            return twinOfTwinModel;
        }
    }
}