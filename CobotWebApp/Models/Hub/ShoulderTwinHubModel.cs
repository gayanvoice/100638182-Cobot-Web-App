﻿using Newtonsoft.Json;

namespace CobotWebApp.Models.Hub
{
    public class ShoulderTwinHubModel
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
        public class ShoulderTwinModel
        {
            public double Temperature { get; set; }
            public double Position { get; set; }
            public double Voltage { get; set; }
            public static ShoulderTwinModel GetShoulderTwinModel(ShoulderTwinHubModel? shoulderTwinHubModel)
            {
                ShoulderTwinModel shoulderTwinModel = new ShoulderTwinModel();
                if (shoulderTwinHubModel is not null &&
                    shoulderTwinHubModel.Value is not null)
                {
                    shoulderTwinModel.Temperature = shoulderTwinHubModel.Value.Temperature;
                    shoulderTwinModel.Position = shoulderTwinHubModel.Value.Position;
                    shoulderTwinModel.Voltage = shoulderTwinHubModel.Value.Voltage;
                }
                else
                {
                    shoulderTwinModel.Temperature = 0.0;
                    shoulderTwinModel.Position = 0.0;
                    shoulderTwinModel.Voltage = 0.0;
                }
                return shoulderTwinModel;
            }
        }
    }
}