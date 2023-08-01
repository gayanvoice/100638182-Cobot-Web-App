using CobotWebApp.Helper;
using CobotWebApp.Models;
using CobotWebApp.Models.View;
using CobotWebApp.Services;
using CobotWebApp.Singleton;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CobotWebApp.Controllers
{
    [Authorize]
    public class AdtController : Controller
    {
        private readonly ILogger<AdtController> _logger;
        private readonly IBuildDependency _buildDependency;
        private readonly CobotAdtInitializeFunctionService _cobotAdtInitializeFunctionService;
        public AdtController(ILogger<AdtController> logger,
            IBuildDependency buildDependency,
            CobotAdtInitializeFunctionService cobotAdtInitializeFunctionService)
        {
            _logger = logger;
            _buildDependency = buildDependency;
            _cobotAdtInitializeFunctionService = cobotAdtInitializeFunctionService;


        }
        public IActionResult Index()
        {
            return Redirect("Adt/Dashboard");
        }
        public IActionResult Dashboard()
        {
            AdtViewModel.DashboardViewModel dashboardViewModel = new AdtViewModel.DashboardViewModel();
            AdtViewHelper.DashboardViewHelper dashboardViewHelper = new AdtViewHelper.DashboardViewHelper();
            dashboardViewModel.BreadCrumbPartialViewModelList = dashboardViewHelper.GetBreadCrumbPartialViewModelList();
            return View(dashboardViewModel);
        }
        public async Task<IActionResult> UploadDtdlModelAsync()
        {
            AdtViewModel.UploadDtdlModelViewModel uploadDtdlModelViewModel = new AdtViewModel.UploadDtdlModelViewModel();
            AdtViewHelper.UploadDtdlModelViewHelper uploadDtdlModelViewHelper = new AdtViewHelper.UploadDtdlModelViewHelper(
                cobotAdtInitializeFunctionService: _cobotAdtInitializeFunctionService);
            uploadDtdlModelViewModel.BreadCrumbPartialViewModelList = uploadDtdlModelViewHelper.GetBreadCrumbPartialViewModelList();
            uploadDtdlModelViewModel.UploadDtdlModelResponseViewModelList = await uploadDtdlModelViewHelper.GetUploadDtdlModelResponseViewModelListAsync();
            return View(uploadDtdlModelViewModel);
        }
        public async Task<IActionResult> DeleteAdtRelationshipAsync()
        {
            AdtViewModel.DeleteAdtRelationshipViewModel deleteAdtRelationshipViewModel = new AdtViewModel.DeleteAdtRelationshipViewModel();
            AdtViewHelper.DeleteAdtRelationshipViewHelper deleteAdtRelationshipViewHelper = new AdtViewHelper.DeleteAdtRelationshipViewHelper(
                cobotAdtInitializeFunctionService: _cobotAdtInitializeFunctionService);
            deleteAdtRelationshipViewModel.BreadCrumbPartialViewModelList = deleteAdtRelationshipViewHelper.GetBreadCrumbPartialViewModelList();
            deleteAdtRelationshipViewModel.DeleteAdtRelationshipResponseViewModelList = await deleteAdtRelationshipViewHelper.GetDeleteAdtRelationshipResponseViewModelListAsync();
            return View(deleteAdtRelationshipViewModel);
        }
        public async Task<IActionResult> DeleteAdtModelAsync()
        {
            AdtViewModel.DeleteAdtModelViewModel deleteAdtModelViewModel = new AdtViewModel.DeleteAdtModelViewModel();
            AdtViewHelper.DeleteAdtModelViewHelper deleteAdtModelViewHelper = new AdtViewHelper.DeleteAdtModelViewHelper(
                cobotAdtInitializeFunctionService: _cobotAdtInitializeFunctionService);
            deleteAdtModelViewModel.BreadCrumbPartialViewModelList = deleteAdtModelViewHelper.GetBreadCrumbPartialViewModelList();
            deleteAdtModelViewModel.DeleteAdtModelResponseViewModelList = await deleteAdtModelViewHelper.GetDeleteAdtModelResponseViewModelListAsync();
            return View(deleteAdtModelViewModel);
        }
        public async Task<IActionResult> CreateAdtModelAsync()
        {
            AdtViewModel.CreateAdtModelViewModel createAdtModelViewModel = new AdtViewModel.CreateAdtModelViewModel();
            AdtViewHelper.CreateAdtModelViewHelper createAdtModelViewHelper = new AdtViewHelper.CreateAdtModelViewHelper(
                cobotAdtInitializeFunctionService: _cobotAdtInitializeFunctionService);
            createAdtModelViewModel.BreadCrumbPartialViewModelList = createAdtModelViewHelper.GetBreadCrumbPartialViewModelList();
            createAdtModelViewModel.CreateAdtModelResponseViewModelList = await createAdtModelViewHelper.GetCreateAdtModelResponseViewModelListAsync();
            return View(createAdtModelViewModel);
        }
        public async Task<IActionResult> CreateAdtRelationshipAsync()
        {
            AdtViewModel.CreateAdtRelationshipViewModel createAdtRelationshipViewModel = new AdtViewModel.CreateAdtRelationshipViewModel();
            AdtViewHelper.CreateAdtRelationshipViewHelper createAdtRelationshipViewHelper = new AdtViewHelper.CreateAdtRelationshipViewHelper(
                cobotAdtInitializeFunctionService: _cobotAdtInitializeFunctionService);
            createAdtRelationshipViewModel.BreadCrumbPartialViewModelList = createAdtRelationshipViewHelper.GetBreadCrumbPartialViewModelList();
            createAdtRelationshipViewModel.CreateAdtRelationshipResponseViewModelList = await createAdtRelationshipViewHelper.GetCreateAdtRelationshipResponseViewModelListAsync();
            return View(createAdtRelationshipViewModel);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}