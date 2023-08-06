namespace CobotWebApp.Models.Hub
{
    public class TwinsSimulationModel
    {
        public double Duration { get; set; }
        public ElbowTwinHubModel.ElbowTwinModel? ElbowTwinModel { get; set; }
        public ToolTwinHubModel.ToolTwinModel? ToolTwinModel { get; set; }
        public static TwinsSimulationModel GetTwinSimulationModel(
            double duration,
            ElbowTwinHubModel? elbowTwinHubModel,
            ToolTwinHubModel? toolTwinHubModel)
        { 
            ElbowTwinHubModel.ElbowTwinModel elbowTwinModel = ElbowTwinHubModel.ElbowTwinModel.GetElbowTwinModel(elbowTwinHubModel: elbowTwinHubModel);
            ToolTwinHubModel.ToolTwinModel toolTwinModel = ToolTwinHubModel.ToolTwinModel.GetToolTwinModel(toolTwinHubModel: toolTwinHubModel);

            TwinsSimulationModel twinsSimulationModel = new TwinsSimulationModel();
            twinsSimulationModel.Duration = duration;
            twinsSimulationModel.ElbowTwinModel = elbowTwinModel;
            twinsSimulationModel.ToolTwinModel = toolTwinModel;
            return twinsSimulationModel;
        }
    }
}