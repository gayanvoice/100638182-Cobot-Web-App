using CobotWebApp.Helper;
using CobotWebApp.Models;
using CobotWebApp.Models.Request;
using CobotWebApp.Models.View;
using CobotWebApp.Services;
using CobotWebApp.Singleton;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CobotWebApp.Controllers
{
    [Authorize]
    public class IotController : Controller
    {
        private readonly ILogger<IotController> _logger;
        private readonly IBuildDependency _buildDependency;
        private readonly CobotIotCommandFunctionService _cobotIotCommandFunctionService;
        public IotController(ILogger<IotController> logger,
            IBuildDependency buildDependency,
            CobotIotCommandFunctionService cobotIotCommandFunctionService)
        {
            _logger = logger;
            _buildDependency = buildDependency;
            _cobotIotCommandFunctionService = cobotIotCommandFunctionService;
        }
        public IActionResult Index()
        {
            return Redirect("Iot/Dashboard");
        }
        public IActionResult Dashboard()
        {
            IotViewHelper.DashboardViewHelper dashboardViewHelper = new IotViewHelper.DashboardViewHelper();
            IotViewModel.DashboardViewModel dashboardViewModel = new IotViewModel.DashboardViewModel();
            dashboardViewModel.BreadCrumbPartialViewModelList = dashboardViewHelper.GetBreadCrumbPartialViewModelList();
            return View(dashboardViewModel);
        }
        public async Task<IActionResult> EnableControlCommandResponseAsync()
        {
            IotViewHelper.EnableControlCommandResponseViewHelper enableControlCommandResponseViewHelper = new IotViewHelper
                .EnableControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.EnableControlCommandResponseViewModel enableControlCommandResponseViewModel = new IotViewModel.EnableControlCommandResponseViewModel();
            enableControlCommandResponseViewModel.BreadCrumbPartialViewModelList = enableControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            enableControlCommandResponseViewModel.EnableControlCommandResponseModel = await enableControlCommandResponseViewHelper.PostEnableControlCommandResponseModelAsync();
            return View(enableControlCommandResponseViewModel);
        }
        public async Task<IActionResult> DisableControlCommandResponseAsync()
        {
            IotViewHelper.DisableControlCommandResponseViewHelper disableControlCommandResponseViewHelper = new IotViewHelper
                .DisableControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.DisableControlCommandResponseViewModel disableControlCommandResponseViewModel = new IotViewModel.DisableControlCommandResponseViewModel();
            disableControlCommandResponseViewModel.BreadCrumbPartialViewModelList = disableControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            disableControlCommandResponseViewModel.DisableControlCommandResponseModel = await disableControlCommandResponseViewHelper.PostDisableControlCommandResponseModelAsync();
            return View(disableControlCommandResponseViewModel);
        }
        public async Task<IActionResult> PowerOnControlCommandResponseAsync()
        {
            IotViewHelper.PowerOnControlCommandResponseViewHelper powerOnControlCommandResponseViewHelper = new IotViewHelper
                .PowerOnControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.PowerOnControlCommandResponseViewModel powerOnControlCommandResponseViewModel = new IotViewModel.PowerOnControlCommandResponseViewModel();
            powerOnControlCommandResponseViewModel.BreadCrumbPartialViewModelList = powerOnControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            powerOnControlCommandResponseViewModel.PowerOnControlCommandResponseModel = await powerOnControlCommandResponseViewHelper.PostPowerOnControlCommandResponseModelAsync();
            return View(powerOnControlCommandResponseViewModel);
        }
        public async Task<IActionResult> PowerOffControlCommandResponseAsync()
        {
            IotViewHelper.PowerOffControlCommandResponseViewHelper powerOffControlCommandResponseViewHelper = new IotViewHelper
                .PowerOffControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.PowerOffControlCommandResponseViewModel powerOffControlCommandResponseViewModel = new IotViewModel.PowerOffControlCommandResponseViewModel();
            powerOffControlCommandResponseViewModel.BreadCrumbPartialViewModelList = powerOffControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            powerOffControlCommandResponseViewModel.PowerOffControlCommandResponseModel = await powerOffControlCommandResponseViewHelper.PostPowerOffControlCommandResponseModelAsync();
            return View(powerOffControlCommandResponseViewModel);
        }
    }
}