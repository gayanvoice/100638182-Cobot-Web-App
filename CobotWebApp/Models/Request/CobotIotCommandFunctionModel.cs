using Newtonsoft.Json.Linq;
using System.Net;

namespace CobotWebApp.Models.Request
{
    public class CobotIotCommandFunctionModel
    {
        public class RequestModel
        {
            public class EnableControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class DisableControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class PowerOffControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class PowerOnControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
        }
        public class ResponseModel
        {
            public class EnableControlCommandResponseModel
            {
                public string? Message { get; set; }
                public double Duration { get; set; }
                public CommandResponseModel? CommandResponse { get; set; }
                public CommandRequestModel? CommandRequest { get; set; }
                public class CommandRequestModel
                {
                    public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                }
                public class CommandResponseModel
                {
                    public double Result { get; set; }
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public string? Status { get; set; }
                        public string? LogText { get; set; }
                        public double Duration { get; set; }
                        public double ElapsedTime { get; set; }
                    }
                }
            }
            public class DisableControlCommandResponseModel
            {
                public string? Message { get; set; }
                public double Duration { get; set; }
                public CommandResponseModel? CommandResponse { get; set; }
                public CommandRequestModel? CommandRequest { get; set; }
                public class CommandRequestModel
                {
                    public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                }
                public class CommandResponseModel
                {
                    public double Result { get; set; }
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public string? Status { get; set; }
                        public string? LogText { get; set; }
                        public double Duration { get; set; }
                    }
                }
            }
            public class PowerOffControlCommandResponseModel
            {
                public string? Message { get; set; }
                public double Duration { get; set; }
                public CommandResponseModel? CommandResponse { get; set; }
                public CommandRequestModel? CommandRequest { get; set; }
                public class CommandRequestModel
                {
                    public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                }
                public class CommandResponseModel
                {
                    public double Result { get; set; }
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public string? Status { get; set; }
                        public string? LogText { get; set; }
                        public double Duration { get; set; }
                        public string? RobotMode { get; set; }
                        public RobotStatusModel? RobotStatus { get; set; }
                        public class RobotStatusModel
                        {
                            public bool PowerButtonPressed { get; set; }
                            public bool PowerOn { get; set; }
                            public bool ProgramRunning { get; set; }
                            public bool TeachButtonPressed { get; set; }
                        }
                    }
                }
            }
            public class PowerOnControlCommandResponseModel
            {
                public string? Message { get; set; }
                public double Duration { get; set; }
                public CommandResponseModel? CommandResponse { get; set; }
                public CommandRequestModel? CommandRequest { get; set; }
                public class CommandRequestModel
                {
                    public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                }
                public class CommandResponseModel
                {
                    public double Result { get; set; }
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public string? Status { get; set; }
                        public string? LogText { get; set; }
                        public double Duration { get; set; }
                        public string? RobotMode { get; set; }
                        public RobotStatusModel? RobotStatus { get; set; }
                        public class RobotStatusModel
                        {
                            public bool PowerButtonPressed { get; set; }
                            public bool PowerOn { get; set; }
                            public bool ProgramRunning { get; set; }
                            public bool TeachButtonPressed { get; set; }
                        }
                    }
                }
            }
        }
    }
}
