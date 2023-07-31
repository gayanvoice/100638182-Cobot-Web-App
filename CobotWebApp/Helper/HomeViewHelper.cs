using CobotWebApp.Models.View.Partial;

namespace CobotWebApp.Helper
{
    public class HomeViewHelper
    {
        public class DashboardViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForDashboardView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
            {
                BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Dashboard")
            };
                return breadCrumbPartialViewModelList;
            }
        }

    }
}