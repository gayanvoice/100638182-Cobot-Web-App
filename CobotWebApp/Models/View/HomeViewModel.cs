using CobotWebApp.Models.View.Partial;

namespace CobotWebApp.Models.View
{
    public class HomeViewModel
    {
        public class DashboardViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
        }
    }
}