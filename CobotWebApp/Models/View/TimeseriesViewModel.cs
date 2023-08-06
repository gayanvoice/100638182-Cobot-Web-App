using CobotWebApp.Models.Request;
using CobotWebApp.Models.View.Partial;

namespace CobotWebApp.Models.View
{
    public class TimeseriesViewModel
    {
        public class DashboardViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
        }
    }
}