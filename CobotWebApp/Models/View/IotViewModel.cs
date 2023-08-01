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
    }
}