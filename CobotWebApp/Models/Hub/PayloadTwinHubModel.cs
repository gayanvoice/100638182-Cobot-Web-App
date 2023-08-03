using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class PayloadTwinHubModel
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

            [JsonProperty("CogX")]
            public double CogX { get; set; }
            [JsonProperty("CogY")]
            public double CogY { get; set; }
            [JsonProperty("CogZ")]
            public double CogZ { get; set; }
            [JsonProperty("Mass")]
            public double Mass { get; set; }
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
        public class PayloadTwinModel
        {
            public double CogX { get; set; }
            public double CogY { get; set; }
            public double CogZ { get; set; }
            public double Mass { get; set; }
            public static PayloadTwinModel GetPayloadTwinModel(PayloadTwinHubModel? payloadTwinHubModel)
            {
                PayloadTwinModel payloadTwinModel = new PayloadTwinModel();
                if (payloadTwinHubModel is not null &&
                    payloadTwinHubModel.Value is not null)
                {
                    payloadTwinModel.CogX = payloadTwinHubModel.Value.CogX;
                    payloadTwinModel.CogY = payloadTwinHubModel.Value.CogY;
                    payloadTwinModel.CogZ = payloadTwinHubModel.Value.CogZ;
                    payloadTwinModel.Mass = payloadTwinHubModel.Value.Mass;
                }
                else
                {
                    payloadTwinModel.CogX = 0.0;
                    payloadTwinModel.CogY = 0.0;
                    payloadTwinModel.CogZ = 0.0;
                    payloadTwinModel.Mass = 0.0;
                }
                return payloadTwinModel;
            }
        }
    }
}