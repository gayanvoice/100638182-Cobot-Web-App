using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class ElbowTwinHubModel
    {
        [JsonProperty("HasValue")]
        public bool HasValue { get; set; }

        [JsonProperty("Value")]
        public ValueModel? Value { get; set; }
        public class ValueModel
        {
            [JsonProperty("$dtId")]
            public string? DtId { get; set; }

            [JsonProperty("$etag")]
            public string? Etag { get; set; }

            [JsonProperty("Temperature")]
            public double Temperature { get; set; }
            [JsonProperty("Position")]
            public double Position { get; set; }
            [JsonProperty("Voltage")]
            public double Voltage { get; set; }
            [JsonProperty("X")]
            public double X { get; set; }
            [JsonProperty("Y")]
            public double Y { get; set; }
            [JsonProperty("Z")]
            public double Z { get; set; }

            [JsonProperty("$metadata")]
            public MetaDataModel? Metadata { get; set; }
            public class MetaDataModel
            {
                [JsonProperty("$model")]
                public string? Model { get; set; }

                [JsonProperty("ElapsedTime")]
                public ElapsedTimeModel? ElapsedTime { get; set; }

                [JsonProperty("$lastUpdateTime")]
                public string? LastUpdateTime { get; set; }
                public class ElapsedTimeModel
                {
                    [JsonProperty("lastUpdateTime")]
                    public string? LastUpdateTime { get; set; }

                    [JsonProperty("sourceTime")]
                    public object? SourceTime { get; set; }
                }
            }
        }
        public class ElbowTwinModel
        {
            public double Temperature { get; set; }
            public double Position { get; set; }
            public double Voltage { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public static ElbowTwinModel GetElbowTwinModel(ElbowTwinHubModel? elbowTwinHubModel)
            {
                ElbowTwinModel elbowTwinModel = new ElbowTwinModel();
                if (elbowTwinHubModel is not null &&
                    elbowTwinHubModel.Value is not null)
                {
                    elbowTwinModel.Temperature = elbowTwinHubModel.Value.Temperature;
                    elbowTwinModel.Position = elbowTwinHubModel.Value.Position;
                    elbowTwinModel.Voltage = elbowTwinHubModel.Value.Voltage;
                    elbowTwinModel.X = elbowTwinHubModel.Value.X;
                    elbowTwinModel.Y = elbowTwinHubModel.Value.Y;
                    elbowTwinModel.Z = elbowTwinHubModel.Value.Z;
                }
                else
                {
                    elbowTwinModel.Temperature = 0.0;
                    elbowTwinModel.Position = 0.0;
                    elbowTwinModel.Voltage = 0.0;
                    elbowTwinModel.X = 0.0;
                    elbowTwinModel.Y = 0.0;
                    elbowTwinModel.Z = 0.0;
                }
                return elbowTwinModel;
            }
        }
    }
}