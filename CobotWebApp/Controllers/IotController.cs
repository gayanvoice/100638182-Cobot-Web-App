using CobotWebApp.Helper;
using CobotWebApp.Models;
using CobotWebApp.Models.Request;
using CobotWebApp.Models.View;
using CobotWebApp.Services;
using CobotWebApp.Singleton;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static CobotWebApp.Models.View.IotViewModel;

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
        public async Task<IActionResult> StartFreeDriveControlCommandResponseAsync()
        {
            IotViewHelper.StartFreeDriveControlCommandResponseViewHelper startFreeDriveControlCommandResponseViewHelper = new IotViewHelper
                .StartFreeDriveControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.StartFreeDriveControlCommandResponseViewModel startFreeDriveControlCommandResponseViewModel = new IotViewModel.StartFreeDriveControlCommandResponseViewModel();
            startFreeDriveControlCommandResponseViewModel.BreadCrumbPartialViewModelList = startFreeDriveControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            startFreeDriveControlCommandResponseViewModel.StartFreeDriveControlCommandResponseModel = await startFreeDriveControlCommandResponseViewHelper.PostStartFreeDriveControlCommandResponseModelAsync();
            return View(startFreeDriveControlCommandResponseViewModel);
        }
        public async Task<IActionResult> StopFreeDriveControlCommandResponseAsync()
        {
            IotViewHelper.StopFreeDriveControlCommandResponseViewHelper stopFreeDriveControlCommandResponseViewHelper = new IotViewHelper
                .StopFreeDriveControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.StopFreeDriveControlCommandResponseViewModel stopFreeDriveControlCommandResponseViewModel = new IotViewModel.StopFreeDriveControlCommandResponseViewModel();
            stopFreeDriveControlCommandResponseViewModel.BreadCrumbPartialViewModelList = stopFreeDriveControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            stopFreeDriveControlCommandResponseViewModel.StopFreeDriveControlCommandResponseModel = await stopFreeDriveControlCommandResponseViewHelper.PostStopFreeDriveControlCommandResponseModelAsync();
            return View(stopFreeDriveControlCommandResponseViewModel);
        }
        public async Task<IActionResult> PlayControlCommandResponseAsync()
        {
            IotViewHelper.PlayControlCommandResponseViewHelper playControlCommandResponseViewHelper = new IotViewHelper
                .PlayControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.PlayControlCommandResponseViewModel playControlCommandResponseViewModel = new IotViewModel.PlayControlCommandResponseViewModel();
            playControlCommandResponseViewModel.BreadCrumbPartialViewModelList = playControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            playControlCommandResponseViewModel.PlayControlCommandResponseModel = await playControlCommandResponseViewHelper.PostPlayControlCommandResponseModelAsync();
            return View(playControlCommandResponseViewModel);
        }
        public async Task<IActionResult> PauseControlCommandResponseAsync()
        {
            IotViewHelper.PauseControlCommandResponseViewHelper pauseControlCommandResponseViewHelper = new IotViewHelper
                .PauseControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.PauseControlCommandResponseViewModel pauseControlCommandResponseViewModel = new IotViewModel.PauseControlCommandResponseViewModel();
            pauseControlCommandResponseViewModel.BreadCrumbPartialViewModelList = pauseControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            pauseControlCommandResponseViewModel.PauseControlCommandResponseModel = await pauseControlCommandResponseViewHelper.PostPauseControlCommandResponseModelAsync();
            return View(pauseControlCommandResponseViewModel);
        }
        public async Task<IActionResult> CloseSafetyPopupControlCommandResponseAsync()
        {
            IotViewHelper.CloseSafetyPopupControlCommandResponseViewHelper closeSafetyPopupControlCommandResponseViewHelper = new IotViewHelper
                .CloseSafetyPopupControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.CloseSafetyPopupControlCommandResponseViewModel closeSafetyPopupControlCommandResponseViewModel = new IotViewModel.CloseSafetyPopupControlCommandResponseViewModel();
            closeSafetyPopupControlCommandResponseViewModel.BreadCrumbPartialViewModelList = closeSafetyPopupControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            closeSafetyPopupControlCommandResponseViewModel.CloseSafetyPopupControlCommandResponseModel = await closeSafetyPopupControlCommandResponseViewHelper.PostCloseSafetyPopupControlCommandResponseModelAsync();
            return View(closeSafetyPopupControlCommandResponseViewModel);
        }
        public async Task<IActionResult> UnlockProtectiveStopControlCommandResponseAsync()
        {
            IotViewHelper.UnlockProtectiveStopControlCommandResponseViewHelper unlockProtectiveStopControlCommandResponseViewHelper = new IotViewHelper
                .UnlockProtectiveStopControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.UnlockProtectiveStopControlCommandResponseViewModel unlockProtectiveStopControlCommandResponseViewModel = new IotViewModel.UnlockProtectiveStopControlCommandResponseViewModel();
            unlockProtectiveStopControlCommandResponseViewModel.BreadCrumbPartialViewModelList = unlockProtectiveStopControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            unlockProtectiveStopControlCommandResponseViewModel.UnlockProtectiveStopControlCommandResponseModel = await unlockProtectiveStopControlCommandResponseViewHelper.PostUnlockProtectiveStopControlCommandResponseModelAsync();
            return View(unlockProtectiveStopControlCommandResponseViewModel);
        }
        public async Task<IActionResult> ClosePopupControlCommandResponseAsync()
        {
            IotViewHelper.ClosePopupControlCommandResponseViewHelper closePopupControlCommandResponseViewHelper = new IotViewHelper
                .ClosePopupControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
            IotViewModel.ClosePopupControlCommandResponseViewModel closePopupControlCommandResponseViewModel = new IotViewModel.ClosePopupControlCommandResponseViewModel();
            closePopupControlCommandResponseViewModel.BreadCrumbPartialViewModelList = closePopupControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
            closePopupControlCommandResponseViewModel.ClosePopupControlCommandResponseModel = await closePopupControlCommandResponseViewHelper.PostClosePopupControlCommandResponseModelAsync();
            return View(closePopupControlCommandResponseViewModel);
        }
        [HttpGet]
        public IActionResult OpenPopupControlCommandRequest()
        {
            IotViewHelper.OpenPopupControlCommandRequestViewHelper openPopupControlCommandRequestViewHelper = new IotViewHelper.OpenPopupControlCommandRequestViewHelper();
            IotViewModel.OpenPopupControlCommandRequestViewModel openPopupControlCommandRequestViewModel = new IotViewModel.OpenPopupControlCommandRequestViewModel();
            openPopupControlCommandRequestViewModel.BreadCrumbPartialViewModelList = openPopupControlCommandRequestViewHelper.GetBreadCrumbPartialViewModelList();
            return View(openPopupControlCommandRequestViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> OpenPopupControlCommandResponseAsync(OpenPopupControlCommandRequestViewModel openPopupControlCommandRequestViewModel)
        {
            if (openPopupControlCommandRequestViewModel.PopupText is not null)
            {
                IotViewHelper.OpenPopupControlCommandResponseViewHelper openPopupControlCommandResponseViewHelper = new IotViewHelper
           .OpenPopupControlCommandResponseViewHelper(cobotIotCommandFunctionService: _cobotIotCommandFunctionService);
                IotViewModel.OpenPopupControlCommandResponseViewModel openPopupControlCommandResponseViewModel = new IotViewModel.OpenPopupControlCommandResponseViewModel();
                openPopupControlCommandResponseViewModel.BreadCrumbPartialViewModelList = openPopupControlCommandResponseViewHelper.GetBreadCrumbPartialViewModelList();
                openPopupControlCommandResponseViewModel.OpenPopupControlCommandResponseModel = await openPopupControlCommandResponseViewHelper.PostOpenPopupControlCommandResponseModelAsync(openPopupControlCommandRequestViewModel);
                return View(openPopupControlCommandResponseViewModel);
            }
            else
            {
                return Redirect("OpenPopupControlCommandRequest");
            }
           
        }
    }
}