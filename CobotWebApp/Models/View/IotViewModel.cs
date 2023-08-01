using CobotWebApp.Models.Request;
using CobotWebApp.Models.View.Partial;

namespace CobotWebApp.Models.View
{
    public class IotViewModel
    {
        public class DashboardViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
        }
        public class EnableControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.EnableControlCommandResponseModel? EnableControlCommandResponseModel { get; set; }
        }
        public class DisableControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.DisableControlCommandResponseModel? DisableControlCommandResponseModel { get; set; }
        }
        public class PowerOnControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.PowerOnControlCommandResponseModel? PowerOnControlCommandResponseModel { get; set; }
        }
        public class PowerOffControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.PowerOffControlCommandResponseModel? PowerOffControlCommandResponseModel { get; set; }
        }
        public class StartFreeDriveControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.StartFreeDriveControlCommandResponseModel? StartFreeDriveControlCommandResponseModel { get; set; }
        }
        public class StopFreeDriveControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.StopFreeDriveControlCommandResponseModel? StopFreeDriveControlCommandResponseModel { get; set; }
        }
        public class PlayControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.PlayControlCommandResponseModel? PlayControlCommandResponseModel { get; set; }
        }
        public class PauseControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.PauseControlCommandResponseModel? PauseControlCommandResponseModel { get; set; }
        }
        public class CloseSafetyPopupControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.CloseSafetyPopupControlCommandResponseModel? CloseSafetyPopupControlCommandResponseModel { get; set; }
        }
        public class UnlockProtectiveStopControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.UnlockProtectiveStopControlCommandResponseModel? UnlockProtectiveStopControlCommandResponseModel { get; set; }
        }
        public class ClosePopupControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.ClosePopupControlCommandResponseModel? ClosePopupControlCommandResponseModel { get; set; }
        }
    }
}