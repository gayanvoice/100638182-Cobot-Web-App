using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class Wrist1TwinHubModel
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
        public class Wrist1TwinModel
        {
            public double Temperature { get; set; }
            public double Position { get; set; }
            public double Voltage { get; set; }
            public static Wrist1TwinModel GetWrist1TwinModel(Wrist1TwinHubModel? wrist1TwinHubModel)
            {
                Wrist1TwinModel wrist1TwinModel = new Wrist1TwinModel();
                if (wrist1TwinHubModel is not null &&
                    wrist1TwinHubModel.Value is not null)
                {
                    wrist1TwinModel.Temperature = wrist1TwinHubModel.Value.Temperature;
                    wrist1TwinModel.Position = wrist1TwinHubModel.Value.Position;
                    wrist1TwinModel.Voltage = wrist1TwinHubModel.Value.Voltage;
                }
                else
                {
                    wrist1TwinModel.Temperature = 0.0;
                    wrist1TwinModel.Position = 0.0;
                    wrist1TwinModel.Voltage = 0.0;
                }
                return wrist1TwinModel;
            }
        }
    }
}