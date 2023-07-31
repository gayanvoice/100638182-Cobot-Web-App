using CobotWebApp.Models.Request;
using CobotWebApp.Models.View.Partial;

namespace CobotWebApp.Models.View
{
    public class AdtViewModel
    {
        public class DashboardViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
        }
        public class UploadDtdlModelViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public List<UploadDtdlModelResponseViewModel>? UploadDtdlModelResponseViewModelList { get; set; }
            public class UploadDtdlModelResponseViewModel
            {
                public UploadDtdlModelResponseViewModel(string name, CobotAdtInitializeFunctionModel.ResponseModel responseModel)
                {
                    Name = name;
                    ResponseModel = responseModel;
                }
                public string? Name { get; set; }
                public CobotAdtInitializeFunctionModel.ResponseModel ResponseModel { get; set; }
            }
        }
        public class DeleteAdtRelationshipViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public List<DeleteAdtRelationshipResponseViewModel>? DeleteAdtRelationshipResponseViewModelList { get; set; }
            public class DeleteAdtRelationshipResponseViewModel
            {
                public DeleteAdtRelationshipResponseViewModel(
                    string from,
                    string id,
                    CobotAdtInitializeFunctionModel.ResponseModel responseModel)
                {
                    From = from;
                    Id = id;
                    ResponseModel = responseModel;
                }
                public string? From { get; set; }
                public string? Id { get; set; }
                public CobotAdtInitializeFunctionModel.ResponseModel ResponseModel { get; set; }
            }
        }
        public class DeleteAdtModelViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public List<DeleteAdtModelResponseViewModel>? DeleteAdtModelResponseViewModelList { get; set; }
            public class DeleteAdtModelResponseViewModel
            {
                public DeleteAdtModelResponseViewModel(
                    string id,
                    CobotAdtInitializeFunctionModel.ResponseModel responseModel)
                {
                    Id = id;
                    ResponseModel = responseModel;
                }
                public string? Id { get; set; }
                public CobotAdtInitializeFunctionModel.ResponseModel ResponseModel { get; set; }
            }
        }
        public class CreateAdtModelViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public List<CreateAdtModelResponseViewModel>? CreateAdtModelResponseViewModelList { get; set; }
            public class CreateAdtModelResponseViewModel
            {
                public CreateAdtModelResponseViewModel(
                    string name,
                    string id,
                    CobotAdtInitializeFunctionModel.ResponseModel responseModel)
                {
                    Name = name;
                    Id = id;
                    ResponseModel = responseModel;
                }
                public string? Name{ get; set; }
                public string? Id { get; set; }
                public CobotAdtInitializeFunctionModel.ResponseModel ResponseModel { get; set; }
            }
        }
        public class CreateAdtRelationshipViewModel
        {
            public List<BreadCrumbPartialViewModel>? BreadCrumbPartialViewModelList { get; set; }
            public List<CreateAdtRelationshipResponseViewModel>? CreateAdtRelationshipResponseViewModelList { get; set; }
            public class CreateAdtRelationshipResponseViewModel
            {
                public CreateAdtRelationshipResponseViewModel(
                    string name,
                    string from,
                    string to,
                    CobotAdtInitializeFunctionModel.ResponseModel responseModel)
                {
                    Name = name;
                    From = from;
                    To = to;
                    ResponseModel = responseModel;
                }
                public string? Name { get; set; }
                public string? From { get; set; }
                public string? To { get; set; }
                public CobotAdtInitializeFunctionModel.ResponseModel ResponseModel { get; set; }
            }
        }
    }
}