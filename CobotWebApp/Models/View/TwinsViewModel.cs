using CobotWebApp.Models.Request;
using CobotWebApp.Models.View.Partial;

namespace CobotWebApp.Models.View
{
    public class TwinsViewModel
    {
        public class DashboardViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
        }
        public class StartIotControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public List<CobotIotCommandFunctionModel.ResponseModel.StartIotControlCommandResponseModel>? StartIotControlCommandResponseModelList { get; set; }
        }
        public class StopIotControlCommandResponseViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public List<CobotIotCommandFunctionModel.ResponseModel.StopIotControlCommandResponseModel>? StopIotControlCommandResponseModelList { get; set; }
        }
        public class TwinsTelemetryViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
        }
        public class TwinsSimulationViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
        }
    }
}