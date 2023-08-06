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
    public class TwinsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBuildDependency _buildDependency;
        private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
        public TwinsController(ILogger<HomeController> logger,
            IBuildDependency buildDependency,
            CobotIotCommandFunctionService cobotIotCommandFunctionService)
        {
            _logger = logger;
            _buildDependency = buildDependency;
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
        }
        public IActionResult Index()
        {
            return Redirect("/Twins/Dashboard");
        }
        public IActionResult Dashboard()
        {
            TwinsViewModel.DashboardViewModel dashboardViewModel = new TwinsViewModel.DashboardViewModel();
            TwinsViewHelper.DashboardViewHelper dashboardViewHelper = new TwinsViewHelper.DashboardViewHelper();
            dashboardViewModel.BreadCrumbPartialViewModelList = dashboardViewHelper.GetBreadCrumbPartialViewModelListForDashboardView();
            return View(dashboardViewModel);
        }
        public async Task<IActionResult> StartIotControlCommandResponseAsync(
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
            TwinsViewModel.StartIotControlCommandResponseViewModel startIotControlCommandResponseViewModel = new TwinsViewModel.StartIotControlCommandResponseViewModel();
            TwinsViewHelper.StartIotControlCommandResponseViewHelper startIotControlCommandResponseViewHelper = new TwinsViewHelper.StartIotControlCommandResponseViewHelper(
                cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            startIotControlCommandResponseViewModel.BreadCrumbPartialViewModelList = startIotControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForStartIotControlCommandResponseView();
            startIotControlCommandResponseViewModel.StartIotControlCommandResponseModelList = await startIotControlCommandResponseViewHelper.PostStartIotControlCommandResponseModelListAsync(
                cobotSwitchCheckDefault: cobotSwitchCheckDefault,
                controlBoxSwitchCheckDefault: controlBoxSwitchCheckDefault,
                payloadSwitchCheckDefault: payloadSwitchCheckDefault,
                baseSwitchCheckDefault: baseSwitchCheckDefault,
                elbowSwitchCheckDefault: elbowSwitchCheckDefault,
                shoulderSwitchCheckDefault: shoulderSwitchCheckDefault,
                wrist1SwitchCheckDefault: wrist1SwitchCheckDefault,
                wrist2SwitchCheckDefault: wrist2SwitchCheckDefault,
                wrist3SwitchCheckDefault: wrist3SwitchCheckDefault,
                toolSwitchCheckDefault: toolSwitchCheckDefault);
            return View(startIotControlCommandResponseViewModel);
        }
        public async Task<IActionResult> StopIotControlCommandResponseAsync()
        {
            TwinsViewModel.StopIotControlCommandResponseViewModel stopIotControlCommandResponseViewModel = new TwinsViewModel.StopIotControlCommandResponseViewModel();
            TwinsViewHelper.StopIotControlCommandResponseViewHelper stopIotControlCommandResponseViewHelper = new TwinsViewHelper.StopIotControlCommandResponseViewHelper(
                cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            stopIotControlCommandResponseViewModel.BreadCrumbPartialViewModelList = stopIotControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForStopIotControlCommandResponseView();
            stopIotControlCommandResponseViewModel.StopIotControlCommandResponseModelList = await stopIotControlCommandResponseViewHelper.PostStopIotControlCommandResponseModelListAsync();
            return View(stopIotControlCommandResponseViewModel);
        }
        public IActionResult TwinsTelemetryAsync()
        {
            TwinsViewModel.TwinsTelemetryViewModel twinsTelemetryCommandResponseViewModel = new TwinsViewModel.TwinsTelemetryViewModel();
            TwinsViewHelper.TwinsTelemetryViewHelper twinsTelemetryCommandResponseViewHelper = new TwinsViewHelper.TwinsTelemetryViewHelper();
            twinsTelemetryCommandResponseViewModel.BreadCrumbPartialViewModelList = twinsTelemetryCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForTwinsTelemetryView();
            return View(twinsTelemetryCommandResponseViewModel);
        }
        public IActionResult TwinsSimulationAsync()
        {
            TwinsViewModel.TwinsSimulationViewModel twinsSimulationCommandResponseViewModel = new TwinsViewModel.TwinsSimulationViewModel();
            TwinsViewHelper.TwinsSimulationViewHelper twinsSimulationCommandResponseViewHelper = new TwinsViewHelper.TwinsSimulationViewHelper();
            twinsSimulationCommandResponseViewModel.BreadCrumbPartialViewModelList = twinsSimulationCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForTwinsSimulationView();
            return View(twinsSimulationCommandResponseViewModel);
        }
        public IActionResult TwinOfTwin()
        {
            TwinsViewModel.TwinOfTwinViewModel twinOfTwinViewModel = new TwinsViewModel.TwinOfTwinViewModel();
            TwinsViewHelper.TwinOfTwinViewHelper twinOfTwinCommandResponseViewHelper = new TwinsViewHelper.TwinOfTwinViewHelper();
            twinOfTwinViewModel.BreadCrumbPartialViewModelList = twinOfTwinCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForTwinOfTwinView();
            return View(twinOfTwinViewModel);
        }
        public IActionResult TwinsStatus()
        {
            TwinsViewModel.TwinsStatusViewModel twinsStatusViewModel = new TwinsViewModel.TwinsStatusViewModel();
            TwinsViewHelper.TwinsStatusViewHelper twinOfTwinCommandResponseViewHelper = new TwinsViewHelper.TwinsStatusViewHelper();
            twinsStatusViewModel.BreadCrumbPartialViewModelList = twinOfTwinCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForTwinsStatusView();
            return View(twinsStatusViewModel);
        }
    }
}