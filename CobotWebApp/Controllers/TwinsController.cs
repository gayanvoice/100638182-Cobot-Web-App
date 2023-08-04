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
        public async Task<IActionResult> StartIotControlCommandResponseAsync()
        {
            TwinsViewModel.StartIotControlCommandResponseViewModel startIotControlCommandResponseViewModel = new TwinsViewModel.StartIotControlCommandResponseViewModel();
            TwinsViewHelper.StartIotControlCommandResponseViewHelper startIotControlCommandResponseViewHelper = new TwinsViewHelper.StartIotControlCommandResponseViewHelper(
                cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            startIotControlCommandResponseViewModel.BreadCrumbPartialViewModelList = startIotControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForDashboardView();
            startIotControlCommandResponseViewModel.StartIotControlCommandResponseModelList = await startIotControlCommandResponseViewHelper.PostStartIotControlCommandResponseModelListAsync();
            return View(startIotControlCommandResponseViewModel);
        }
        public async Task<IActionResult> StopIotControlCommandResponseAsync()
        {
            TwinsViewModel.StopIotControlCommandResponseViewModel stopIotControlCommandResponseViewModel = new TwinsViewModel.StopIotControlCommandResponseViewModel();
            TwinsViewHelper.StopIotControlCommandResponseViewHelper stopIotControlCommandResponseViewHelper = new TwinsViewHelper.StopIotControlCommandResponseViewHelper(
                cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            stopIotControlCommandResponseViewModel.BreadCrumbPartialViewModelList = stopIotControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForDashboardView();
            stopIotControlCommandResponseViewModel.StopIotControlCommandResponseModelList = await stopIotControlCommandResponseViewHelper.PostStopIotControlCommandResponseModelListAsync();
            return View(stopIotControlCommandResponseViewModel);
        }
        public IActionResult TwinsTelemetryAsync()
        {
            TwinsViewModel.TwinsTelemetryViewModel twinsTelemetryCommandResponseViewModel = new TwinsViewModel.TwinsTelemetryViewModel();
            TwinsViewHelper.TwinsTelemetryCommandResponseViewHelper twinsTelemetryCommandResponseViewHelper = new TwinsViewHelper.TwinsTelemetryCommandResponseViewHelper();
            twinsTelemetryCommandResponseViewModel.BreadCrumbPartialViewModelList = twinsTelemetryCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForDashboardView();
            return View(twinsTelemetryCommandResponseViewModel);
        }
        public IActionResult TwinsSimulationAsync()
        {
            TwinsViewModel.TwinsSimulationViewModel twinsSimulationCommandResponseViewModel = new TwinsViewModel.TwinsSimulationViewModel();
            TwinsViewHelper.TwinsSimulationCommandResponseViewHelper twinsSimulationCommandResponseViewHelper = new TwinsViewHelper.TwinsSimulationCommandResponseViewHelper();
            twinsSimulationCommandResponseViewModel.BreadCrumbPartialViewModelList = twinsSimulationCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForDashboardView();
            return View(twinsSimulationCommandResponseViewModel);
        }
        public IActionResult TwinOfTwin()
        {
            TwinsViewModel.TwinOfTwinViewModel twinOfTwinViewModel = new TwinsViewModel.TwinOfTwinViewModel();
            TwinsViewHelper.TwinOfTwinCommandResponseViewHelper twinOfTwinCommandResponseViewHelper = new TwinsViewHelper.TwinOfTwinCommandResponseViewHelper();
            twinOfTwinViewModel.BreadCrumbPartialViewModelList = twinOfTwinCommandResponseViewHelper.GetBreadCrumbPartialViewModelListForDashboardView();
            return View(twinOfTwinViewModel);
        }
    }
}