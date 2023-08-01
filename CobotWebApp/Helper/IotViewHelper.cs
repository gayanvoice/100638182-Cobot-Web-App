using CobotWebApp.Models.Request;
using CobotWebApp.Models.View;
using CobotWebApp.Models.View.Partial;
using CobotWebApp.Services;
using static CobotWebApp.Models.Request.CobotAdtInitializeFunctionModel.RequestModel;
using static CobotWebApp.Models.View.AdtViewModel.CreateAdtModelViewModel;
using static CobotWebApp.Models.View.AdtViewModel.CreateAdtRelationshipViewModel;
using static CobotWebApp.Models.View.AdtViewModel.DeleteAdtModelViewModel;
using static CobotWebApp.Models.View.AdtViewModel.DeleteAdtRelationshipViewModel;
using static CobotWebApp.Models.View.AdtViewModel.UploadDtdlModelViewModel;

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
    }
}