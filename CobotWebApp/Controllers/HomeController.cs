using CobotWebApp.Models;
using CobotWebApp.Singleton;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

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
            string version = _buildDependency.GetBuildNumber();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}