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
    }
}