using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class BaseTwinHubModel
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
        public class BaseTwinModel
        {
            public double Temperature { get; set; }
            public double Position { get; set; }
            public double Voltage { get; set; }
            public static BaseTwinModel GetBaseTwinModel(BaseTwinHubModel? baseTwinHubModel)
            {
                BaseTwinModel baseTwinModel = new BaseTwinModel();
                if (baseTwinHubModel is not null &&
                    baseTwinHubModel.Value is not null)
                {
                    baseTwinModel.Temperature = baseTwinHubModel.Value.Temperature;
                    baseTwinModel.Position = baseTwinHubModel.Value.Position;
                    baseTwinModel.Voltage = baseTwinHubModel.Value.Voltage;
                }
                else
                {
                    baseTwinModel.Temperature = 0.0;
                    baseTwinModel.Position = 0.0;
                    baseTwinModel.Voltage = 0.0;
                }
                return baseTwinModel;
            }
        }
    }
}