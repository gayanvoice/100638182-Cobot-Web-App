using CobotWebApp.Models.Request;
using CobotWebApp.Models.View.Partial;
using CobotWebApp.Services;
using static CobotWebApp.Models.View.AdtViewModel.CreateAdtModelViewModel;
using static CobotWebApp.Models.View.AdtViewModel.CreateAdtRelationshipViewModel;
using static CobotWebApp.Models.View.AdtViewModel.DeleteAdtModelViewModel;
using static CobotWebApp.Models.View.AdtViewModel.DeleteAdtRelationshipViewModel;
using static CobotWebApp.Models.View.AdtViewModel.UploadDtdlModelViewModel;

namespace CobotWebApp.Helper
{
    public class AdtViewHelper
    {
        public class DashboardViewHelper
        {
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Adt Dashboard")
                };
                return breadCrumbPartialViewModelList;
            }
        }
        public class UploadDtdlModelViewHelper
        {
            private readonly CobotAdtInitializeFunctionService _cobotAdtInitializeFunctionService;
            public UploadDtdlModelViewHelper(CobotAdtInitializeFunctionService cobotAdtInitializeFunctionService) =>
            _cobotAdtInitializeFunctionService = cobotAdtInitializeFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Adt Dashboard", aspController:"Adt", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Upload Dtdl Model")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<List<UploadDtdlModelResponseViewModel>> GetUploadDtdlModelResponseViewModelListAsync()
            {
                List<CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel> uploadDtdlModelRequestModelList =
                    new List<CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel>
                    {
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Cobot"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "ControlBox"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Base"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Elbow"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Shoulder"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Tool"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Wrist1"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Wrist2"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Wrist3"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "JointLoad"),
                    new CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel(name: "Payload")
                    };
                List<UploadDtdlModelResponseViewModel> uploadDtdlModelResponseViewModelList =
                    new List<UploadDtdlModelResponseViewModel>();
                foreach (CobotAdtInitializeFunctionModel.RequestModel.UploadDtdlModelRequestModel uploadDtdlModelRequestModel
                    in uploadDtdlModelRequestModelList)
                {
                    CobotAdtInitializeFunctionModel.ResponseModel? responseModel =
                       await _cobotAdtInitializeFunctionService.GetUploadDtdlModelResponseModelAsync(uploadDtdlModelRequestModel);
                    if (responseModel is not null)
                    {
                        uploadDtdlModelResponseViewModelList.Add(new UploadDtdlModelResponseViewModel(
                            name: uploadDtdlModelRequestModel.Name, responseModel: responseModel));
                    }
                }
                return uploadDtdlModelResponseViewModelList;
            }
        }
        public class DeleteAdtRelationshipViewHelper
        {
            private readonly CobotAdtInitializeFunctionService _cobotAdtInitializeFunctionService;
            public DeleteAdtRelationshipViewHelper(CobotAdtInitializeFunctionService cobotAdtInitializeFunctionService) =>
            _cobotAdtInitializeFunctionService = cobotAdtInitializeFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Adt Dashboard", aspController:"Adt", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Delete Adt Relationship")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<List<DeleteAdtRelationshipResponseViewModel>> GetDeleteAdtRelationshipResponseViewModelListAsync()
            {
                List<CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel> deleteAdtRelationshipRequestModelList =
                    new List<CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel>
                    {
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "Cobot", id:"Cobot-ContainsControlBox-ControlBox"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "Cobot", id:"Cobot-ContainsPayload-Payload"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "Cobot", id:"Cobot-ContainsJointLoad-JointLoad"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "JointLoad", id:"JointLoad-ContainsWrist1-Wrist1"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "JointLoad", id:"JointLoad-ContainsWrist2-Wrist2"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "JointLoad", id:"JointLoad-ContainsWrist3-Wrist3"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "JointLoad", id:"JointLoad-ContainsBase-Base"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "JointLoad", id:"JointLoad-ContainsTool-Tool"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "JointLoad", id:"JointLoad-ContainsShoulder-Shoulder"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "JointLoad", id:"JointLoad-ContainsElbow-Elbow"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TCobot", id:"TCobot-ContainsControlBox-TControlBox"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TCobot", id:"TCobot-ContainsPayload-TPayload"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TCobot", id:"TCobot-ContainsJointLoad-TJointLoad"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TJointLoad", id:"TJointLoad-ContainsWrist1-TWrist1"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TJointLoad", id:"TJointLoad-ContainsWrist2-TWrist2"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TJointLoad", id:"TJointLoad-ContainsWrist3-TWrist3"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TJointLoad", id:"TJointLoad-ContainsBase-TBase"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TJointLoad", id:"TJointLoad-ContainsTool-TTool"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TJointLoad", id:"TJointLoad-ContainsShoulder-TShoulder"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel(from: "TJointLoad", id:"TJointLoad-ContainsElbow-TElbow")
                    };
                List<DeleteAdtRelationshipResponseViewModel> deleteAdtRelationshipResponseViewModelList = new List<DeleteAdtRelationshipResponseViewModel>();
                foreach (CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtRelationshipRequestModel deleteAdtRelationshipRequestModel in deleteAdtRelationshipRequestModelList)
                {
                    CobotAdtInitializeFunctionModel.ResponseModel? responseModel =
                       await _cobotAdtInitializeFunctionService.GetDeleteAdtRelationshipResponseModelAsync(deleteAdtRelationshipRequestModel);
                    if (responseModel is not null)
                    {
                        deleteAdtRelationshipResponseViewModelList.Add(new DeleteAdtRelationshipResponseViewModel(
                            from: deleteAdtRelationshipRequestModel.From, id: deleteAdtRelationshipRequestModel.Id, responseModel: responseModel));
                    }
                }
                return deleteAdtRelationshipResponseViewModelList;
            }
        }
        public class DeleteAdtModelViewHelper
        {
            private readonly CobotAdtInitializeFunctionService _cobotAdtInitializeFunctionService;
            public DeleteAdtModelViewHelper(CobotAdtInitializeFunctionService cobotAdtInitializeFunctionService) =>
            _cobotAdtInitializeFunctionService = cobotAdtInitializeFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Adt Dashboard", aspController:"Adt", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Delete Adt Model")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<List<DeleteAdtModelResponseViewModel>> GetDeleteAdtModelResponseViewModelListAsync()
            {
                List<CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel> deleteAdtModelRequestModelList =
                    new List<CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel>
                    {
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Cobot"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "ControlBox"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "JointLoad"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Payload"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Base"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Shoulder"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Elbow"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Wrist1"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Wrist2"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Wrist3"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "Tool"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TCobot"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TControlBox"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TJointLoad"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TPayload"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TBase"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TShoulder"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TElbow"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TWrist1"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TWrist2"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TWrist3"),
                        new CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel(id: "TTool")
                    };
                List<DeleteAdtModelResponseViewModel> deleteAdtModelResponseViewModelList = new List<DeleteAdtModelResponseViewModel>();
                foreach (CobotAdtInitializeFunctionModel.RequestModel.DeleteAdtModelRequestModel deleteAdtModelRequestModel in deleteAdtModelRequestModelList)
                {
                    CobotAdtInitializeFunctionModel.ResponseModel? responseModel =
                       await _cobotAdtInitializeFunctionService.GetDeleteAdtModelResponseModelAsync(deleteAdtModelRequestModel);
                    if (responseModel is not null)
                    {
                        deleteAdtModelResponseViewModelList.Add(new DeleteAdtModelResponseViewModel(
                            id: deleteAdtModelRequestModel.Id, responseModel: responseModel));
                    }
                }
                return deleteAdtModelResponseViewModelList;
            }
        }
        public class CreateAdtModelViewHelper
        {
            private readonly CobotAdtInitializeFunctionService _cobotAdtInitializeFunctionService;
            public CreateAdtModelViewHelper(CobotAdtInitializeFunctionService cobotAdtInitializeFunctionService) =>
            _cobotAdtInitializeFunctionService = cobotAdtInitializeFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Adt Dashboard", aspController:"Adt", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Create Adt Model")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<List<CreateAdtModelResponseViewModel>> GetCreateAdtModelResponseViewModelListAsync()
            {
                List<CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel> createAdtModelRequestModelList =
                    new List<CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel>
                    {
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Cobot", id: "Cobot"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "ControlBox", id: "ControlBox"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "JointLoad", id: "JointLoad"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Payload", id: "Payload"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Base", id: "Base"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Shoulder", id: "Shoulder"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Elbow", id: "Elbow"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Wrist1", id: "Wrist1"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Wrist2", id: "Wrist2"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Wrist3", id: "Wrist3"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Tool", id: "Tool"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Cobot", id: "TCobot"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "ControlBox", id: "TControlBox"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "JointLoad", id: "TJointLoad"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Payload", id: "TPayload"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Base", id: "TBase"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Shoulder", id:  "TShoulder"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Elbow", id:  "TElbow"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Wrist1", id: "TWrist1"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Wrist2", id: "TWrist2"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Wrist3", id: "TWrist3"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel(name: "Tool", id: "TTool")
                    };
                List<CreateAdtModelResponseViewModel> createAdtModelResponseViewModelList = new List<CreateAdtModelResponseViewModel>();
                foreach (CobotAdtInitializeFunctionModel.RequestModel.CreateAdtModelRequestModel createAdtModelRequestModel in createAdtModelRequestModelList)
                {
                    CobotAdtInitializeFunctionModel.ResponseModel? responseModel =
                       await _cobotAdtInitializeFunctionService.GetCreateAdtModelResponseModelAsync(createAdtModelRequestModel);
                    if (responseModel is not null)
                    {
                        createAdtModelResponseViewModelList.Add(new CreateAdtModelResponseViewModel(
                            name: createAdtModelRequestModel.Name,
                            id: createAdtModelRequestModel.Id,
                            responseModel: responseModel));
                    }
                }
                return createAdtModelResponseViewModelList;
            }
        }
        public class CreateAdtRelationshipViewHelper
        {
            private readonly CobotAdtInitializeFunctionService _cobotAdtInitializeFunctionService;
            public CreateAdtRelationshipViewHelper(CobotAdtInitializeFunctionService cobotAdtInitializeFunctionService) =>
            _cobotAdtInitializeFunctionService = cobotAdtInitializeFunctionService;
            public List<BreadCrumbPartialViewModel> GetBreadCrumbPartialViewModelList()
            {
                List<BreadCrumbPartialViewModel> breadCrumbPartialViewModelList = new List<BreadCrumbPartialViewModel>
                {
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Dashboard", aspController:"Home", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetItem(breadCrumbItem:"Adt Dashboard", aspController:"Adt", aspAction:"Dashboard"),
                    BreadCrumbPartialViewModel.GetCurrentItem(breadCrumbItem:"Create Adt Relationship")
                };
                return breadCrumbPartialViewModelList;
            }
            public async Task<List<CreateAdtRelationshipResponseViewModel>> GetCreateAdtRelationshipResponseViewModelListAsync()
            {
                List<CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel> createAdtRelationshipRequestModelList =
                    new List<CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel>
                    {
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "Cobot", to: "ControlBox", name: "ContainsControlBox"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "Cobot", to: "JointLoad", name: "ContainsJointLoad"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "Cobot", to: "Payload", name: "ContainsPayload"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "JointLoad", to: "Base", name: "ContainsBase"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "JointLoad", to: "Shoulder", name: "ContainsShoulder"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "JointLoad", to: "Elbow", name: "ContainsElbow"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "JointLoad", to: "Wrist1", name: "ContainsWrist1"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "JointLoad", to: "Wrist2", name: "ContainsWrist2"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "JointLoad", to: "Wrist3", name: "ContainsWrist3"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "JointLoad", to: "Tool", name: "ContainsTool"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TCobot", to: "TControlBox", name: "ContainsControlBox"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TCobot", to: "TJointLoad", name: "ContainsJointLoad"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TCobot", to: "TPayload", name: "ContainsPayload"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TJointLoad", to: "TBase", name: "ContainsBase"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TJointLoad", to: "TShoulder", name: "ContainsShoulder"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TJointLoad", to: "TElbow", name: "ContainsElbow"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TJointLoad", to: "TWrist1", name: "ContainsWrist1"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TJointLoad", to: "TWrist2", name: "ContainsWrist2"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TJointLoad", to: "TWrist3", name: "ContainsWrist3"),
                        new CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel(from: "TJointLoad", to: "TTool", name: "ContainsTool"),
                    };
                List<CreateAdtRelationshipResponseViewModel> createAdtRelationshipResponseViewModelList = new List<CreateAdtRelationshipResponseViewModel>();
                foreach (CobotAdtInitializeFunctionModel.RequestModel.CreateAdtRelationshipRequestModel createAdtRelationshipRequestModel in createAdtRelationshipRequestModelList)
                {
                    CobotAdtInitializeFunctionModel.ResponseModel? responseModel =
                       await _cobotAdtInitializeFunctionService.GetCreateAdtRelationshipResponseModelAsync(createAdtRelationshipRequestModel);
                    if (responseModel is not null)
                    {
                        createAdtRelationshipResponseViewModelList.Add(new CreateAdtRelationshipResponseViewModel(
                            name: createAdtRelationshipRequestModel.Name,
                            from: createAdtRelationshipRequestModel.From,
                            to: createAdtRelationshipRequestModel.To,
                            responseModel: responseModel));
                    }
                }
                return createAdtRelationshipResponseViewModelList;
            }
        }
    }
}