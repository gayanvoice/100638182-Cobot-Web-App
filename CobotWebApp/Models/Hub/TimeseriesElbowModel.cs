namespace CobotWebApp.Models.Hub
{
    public class TimeseriesElbowModel
    {
        public double Duration { get; set; }
        public string? LastUpdateTime { get; set; }
        public ElbowTwinHubModel.ElbowTwinModel? ElbowTwinModel { get; set; }
        public static TimeseriesElbowModel GetElbowTwinHubModel(
            double duration,
            ElbowTwinHubModel? elbowTwinHubModel)
        { 
            ElbowTwinHubModel.ElbowTwinModel ElbowTwinModel = ElbowTwinHubModel.ElbowTwinModel
                .GetElbowTwinModel(elbowTwinHubModel: elbowTwinHubModel);
            TimeseriesElbowModel timeseriesElbowModel = new TimeseriesElbowModel();
            timeseriesElbowModel.Duration = duration;
            if (elbowTwinHubModel is not null &&
                elbowTwinHubModel.Value is not null &&
                elbowTwinHubModel.Value.Metadata is not null)
            {
                timeseriesElbowModel.LastUpdateTime = elbowTwinHubModel.Value.Metadata.LastUpdateTime;
            }
            timeseriesElbowModel.ElbowTwinModel = ElbowTwinModel;
            return timeseriesElbowModel;
        }
    }
}