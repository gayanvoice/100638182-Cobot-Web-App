using Azure.Identity;
using CobotWebApp.Helper;
using CobotWebApp.Models;
using CobotWebApp.Models.View;
using CobotWebApp.Singleton;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using System.Diagnostics;
using Azure.Identity;
using NuGet.Packaging.Signing;
using System.Text;


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
        //public async Task<Cobot> NoSqlAsync()
        //{
        //    string ADT_SERIVICE_URL = "https://100638182AzureDigitalTwins.api.uks.digitaltwins.azure.net";
        //    string COSMOS_URI = "https://100638182-cobot-cosmos-db-account.documents.azure.com:443/";
        //    string COSMOS_KEY = "852BblHmi4X7QuqU9XiSAz1RkBsy3ogQ49bTBADHjcjAlEGXWKglBINzLZODcg6E3PgcMw1WGRHUACDb6qO8SQ==";
        //    // New instance of CosmosClient class
        //    using CosmosClient client = new(
        //        accountEndpoint: COSMOS_URI,
        //        authKeyOrResourceToken: COSMOS_KEY
        //    );
        //    Database cobotDatabase = await client.CreateDatabaseIfNotExistsAsync(id: "cobotDatabase");

        //    Console.WriteLine($"New database:\t{cobotDatabase.Id}");
        //    Container cobotContainer = cobotDatabase.GetContainer(id: "cobotContainer");
        //    string elapsedTime = DateTime.Now.ToString("yyyyMMddHHmmssffff");
        //    Console.WriteLine($"New container:\t{cobotContainer.Id}");
        //    string key = MD5Encryption(elapsedTime.ToString());
        //    Cobot cobot = new(
        //        id: key,
        //        deviceId: "Cobot",
        //        timestamp: elapsedTime,
        //        elapsedTime: 5.0
        //    );
        //    Cobot cobotCreatedItem = await cobotContainer.CreateItemAsync<Cobot>(
        //        item: cobot,
        //        partitionKey: new PartitionKey("Cobot")
        //    );

        //    Console.WriteLine($"Created item:\t{cobotCreatedItem.timestamp}\t[{cobotCreatedItem.elapsedTime}]");;
        //    return new Cobot(MD5Encryption(elapsedTime.ToString()), "Cobot", elapsedTime, 0.0);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       

    }
    public record Cobot(
           string id,
           string deviceId,
           string timestamp,
           double elapsedTime
   );

    
}