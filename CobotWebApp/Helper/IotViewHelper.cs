using CobotWebApp.Models.Request;
using CobotWebApp.Models.View;
using CobotWebApp.Models.View.Partial;
using CobotWebApp.Services;

namespace CobotWebApp.Helper
{
    public class IotViewHelper
    {
        public class DashboardViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Iot Dashboard")
                };
                return breadCrumbPartialViewModelList;
            } 
        }
        public class EnableControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public EnableControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Enable Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.EnableControlCommandResponseModel?> PostEnableControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.EnableControlCommandRequestModel enableControlCommandRequestModel = new CobotIotCommandFunctionModel.RequestModel.EnableControlCommandRequestModel();
                enableControlCommandRequestModel.DeviceId = "Cobot";
                enableControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.EnableControlCommandResponseModel? enableControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostEnableControlCommandResponseModelAsync(enableControlCommandRequestModel: enableControlCommandRequestModel);
                return enableControlCommandResponseModel;
            }
        }
        public class DisableControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public DisableControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Disable Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.DisableControlCommandResponseModel?> PostDisableControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.DisableControlCommandRequestModel disableControlCommandRequestModel = 
                    new CobotIotCommandFunctionModel.RequestModel.DisableControlCommandRequestModel();
                disableControlCommandRequestModel.DeviceId = "Cobot";
                disableControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.DisableControlCommandResponseModel? disableControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostDisableControlCommandResponseModelAsync(disableControlCommandRequestModel: disableControlCommandRequestModel);
                return disableControlCommandResponseModel;
            }
        }
        public class PowerOffControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public PowerOffControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Power Off Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.PowerOffControlCommandResponseModel?> PostPowerOffControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.PowerOffControlCommandRequestModel powerOffControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.PowerOffControlCommandRequestModel();
                powerOffControlCommandRequestModel.DeviceId = "Cobot";
                powerOffControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.PowerOffControlCommandResponseModel? powerOffControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostPowerOffControlCommandResponseModelAsync(powerOffControlCommandRequestModel: powerOffControlCommandRequestModel);
                return powerOffControlCommandResponseModel;
            }
        }
        public class PowerOnControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public PowerOnControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Power On Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.PowerOnControlCommandResponseModel?> PostPowerOnControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.PowerOnControlCommandRequestModel powerOnControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.PowerOnControlCommandRequestModel();
                powerOnControlCommandRequestModel.DeviceId = "Cobot";
                powerOnControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.PowerOnControlCommandResponseModel? powerOnControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostPowerOnControlCommandResponseModelAsync(powerOnControlCommandRequestModel: powerOnControlCommandRequestModel);
                return powerOnControlCommandResponseModel;
            }
        }
        public class StartFreeDriveControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public StartFreeDriveControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Start Free Drive Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.StartFreeDriveControlCommandResponseModel?> PostStartFreeDriveControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.StartFreeDriveControlCommandRequestModel startFreeDriveControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.StartFreeDriveControlCommandRequestModel();
                startFreeDriveControlCommandRequestModel.DeviceId = "Cobot";
                startFreeDriveControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.StartFreeDriveControlCommandResponseModel? startFreeDriveControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostStartFreeDriveControlCommandResponseModelAsync(startFreeDriveControlCommandRequestModel: startFreeDriveControlCommandRequestModel);
                return startFreeDriveControlCommandResponseModel;
            }
        }
        public class StopFreeDriveControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public StopFreeDriveControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Stop Free Drive Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.StopFreeDriveControlCommandResponseModel?> PostStopFreeDriveControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.StopFreeDriveControlCommandRequestModel stopFreeDriveControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.StopFreeDriveControlCommandRequestModel();
                stopFreeDriveControlCommandRequestModel.DeviceId = "Cobot";
                stopFreeDriveControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.StopFreeDriveControlCommandResponseModel? stopFreeDriveControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostStopFreeDriveControlCommandResponseModelAsync(stopFreeDriveControlCommandRequestModel: stopFreeDriveControlCommandRequestModel);
                return stopFreeDriveControlCommandResponseModel;
            }
        }
        public class PlayControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public PlayControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Play Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.PlayControlCommandResponseModel?> PostPlayControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.PlayControlCommandRequestModel playControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.PlayControlCommandRequestModel();
                playControlCommandRequestModel.DeviceId = "Cobot";
                playControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.PlayControlCommandResponseModel? playControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostPlayControlCommandResponseModelAsync(playControlCommandRequestModel: playControlCommandRequestModel);
                return playControlCommandResponseModel;
            }
        }
        public class PauseControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public PauseControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Pause Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.PauseControlCommandResponseModel?> PostPauseControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.PauseControlCommandRequestModel pauseControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.PauseControlCommandRequestModel();
                pauseControlCommandRequestModel.DeviceId = "Cobot";
                pauseControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.PauseControlCommandResponseModel? pauseControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostPauseControlCommandResponseModelAsync(pauseControlCommandRequestModel: pauseControlCommandRequestModel);
                return pauseControlCommandResponseModel;
            }
        }
        public class CloseSafetyPopupControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public CloseSafetyPopupControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Close Saety Popup Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.CloseSafetyPopupControlCommandResponseModel?> PostCloseSafetyPopupControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.CloseSafetyPopupControlCommandRequestModel closeSafetyPopupControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.CloseSafetyPopupControlCommandRequestModel();
                closeSafetyPopupControlCommandRequestModel.DeviceId = "Cobot";
                closeSafetyPopupControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.CloseSafetyPopupControlCommandResponseModel? closeSafetyPopupControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostCloseSafetyPopupControlCommandResponseModelAsync(closeSafetyPopupControlCommandRequestModel: closeSafetyPopupControlCommandRequestModel);
                return closeSafetyPopupControlCommandResponseModel;
            }
        }
        public class UnlockProtectiveStopControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public UnlockProtectiveStopControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Unlock Protective Stop Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.UnlockProtectiveStopControlCommandResponseModel?> PostUnlockProtectiveStopControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.UnlockProtectiveStopControlCommandRequestModel unlockProtectiveStopControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.UnlockProtectiveStopControlCommandRequestModel();
                unlockProtectiveStopControlCommandRequestModel.DeviceId = "Cobot";
                unlockProtectiveStopControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.UnlockProtectiveStopControlCommandResponseModel? unlockProtectiveStopControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostUnlockProtectiveStopControlCommandResponseModelAsync(unlockProtectiveStopControlCommandRequestModel: unlockProtectiveStopControlCommandRequestModel);
                return unlockProtectiveStopControlCommandResponseModel;
            }
        }
        public class ClosePopupControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public ClosePopupControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Close Popup Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.ClosePopupControlCommandResponseModel?> PostClosePopupControlCommandResponseModelAsync()
            {
                CobotIotCommandFunctionModel.RequestModel.ClosePopupControlCommandRequestModel closePopupControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.ClosePopupControlCommandRequestModel();
                closePopupControlCommandRequestModel.DeviceId = "Cobot";
                closePopupControlCommandRequestModel.ResponseTimeout = 20;
                CobotIotCommandFunctionModel.ResponseModel.ClosePopupControlCommandResponseModel? closePopupControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostClosePopupControlCommandResponseModelAsync(closePopupControlCommandRequestModel: closePopupControlCommandRequestModel);
                return closePopupControlCommandResponseModel;
            }
        }
        public class OpenPopupControlCommandRequestViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Open Popup Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class OpenPopupControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public OpenPopupControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Open Popup Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.OpenPopupControlCommandResponseModel?> PostOpenPopupControlCommandResponseModelAsync(
                IotViewModel.OpenPopupControlCommandRequestViewModel openPopupControlCommandRequestViewModel)
            {
                CobotIotCommandFunctionModel.RequestModel.OpenPopupControlCommandRequestModel openPopupControlCommandRequestModel =
                    new CobotIotCommandFunctionModel.RequestModel.OpenPopupControlCommandRequestModel();
                CobotIotCommandFunctionModel.RequestModel.OpenPopupControlCommandRequestModel.PayloadModel payloadModel = new CobotIotCommandFunctionModel.RequestModel.OpenPopupControlCommandRequestModel.PayloadModel();
                payloadModel.PopupText = openPopupControlCommandRequestViewModel.PopupText;
                openPopupControlCommandRequestModel.DeviceId = "Cobot";
                openPopupControlCommandRequestModel.ResponseTimeout = 20;
                openPopupControlCommandRequestModel.Payload = payloadModel;
                CobotIotCommandFunctionModel.ResponseModel.OpenPopupControlCommandResponseModel? closePopupControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostOpenPopupControlCommandResponseModelAsync(openPopupControlCommandRequestModel: openPopupControlCommandRequestModel);
                return closePopupControlCommandResponseModel;
            }
        }
        public class MoveJControlCommandRequestViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Move J Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class MoveJControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public MoveJControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Move J Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.MoveJControlCommandResponseModel?> PostMoveJControlCommandResponseModelAsync(
                IotViewModel.MoveJControlCommandRequestViewModel moveJControlCommandRequestViewModel)
            {
                
                CobotIotCommandFunctionModel.RequestModel.MoveJControlCommandRequestModel moveJControlCommandRequestModel = new CobotIotCommandFunctionModel
                    .RequestModel.MoveJControlCommandRequestModel();
                CobotIotCommandFunctionModel.RequestModel.MoveJControlCommandRequestModel.PayloadModel payloadModel = new CobotIotCommandFunctionModel
                    .RequestModel.MoveJControlCommandRequestModel.PayloadModel();
                if (moveJControlCommandRequestViewModel.JointPositionModelArray is not null)
                {
                    payloadModel.Acceleration = moveJControlCommandRequestViewModel.Acceleration;
                    payloadModel.Velocity = moveJControlCommandRequestViewModel.Velocity;
                    payloadModel.BlendRadius = moveJControlCommandRequestViewModel.BlendRadius;
                    payloadModel.TimeS = moveJControlCommandRequestViewModel.TimeS;
                    payloadModel.JointPositionModelArray = Newtonsoft.Json.JsonConvert
                        .DeserializeObject<List<CobotIotCommandFunctionModel.RequestModel.MoveJControlCommandRequestModel
                        .PayloadModel.JointPositionModelArrayItem>>(moveJControlCommandRequestViewModel.JointPositionModelArray);
                }
                moveJControlCommandRequestModel.DeviceId = "Cobot";
                moveJControlCommandRequestModel.ResponseTimeout = 20;
                moveJControlCommandRequestModel.Payload = payloadModel;
                CobotIotCommandFunctionModel.ResponseModel.MoveJControlCommandResponseModel? moveJControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostMoveJControlCommandResponseModelAsync(moveJControlCommandRequestModel: moveJControlCommandRequestModel);
                return moveJControlCommandResponseModel;
            }
        }
        public class MoveLControlCommandRequestViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Move L Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class MoveLControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public MoveLControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Move L Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.MoveLControlCommandResponseModel?> PostMoveLControlCommandResponseModelAsync(
                IotViewModel.MoveLControlCommandRequestViewModel moveLControlCommandRequestViewModel)
            {

                CobotIotCommandFunctionModel.RequestModel.MoveLControlCommandRequestModel moveLControlCommandRequestModel = new CobotIotCommandFunctionModel.RequestModel.MoveLControlCommandRequestModel();
                CobotIotCommandFunctionModel.RequestModel.MoveLControlCommandRequestModel.PayloadModel payloadModel = new CobotIotCommandFunctionModel.RequestModel.MoveLControlCommandRequestModel.PayloadModel();
                if (moveLControlCommandRequestViewModel.TcpPositionModelArray is not null)
                {
                    payloadModel.Acceleration = moveLControlCommandRequestViewModel.Acceleration;
                    payloadModel.Velocity = moveLControlCommandRequestViewModel.Velocity;
                    payloadModel.BlendRadius = moveLControlCommandRequestViewModel.BlendRadius;
                    payloadModel.TimeS = moveLControlCommandRequestViewModel.TimeS;
                    payloadModel.TcpPositionModelArray = Newtonsoft.Json.JsonConvert
                        .DeserializeObject<List<CobotIotCommandFunctionModel.RequestModel.MoveLControlCommandRequestModel
                        .PayloadModel.TcpPositionModelArrayItem>>(moveLControlCommandRequestViewModel.TcpPositionModelArray);
                }
                moveLControlCommandRequestModel.DeviceId = "Cobot";
                moveLControlCommandRequestModel.ResponseTimeout = 20;
                moveLControlCommandRequestModel.Payload = payloadModel;
                CobotIotCommandFunctionModel.ResponseModel.MoveLControlCommandResponseModel? moveLControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostMoveLControlCommandResponseModelAsync(moveLControlCommandRequestModel: moveLControlCommandRequestModel);
                return moveLControlCommandResponseModel;
            }
        }
        public class MovePControlCommandRequestViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Move P Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class MovePControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public MovePControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Iot Dashboard", aspController:"Iot", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Move P Control Command")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<CobotIotCommandFunctionModel.ResponseModel.MovePControlCommandResponseModel?> PostMovePControlCommandResponseModelAsync(
                IotViewModel.MovePControlCommandRequestViewModel movePControlCommandRequestViewModel)
            {

                CobotIotCommandFunctionModel.RequestModel.MovePControlCommandRequestModel movePControlCommandRequestModel = new CobotIotCommandFunctionModel.RequestModel.MovePControlCommandRequestModel();
                CobotIotCommandFunctionModel.RequestModel.MovePControlCommandRequestModel.PayloadModel payloadModel = new CobotIotCommandFunctionModel.RequestModel.MovePControlCommandRequestModel.PayloadModel();
                if (movePControlCommandRequestViewModel.TcpPositionModelArray is not null)
                {
                    payloadModel.Acceleration = movePControlCommandRequestViewModel.Acceleration;
                    payloadModel.Velocity = movePControlCommandRequestViewModel.Velocity;
                    payloadModel.BlendRadius = movePControlCommandRequestViewModel.BlendRadius;
                    payloadModel.TcpPositionModelArray = Newtonsoft.Json.JsonConvert
                        .DeserializeObject<List<CobotIotCommandFunctionModel.RequestModel.MovePControlCommandRequestModel
                        .PayloadModel.TcpPositionModelArrayItem>>(movePControlCommandRequestViewModel.TcpPositionModelArray);
                }
                movePControlCommandRequestModel.DeviceId = "Cobot";
                movePControlCommandRequestModel.ResponseTimeout = 20;
                movePControlCommandRequestModel.Payload = payloadModel;
                CobotIotCommandFunctionModel.ResponseModel.MovePControlCommandResponseModel? movePControlCommandResponseModel = await _cobotIotCommandFunctionService
                    .PostMovePControlCommandResponseModelAsync(movePControlCommandRequestModel: movePControlCommandRequestModel);
                return movePControlCommandResponseModel;
            }
        }
    }
}