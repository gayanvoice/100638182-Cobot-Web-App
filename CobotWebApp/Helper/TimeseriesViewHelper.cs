using CobotWebApp.Models.Request;
using CobotWebApp.Models.View.Partial;
using CobotWebApp.Services;

namespace CobotWebApp.Helper
{
    public class TimeseriesViewHelper
    {
        public class DashboardViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForDashboardView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Time Series Dashboard")
                };
                return breadCrumbPartialViewModelList;
            }
        }
    }
}