namespace CobotWebApp.Models.Hub
{
    public class TwinsStatusModel
    {
        public double Duration { get; set; }
        public CobotTwinHubModel? CobotTwinHubModel { get; set; }
        public ControlBoxTwinHubModel? ControlBoxTwinHubModel { get; set; }
        public PayloadTwinHubModel? PayloadTwinHubModel { get; set; }
        public BaseTwinHubModel? BaseTwinHubModel { get; set; }
        public ShoulderTwinHubModel? ShoulderTwinHubModel { get; set; }
        public ElbowTwinHubModel? ElbowTwinHubModel { get; set; }
        public Wrist1TwinHubModel? Wrist1TwinHubModel { get; set; }
        public Wrist2TwinHubModel? Wrist2TwinHubModel { get; set; }
        public Wrist3TwinHubModel? Wrist3TwinHubModel { get; set; }
        public ToolTwinHubModel? ToolTwinHubModel { get; set; }
        public static TwinsStatusModel GetTwinsStatusModel(
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
            TwinsStatusModel twinsStatusModel = new TwinsStatusModel();
            twinsStatusModel.Duration = duration;
            twinsStatusModel.CobotTwinHubModel = cobotTwinHubModel;
            twinsStatusModel.ControlBoxTwinHubModel = controlBoxTwinHubModel;
            twinsStatusModel.PayloadTwinHubModel = payloadTwinHubModel;
            twinsStatusModel.BaseTwinHubModel = baseTwinHubModel;
            twinsStatusModel.ShoulderTwinHubModel = shoulderTwinHubModel;
            twinsStatusModel.ElbowTwinHubModel = elbowTwinHubModel;
            twinsStatusModel.Wrist1TwinHubModel = wrist1TwinHubModel;
            twinsStatusModel.Wrist2TwinHubModel = wrist2TwinHubModel;
            twinsStatusModel.Wrist3TwinHubModel = wrist3TwinHubModel;
            twinsStatusModel.ToolTwinHubModel = toolTwinHubModel;
            return twinsStatusModel;
        }
    }
}