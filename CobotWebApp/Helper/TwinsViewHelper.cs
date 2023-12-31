﻿using CobotWebApp.Models.Request;
using CobotWebApp.Models.View.Partial;
using CobotWebApp.Services;

namespace CobotWebApp.Helper
{
    public class TwinsViewHelper
    {
        public class DashboardViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForDashboardView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Twins Dashboard")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class StartIotControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public StartIotControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForStartIotControlCommandResponseView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Twins Dashboard", aspController:"Twins", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Start IOT")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<List<CobotIotCommandFunctionModel.ResponseModel.StartIotControlCommandResponseModel>?> PostStartIotControlCommandResponseModelListAsync(
                bool cobotSwitchCheckDefault,
                bool controlBoxSwitchCheckDefault,
                bool payloadSwitchCheckDefault,
                bool baseSwitchCheckDefault,
                bool elbowSwitchCheckDefault,
                bool shoulderSwitchCheckDefault,
                bool wrist1SwitchCheckDefault,
                bool wrist2SwitchCheckDefault,
                bool wrist3SwitchCheckDefault,
                bool toolSwitchCheckDefault)
            {
                List<CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel> startIotControlCommandRequestModelList = new List<CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel>();
                if (cobotSwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Cobot", responseTimeout: 20));
                }
                if (controlBoxSwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "ControlBox", responseTimeout: 20));
                }
                if (payloadSwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Payload", responseTimeout: 20));
                }
                if (baseSwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Base", responseTimeout: 20));
                }
                if (elbowSwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Elbow", responseTimeout: 20));
                }
                if (shoulderSwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Shoulder", responseTimeout: 20));
                }
                if (wrist1SwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Wrist1", responseTimeout: 20));
                }
                if (wrist2SwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Wrist2", responseTimeout: 20));
                }
                if (wrist3SwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Wrist3", responseTimeout: 20));
                }
                if (toolSwitchCheckDefault)
                {
                    startIotControlCommandRequestModelList.Add(new CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel(deviceId: "Tool", responseTimeout: 20));
                }
                List<CobotIotCommandFunctionModel.ResponseModel.StartIotControlCommandResponseModel> startIotControlCommandResponseModelList = new List<CobotIotCommandFunctionModel.ResponseModel.StartIotControlCommandResponseModel>();
                foreach (CobotIotCommandFunctionModel.RequestModel.StartIotControlCommandRequestModel startIotControlCommandRequestModel in startIotControlCommandRequestModelList)
                {
                    CobotIotCommandFunctionModel.ResponseModel.StartIotControlCommandResponseModel? startIotControlCommandResponseModel =
                        await _cobotIotCommandFunctionService.PostStartIotControlCommandResponseModelAsync(startIotControlCommandRequestModel);
                    if (startIotControlCommandResponseModel is not null)
                    {
                        startIotControlCommandResponseModelList.Add(startIotControlCommandResponseModel);
                    }

                }
                return startIotControlCommandResponseModelList;
            }
        }
        public class StopIotControlCommandResponseViewHelper
        {
            private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
            public StopIotControlCommandResponseViewHelper(CobotIotCommandFunctionService cobotIotCommandFunctionService) =>
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForStopIotControlCommandResponseView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Twins Dashboard", aspController:"Twins", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Stop IOT")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<List<CobotIotCommandFunctionModel.ResponseModel.StopIotControlCommandResponseModel>?> PostStopIotControlCommandResponseModelListAsync()
            {
                List<CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel> stopIotControlCommandRequestModelList =
                    new List<CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel> {
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Cobot", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "ControlBox", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Payload", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Base", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Elbow", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Shoulder", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Tool", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Wrist1", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Wrist2", responseTimeout: 20),
                        new CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel(deviceId: "Wrist3", responseTimeout: 20),
                    };
                List<CobotIotCommandFunctionModel.ResponseModel.StopIotControlCommandResponseModel> stopIotControlCommandResponseModelList = new List<CobotIotCommandFunctionModel.ResponseModel.StopIotControlCommandResponseModel>();
                foreach (CobotIotCommandFunctionModel.RequestModel.StopIotControlCommandRequestModel stopIotControlCommandRequestModel in stopIotControlCommandRequestModelList)
                {
                    CobotIotCommandFunctionModel.ResponseModel.StopIotControlCommandResponseModel? stopIotControlCommandResponseModel =
                        await _cobotIotCommandFunctionService.PostStopIotControlCommandResponseModelAsync(stopIotControlCommandRequestModel);
                    if (stopIotControlCommandResponseModel is not null)
                    {
                        stopIotControlCommandResponseModelList.Add(stopIotControlCommandResponseModel);
                    }
                }
                return stopIotControlCommandResponseModelList;
            }
        }
        public class TwinsTelemetryViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForTwinsTelemetryView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Twins Dashboard", aspController:"Twins", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Twins Telemetry")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class TwinsSimulationViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForTwinsSimulationView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Twins Dashboard", aspController:"Twins", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Twins Simulation")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class TwinOfTwinViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForTwinOfTwinView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Twins Dashboard", aspController:"Twins", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Twin Of Twin")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class TwinsStatusViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForTwinsStatusView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Twins Dashboard", aspController:"Twins", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Twins Status")
                };
                return breadCrumbPartialViewModelList;
            }
        }
    }
}