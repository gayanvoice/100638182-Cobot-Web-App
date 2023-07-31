using CobotWebApp.Helper;
using CobotWebApp.Models;
using CobotWebApp.Models.View;
using CobotWebApp.Singleton;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace CobotWebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBuildDependency _buildDependency;

        public HomeController(ILogger<HomeController> logger,
            IBuildDependency buildDependency)
        {
            _logger = logger;
            _buildDependency = buildDependency;
        }
        public IActionResult Index()
        {
            return Redirect("Home/Dashboard");
        }
        public IActionResult Dashboard()
        {
            HomeViewModel.DashboardViewModel dashboardViewModel = new HomeViewModel.DashboardViewModel();
            HomeViewHelper.DashboardViewHelper dashboardViewHelper = new HomeViewHelper.DashboardViewHelper();
            dashboardViewModel.BreadCrumbPartialViewModelList = dashboardViewHelper.GetBreadCrumbPartialViewModelListForDashboardView();
            return View(dashboardViewModel);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}