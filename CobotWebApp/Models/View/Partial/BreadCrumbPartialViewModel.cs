namespace CobotWebApp.Models.View.Partial
{
    public class BreadCrumbPartialViewModel
    {
        public string? BreadCrumbItem { get; set; }
        public bool IsCurrentItem { get; set; }
        public string? AspController { get; set; }
        public string? AspAction { get; set; }

        public static BreadCrumbPartialViewModel GetCurrentItem(string breadCrumbItem)
        {
            BreadCrumbPartialViewModel breadCrumbPartialViewModel = new BreadCrumbPartialViewModel();
            breadCrumbPartialViewModel.BreadCrumbItem = breadCrumbItem;
            breadCrumbPartialViewModel.IsCurrentItem = true;
            return breadCrumbPartialViewModel;
        }
        public static BreadCrumbPartialViewModel GetItem(string breadCrumbItem, string aspController, string aspAction)
        {
            BreadCrumbPartialViewModel breadCrumbPartialViewModel = new BreadCrumbPartialViewModel();
            breadCrumbPartialViewModel.BreadCrumbItem = breadCrumbItem;
            breadCrumbPartialViewModel.IsCurrentItem = false;
            breadCrumbPartialViewModel.AspController = aspController;
            breadCrumbPartialViewModel.AspAction = aspAction;
            return breadCrumbPartialViewModel;
        }
    }
}