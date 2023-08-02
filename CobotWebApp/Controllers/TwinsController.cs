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
        public async Task<Response<BasicDigitalTwin>> PrimaryTwinAsync()
        {
            string? adtInstanceUrl = "https://100638182AzureDigitalTwins.api.uks.digitaltwins.azure.net";
            DefaultAzureCredential defaultAzureCredential = new DefaultAzureCredential(new DefaultAzureCredentialOptions { ExcludeEnvironmentCredential = true });
            DigitalTwinsClient digitalTwinsClient = new DigitalTwinsClient(new Uri(adtInstanceUrl), defaultAzureCredential);
            Response<BasicDigitalTwin> twinResponse = await digitalTwinsClient.GetDigitalTwinAsync<BasicDigitalTwin>("Cobot");
            BasicDigitalTwin  basicDigitalTwin = twinResponse.Value;
            Console.WriteLine($"Model id: {basicDigitalTwin.Metadata.ModelId}");
            foreach (string prop in basicDigitalTwin.Contents.Keys)
            {
                if (basicDigitalTwin.Contents.TryGetValue(prop, out object value))
                    Console.WriteLine($"Property '{prop}': {value}");
            }
            return twinResponse;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}