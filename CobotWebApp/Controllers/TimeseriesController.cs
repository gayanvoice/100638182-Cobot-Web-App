using CobotWebApp.Helper;
using CobotWebApp.Models;
using CobotWebApp.Models.View;
using CobotWebApp.Singleton;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Azure;
using Azure.DigitalTwins.Core;
using Azure.Identity;
using CobotWebApp.Hubs;
using CobotWebApp.Services;

namespace CobotWebApp.Controllers
{
    [Authorize]
    public class TimeseriesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBuildDependency _buildDependency;
        private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
        public TimeseriesController(ILogger<HomeController> logger,
            IBuildDependency buildDependency,
            CobotIotCommandFunctionService cobotIotCommandFunctionService)
        {
            _logger = logger;
            _buildDependency = buildDependency;
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
        }
        public IActionResult Index()
        {
            return Redirect("/Timeseries/Dashboard");
        }
        public IActionResult Dashboard()
        {
            TimeseriesViewModel.DashboardViewModel dashboardViewModel = new TimeseriesViewModel.DashboardViewModel();
            TimeseriesViewHelper.DashboardViewHelper dashboardViewHelper = new TimeseriesViewHelper.DashboardViewHelper();
            dashboardViewModel.BreadCrumbPartialViewModelList = dashboardViewHelper.GetBreadCrumbPartialViewModelListForDashboardView();
            return View(dashboardViewModel);
        }
        public IActionResult Cobot()
        {
            TimeseriesViewModel.CobotViewModel cobotViewModel = new TimeseriesViewModel.CobotViewModel();
            TimeseriesViewHelper.CobotViewHelper cobotViewHelper = new TimeseriesViewHelper.CobotViewHelper();
            cobotViewModel.BreadCrumbPartialViewModelList = cobotViewHelper.GetBreadCrumbPartialViewModelListForCobotView();
            return View(cobotViewModel);
        }
        public IActionResult ControlBox()
        {
            TimeseriesViewModel.ControlBoxViewModel controlBoxViewModel = new TimeseriesViewModel.ControlBoxViewModel();
            TimeseriesViewHelper.ControlBoxViewHelper controlBoxViewHelper = new TimeseriesViewHelper.ControlBoxViewHelper();
            controlBoxViewModel.BreadCrumbPartialViewModelList = controlBoxViewHelper.GetBreadCrumbPartialViewModelListForCobotView();
            return View(controlBoxViewModel);
        }
        public IActionResult Payload()
        {
            TimeseriesViewModel.PayloadViewModel payloadViewModel = new TimeseriesViewModel.PayloadViewModel();
            TimeseriesViewHelper.PayloadViewHelper payloadViewHelper = new TimeseriesViewHelper.PayloadViewHelper();
            payloadViewModel.BreadCrumbPartialViewModelList = payloadViewHelper.GetBreadCrumbPartialViewModelListForPayloadView();
            return View(payloadViewModel);
        }
        public IActionResult Base()
        {
            TimeseriesViewModel.BaseViewModel baseViewModel = new TimeseriesViewModel.BaseViewModel();
            TimeseriesViewHelper.BaseViewHelper baseViewHelper = new TimeseriesViewHelper.BaseViewHelper();
            baseViewModel.BreadCrumbPartialViewModelList = baseViewHelper.GetBreadCrumbPartialViewModelListForBaseView();
            return View(baseViewModel);
        }
        public IActionResult Shoulder()
        {
            TimeseriesViewModel.ShoulderViewModel shoulderViewModel = new TimeseriesViewModel.ShoulderViewModel();
            TimeseriesViewHelper.ShoulderViewHelper shoulderViewHelper = new TimeseriesViewHelper.ShoulderViewHelper();
            shoulderViewModel.BreadCrumbPartialViewModelList = shoulderViewHelper.GetBreadCrumbPartialViewModelListForShoulderView();
            return View(shoulderViewModel);
        }
        public IActionResult Elbow()
        {
            TimeseriesViewModel.ElbowViewModel elbowViewModel = new TimeseriesViewModel.ElbowViewModel();
            TimeseriesViewHelper.ElbowViewHelper elbowViewHelper = new TimeseriesViewHelper.ElbowViewHelper();
            elbowViewModel.BreadCrumbPartialViewModelList = elbowViewHelper.GetBreadCrumbPartialViewModelListForElbowView();
            return View(elbowViewModel);
        }
        public IActionResult Wrist1()
        {
            TimeseriesViewModel.Wrist1ViewModel wrist1ViewModel = new TimeseriesViewModel.Wrist1ViewModel();
            TimeseriesViewHelper.Wrist1ViewHelper wrist1ViewHelper = new TimeseriesViewHelper.Wrist1ViewHelper();
            wrist1ViewModel.BreadCrumbPartialViewModelList = wrist1ViewHelper.GetBreadCrumbPartialViewModelListForWrist1View();
            return View(wrist1ViewModel);
        }
        public IActionResult Wrist2()
        {
            TimeseriesViewModel.Wrist2ViewModel wrist2ViewModel = new TimeseriesViewModel.Wrist2ViewModel();
            TimeseriesViewHelper.Wrist2ViewHelper wrist2ViewHelper = new TimeseriesViewHelper.Wrist2ViewHelper();
            wrist2ViewModel.BreadCrumbPartialViewModelList = wrist2ViewHelper.GetBreadCrumbPartialViewModelListForWrist2View();
            return View(wrist2ViewModel);
        }
        public IActionResult Wrist3()
        {
            TimeseriesViewModel.Wrist3ViewModel wrist3ViewModel = new TimeseriesViewModel.Wrist3ViewModel();
            TimeseriesViewHelper.Wrist3ViewHelper wrist3ViewHelper = new TimeseriesViewHelper.Wrist3ViewHelper();
            wrist3ViewModel.BreadCrumbPartialViewModelList = wrist3ViewHelper.GetBreadCrumbPartialViewModelListForWrist3View();
            return View(wrist3ViewModel);
        }
        public IActionResult Tool()
        {
            TimeseriesViewModel.ToolViewModel toolViewModel = new TimeseriesViewModel.ToolViewModel();
            TimeseriesViewHelper.ToolViewHelper toolViewHelper = new TimeseriesViewHelper.ToolViewHelper();
            toolViewModel.BreadCrumbPartialViewModelList = toolViewHelper.GetBreadCrumbPartialViewModelListForToolView();
            return View(toolViewModel);
        }
    }
}