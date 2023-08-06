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
        public class CobotViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForCobotView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Cobot")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class ControlBoxViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForCobotView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Control Box")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class PayloadViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForPayloadView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Payload")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class BaseViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForBaseView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Base")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class ShoulderViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForShoulderView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Shoulder")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class ElbowViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForElbowView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Elbow")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class Wrist1ViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForWrist1View()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Wrist1")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class Wrist2ViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForWrist2View()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Wrist2")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class Wrist3ViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForWrist3View()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Wrist3")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class ToolViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelListForToolView()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Time Series Dashboard", aspController:"Timeseries", aspAction:"Dashboard"),
                     BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Tool")
                };
                return breadCrumbPartialViewModelList;
            }
        }
    }
}