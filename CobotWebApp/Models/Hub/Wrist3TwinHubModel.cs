using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class Wrist3TwinHubModel
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
        public class Wrist3TwinModel
        {
            public double Temperature { get; set; }
            public double Position { get; set; }
            public double Voltage { get; set; }
            public static Wrist3TwinModel GetWrist3TwinModel(Wrist3TwinHubModel? wrist3TwinHubModel)
            {
                Wrist3TwinModel wrist3TwinModel = new Wrist3TwinModel();
                if (wrist3TwinHubModel is not null &&
                    wrist3TwinHubModel.Value is not null)
                {
                    wrist3TwinModel.Temperature = wrist3TwinHubModel.Value.Temperature;
                    wrist3TwinModel.Position = wrist3TwinHubModel.Value.Position;
                    wrist3TwinModel.Voltage = wrist3TwinHubModel.Value.Voltage;
                }
                else
                {
                    wrist3TwinModel.Temperature = 0.0;
                    wrist3TwinModel.Position = 0.0;
                    wrist3TwinModel.Voltage = 0.0;
                }
                return wrist3TwinModel;
            }
        }
    }
}