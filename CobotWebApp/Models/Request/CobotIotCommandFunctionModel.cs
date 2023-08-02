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
            public class StartFreeDriveControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class StopFreeDriveControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class PlayControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class PauseControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class CloseSafetyPopupControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class UnlockProtectiveStopControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class ClosePopupControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; }
            }
            public class OpenPopupControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; } = 20.0;
                public PayloadModel? Payload { get; set; }
                public class PayloadModel
                {
                    public string? PopupText { get; set; }
                }
            }
            public class MoveJControlCommandRequestModel
            {
                 public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public double Acceleration { get; set; }
                        public double Velocity { get; set; }
                        public double TimeS { get; set; }
                        public double BlendRadius { get; set; }
                        public List<JointPositionModelArrayItem>? JointPositionModelArray { get; set; }
                        public class JointPositionModelArrayItem
                        {
                            public JointPositionModel? JointPositionModel { get; set; }
                        }
                        public class JointPositionModel
                        {
                            public double Base { get; set; }
                            public double Shoulder { get; set; }
                            public double Elbow { get; set; }
                            public double Wrist1 { get; set; }
                            public double Wrist2 { get; set; }
                            public double Wrist3 { get; set; }
                        }
                    }
            }
            public class MoveLControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; } = 20.0;
                public PayloadModel? Payload { get; set; }
                public class PayloadModel
                {
                    public double Acceleration { get; set; }
                    public double Velocity { get; set; }
                    public double TimeS { get; set; }
                    public double BlendRadius { get; set; }
                    public List<TcpPositionModelArrayItem>? TcpPositionModelArray { get; set; }
                    public class TcpPositionModelArrayItem
                    {
                        public TcpPositionModel? TcpPositionModel { get; set; }
                    }
                    public class TcpPositionModel
                    {
                        public double X { get; set; }
                        public double Y { get; set; }
                        public double Z { get; set; }
                        public double Rx { get; set; }
                        public double Ry { get; set; }
                        public double Rz { get; set; }
                    }
                }
            }
            public class MovePControlCommandRequestModel
            {
                public string? DeviceId { get; set; }
                public double ResponseTimeout { get; set; } = 20.0;
                public PayloadModel? Payload { get; set; }
                public class PayloadModel
                {
                    public double Acceleration { get; set; }
                    public double Velocity { get; set; }
                    public double BlendRadius { get; set; }
                    public List<TcpPositionModelArrayItem>? TcpPositionModelArray { get; set; }
                    public class TcpPositionModelArrayItem
                    {
                        public TcpPositionModel? TcpPositionModel { get; set; }
                    }
                    public class TcpPositionModel
                    {
                        public double X { get; set; }
                        public double Y { get; set; }
                        public double Z { get; set; }
                        public double Rx { get; set; }
                        public double Ry { get; set; }
                        public double Rz { get; set; }
                    }
                }
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
            public class StartFreeDriveControlCommandResponseModel
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
                        public RobotSafetyStatusModel? RobotSafetyStatus { get; set; }
                        public class RobotStatusModel
                        {
                            public bool PowerButtonPressed { get; set; }
                            public bool PowerOn { get; set; }
                            public bool ProgramRunning { get; set; }
                            public bool TeachButtonPressed { get; set; }
                        }
                        public class RobotSafetyStatusModel
                        {
                            public bool EmergencyStopped { get; set; }
                            public bool Fault { get; set; }
                            public bool NormalMode { get; set; }
                            public bool ProtectiveStopped { get; set; }
                            public bool RecoveryMode { get; set; }
                            public bool ReducedMode { get; set; }
                            public bool RobotEmergencyStopped { get; set; }
                            public bool SafeguardStopped { get; set; }
                            public bool StoppedDueToSafety { get; set; }
                            public bool SystemEmergencyStopped { get; set; }
                            public bool Violation { get; set; }
                        }
                    }
                }
            }
            public class StopFreeDriveControlCommandResponseModel
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
                        public RobotSafetyStatusModel? RobotSafetyStatus { get; set; }
                        public class RobotStatusModel
                        {
                            public bool PowerButtonPressed { get; set; }
                            public bool PowerOn { get; set; }
                            public bool ProgramRunning { get; set; }
                            public bool TeachButtonPressed { get; set; }
                        }
                        public class RobotSafetyStatusModel
                        {
                            public bool EmergencyStopped { get; set; }
                            public bool Fault { get; set; }
                            public bool NormalMode { get; set; }
                            public bool ProtectiveStopped { get; set; }
                            public bool RecoveryMode { get; set; }
                            public bool ReducedMode { get; set; }
                            public bool RobotEmergencyStopped { get; set; }
                            public bool SafeguardStopped { get; set; }
                            public bool StoppedDueToSafety { get; set; }
                            public bool SystemEmergencyStopped { get; set; }
                            public bool Violation { get; set; }
                        }
                    }
                }
            }
            public class PlayControlCommandResponseModel
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
            public class PauseControlCommandResponseModel
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
            public class CloseSafetyPopupControlCommandResponseModel
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
                        public RobotSafetyStatusModel? RobotSafetyStatus { get; set; }
                        public class RobotStatusModel
                        {
                            public bool PowerButtonPressed { get; set; }
                            public bool PowerOn { get; set; }
                            public bool ProgramRunning { get; set; }
                            public bool TeachButtonPressed { get; set; }
                        }
                        public class RobotSafetyStatusModel
                        {
                            public bool EmergencyStopped { get; set; }
                            public bool Fault { get; set; }
                            public bool NormalMode { get; set; }
                            public bool ProtectiveStopped { get; set; }
                            public bool RecoveryMode { get; set; }
                            public bool ReducedMode { get; set; }
                            public bool RobotEmergencyStopped { get; set; }
                            public bool SafeguardStopped { get; set; }
                            public bool StoppedDueToSafety { get; set; }
                            public bool SystemEmergencyStopped { get; set; }
                            public bool Violation { get; set; }
                        }
                    }
                }
            }
            public class UnlockProtectiveStopControlCommandResponseModel
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
                        public RobotSafetyStatusModel? RobotSafetyStatus { get; set; }
                        public class RobotStatusModel
                        {
                            public bool PowerButtonPressed { get; set; }
                            public bool PowerOn { get; set; }
                            public bool ProgramRunning { get; set; }
                            public bool TeachButtonPressed { get; set; }
                        }
                        public class RobotSafetyStatusModel
                        {
                            public bool EmergencyStopped { get; set; }
                            public bool Fault { get; set; }
                            public bool NormalMode { get; set; }
                            public bool ProtectiveStopped { get; set; }
                            public bool RecoveryMode { get; set; }
                            public bool ReducedMode { get; set; }
                            public bool RobotEmergencyStopped { get; set; }
                            public bool SafeguardStopped { get; set; }
                            public bool StoppedDueToSafety { get; set; }
                            public bool SystemEmergencyStopped { get; set; }
                            public bool Violation { get; set; }
                        }
                    }
                }
            }
            public class ClosePopupControlCommandResponseModel
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
            public class OpenPopupControlCommandResponseModel
            {
                public string? Message { get; set; }
                public double Duration { get; set; }
                public CommandResponseModel? CommandResponse { get; set; }
                public CommandRequestModel? CommandRequest { get; set; }
                public class CommandRequestModel
                {
                    public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public string? PopupText { get; set; }
                    }
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
            public class MoveJControlCommandResponseModel
            {
                public string? Message { get; set; }
                public double Duration { get; set; }
                public CommandResponseModel? CommandResponse { get; set; }
                public CommandRequestModel? CommandRequest { get; set; }
                public class CommandRequestModel
                {
                    public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public double Acceleration { get; set; }
                        public double Velocity { get; set; }
                        public double TimeS { get; set; }
                        public double BlendRadius { get; set; }
                        public List<JointPositionModelArrayItem>? JointPositionModelArray { get; set; }
                        public class JointPositionModelArrayItem
                        {
                            public JointPositionModel? JointPositionModel { get; set; }
                        }
                        public class JointPositionModel
                        {
                            public double Base { get; set; }
                            public double Shoulder { get; set; }
                            public double Elbow { get; set; }
                            public double Wrist1 { get; set; }
                            public double Wrist2 { get; set; }
                            public double Wrist3 { get; set; }
                        }
                    }
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
            public class MoveLControlCommandResponseModel
            {
                public string? Message { get; set; }
                public double Duration { get; set; }
                public CommandResponseModel? CommandResponse { get; set; }
                public CommandRequestModel? CommandRequest { get; set; }
                public class CommandRequestModel
                {
                    public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public double Acceleration { get; set; }
                        public double Velocity { get; set; }
                        public double TimeS { get; set; }
                        public double BlendRadius { get; set; }
                        public List<TcpPositionModelArrayItem>? TcpPositionModelArray { get; set; }
                        public class TcpPositionModelArrayItem
                        {
                            public TcpPositionModel? TcpPositionModel { get; set; }
                        }
                        public class TcpPositionModel
                        {
                            public double X { get; set; }
                            public double Y { get; set; }
                            public double Z { get; set; }
                            public double Rx { get; set; }
                            public double Ry { get; set; }
                            public double Rz { get; set; }
                        }
                    }
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
            public class MovePControlCommandResponseModel
            {
                public string? Message { get; set; }
                public double Duration { get; set; }
                public CommandResponseModel? CommandResponse { get; set; }
                public CommandRequestModel? CommandRequest { get; set; }
                public class CommandRequestModel
                {
                    public string? DeviceId { get; set; }
                    public double ResponseTimeout { get; set; } = 20.0;
                    public PayloadModel? Payload { get; set; }
                    public class PayloadModel
                    {
                        public double Acceleration { get; set; }
                        public double Velocity { get; set; }
                        public double BlendRadius { get; set; }
                        public List<TcpPositionModelArrayItem>? TcpPositionModelArray { get; set; }
                        public class TcpPositionModelArrayItem
                        {
                            public TcpPositionModel? TcpPositionModel { get; set; }
                        }
                        public class TcpPositionModel
                        {
                            public double X { get; set; }
                            public double Y { get; set; }
                            public double Z { get; set; }
                            public double Rx { get; set; }
                            public double Ry { get; set; }
                            public double Rz { get; set; }
                        }
                    }
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
        }
    }
}