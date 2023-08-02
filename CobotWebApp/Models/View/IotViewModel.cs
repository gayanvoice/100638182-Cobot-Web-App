using CobotWebApp.Models.Request;
using CobotWebApp.Models.View.Partial;
using System.ComponentModel.DataAnnotations;
using static CobotWebApp.Models.Request.CobotIotCommandFunctionModel.RequestModel;

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
        public class OpenPopupControlCommandRequestViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            [Display(Name = "Acceleration")]
            public string? PopupText { get; set; }
        }
        public class OpenPopupControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.OpenPopupControlCommandResponseModel? OpenPopupControlCommandResponseModel { get; set; }
        }
        public class MoveJControlCommandRequestViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            [Display(Name = "Acceleration")]
            public double Acceleration { get; set; }
            [Display(Name = "Velocity")]
            public double Velocity { get; set; }
            [Display(Name = "Blend Radius")]
            public double BlendRadius { get; set; }
            [Display(Name = "Time S")]
            public double TimeS { get; set; }
            [Display(Name = "Joint Position Array")]
            public string? JointPositionModelArray { get; set; }
        }
        public class MoveJControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.MoveJControlCommandResponseModel? MoveJControlCommandResponseModel { get; set; }
        }
        public class MoveLControlCommandRequestViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            [Display(Name = "Acceleration")]
            public double Acceleration { get; set; }
            [Display(Name = "Velocity")]
            public double Velocity { get; set; }
            [Display(Name = "Blend Radius")]
            public double BlendRadius { get; set; }
            [Display(Name = "Time S")]
            public double TimeS { get; set; }
            [Display(Name = "Tcp Position Array")]
            public string? TcpPositionModelArray { get; set; }
        }
        public class MoveLControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.MoveLControlCommandResponseModel? MoveLControlCommandResponseModel { get; set; }
        }
        public class MovePControlCommandRequestViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            [Display(Name = "Acceleration")]
            public double Acceleration { get; set; }
            [Display(Name = "Velocity")]
            public double Velocity { get; set; }
            [Display(Name = "Blend Radius")]
            public double BlendRadius { get; set; }
            [Display(Name = "Tcp Position Array")]
            public string? TcpPositionModelArray { get; set; }
        }
        public class MovePControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public CobotIotCommandFunctionModel.ResponseModel.MovePControlCommandResponseModel? MovePControlCommandResponseModel { get; set; }
        }
    }
}