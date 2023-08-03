using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class Wrist2TwinHubModel
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
        public class Wrist2TwinModel
        {
            public double Temperature { get; set; }
            public double Position { get; set; }
            public double Voltage { get; set; }
            public static Wrist2TwinModel GetWrist2TwinModel(Wrist2TwinHubModel? wrist2TwinHubModel)
            {
                Wrist2TwinModel wrist2TwinModel = new Wrist2TwinModel();
                if (wrist2TwinHubModel is not null &&
                    wrist2TwinHubModel.Value is not null)
                {
                    wrist2TwinModel.Temperature = wrist2TwinHubModel.Value.Temperature;
                    wrist2TwinModel.Position = wrist2TwinHubModel.Value.Position;
                    wrist2TwinModel.Voltage = wrist2TwinHubModel.Value.Voltage;
                }
                else
                {
                    wrist2TwinModel.Temperature = 0.0;
                    wrist2TwinModel.Position = 0.0;
                    wrist2TwinModel.Voltage = 0.0;
                }
                return wrist2TwinModel;
            }
        }
    }
}