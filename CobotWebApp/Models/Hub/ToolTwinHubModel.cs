using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class ToolTwinHubModel
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
            [JsonProperty("Voltage")]
            public double Voltage { get; set; }
            [JsonProperty("Rx")]
            public double Rx { get; set; }
            [JsonProperty("Ry")]
            public double Ry { get; set; }
            [JsonProperty("Rz")]
            public double Rz { get; set; }
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
        public class ToolTwinModel
        {
            public double Temperature { get; set; }
            public double Voltage { get; set; }
            public double Rx { get; set; }
            public double Ry { get; set; }
            public double Rz { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public static ToolTwinModel GetToolTwinModel(ToolTwinHubModel? toolTwinHubModel)
            {
                ToolTwinModel toolTwinModel = new ToolTwinModel();
                if (toolTwinHubModel is not null &&
                    toolTwinHubModel.Value is not null)
                {
                    toolTwinModel.Temperature = toolTwinHubModel.Value.Temperature;
                    toolTwinModel.Voltage = toolTwinHubModel.Value.Voltage;
                    toolTwinModel.Rx = toolTwinHubModel.Value.Rx;
                    toolTwinModel.Ry = toolTwinHubModel.Value.Ry;
                    toolTwinModel.Rz = toolTwinHubModel.Value.Rz;
                }
                else
                {
                    toolTwinModel.Temperature = 0.0;
                    toolTwinModel.Voltage = 0.0;
                    toolTwinModel.Rx = 0.0;
                    toolTwinModel.Ry = 0.0;
                    toolTwinModel.Rz = 0.0;
                }
                return toolTwinModel;
            }
        }
    }
}