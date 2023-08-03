using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class CobotTwinHubModel
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

            [JsonProperty("ElapsedTime")]
            public double ElapsedTime { get; set; }

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
        public class CobotTwinModel
        {
            public double ElapsedTime { get; set; }
            public static CobotTwinModel GetCobotTwinModel(CobotTwinHubModel? cobotTwinHubModel)
            {
                CobotTwinModel cobotTwinModel = new CobotTwinModel();
                if (cobotTwinHubModel is not null &&
                    cobotTwinHubModel.Value is not null)
                {
                    cobotTwinModel.ElapsedTime = cobotTwinHubModel.Value.ElapsedTime;
                }
                else
                {
                    cobotTwinModel.ElapsedTime = 0.0;
                }
                return cobotTwinModel;
            }
        }
    }
}