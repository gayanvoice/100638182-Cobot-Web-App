using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class ControlBoxTwinHubModel
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
        public class ControlBoxTwinModel
        {
            public double Voltage { get; set; }
            public static ControlBoxTwinModel GetControlBoxTwinModel(ControlBoxTwinHubModel? controlBoxTwinHubModel)
            {
                ControlBoxTwinModel controlBoxTwinModel = new ControlBoxTwinModel();
                if (controlBoxTwinHubModel is not null &&
                    controlBoxTwinHubModel.Value is not null)
                {
                    controlBoxTwinModel.Voltage = controlBoxTwinHubModel.Value.Voltage;
                }
                else
                {
                    controlBoxTwinModel.Voltage = 0.0;
                }
                return controlBoxTwinModel;
            }
        }
    }
}