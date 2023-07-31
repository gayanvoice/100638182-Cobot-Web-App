using System.Net;

namespace CobotWebApp.Models.Request
{
    public class CobotAdtInitializeFunctionModel
    {
        public class RequestModel
        {
            public class UploadDtdlModelRequestModel
            {
                public UploadDtdlModelRequestModel(string name)
                {
                    Name = name;
                }
                public string Name { get; set; }
            }
            public class DeleteAdtRelationshipRequestModel
            {
                public DeleteAdtRelationshipRequestModel(string from, string id)
                {
                    From = from;
                    Id = id;
                }
                public string From { get; set; }
                public string Id { get; set; }
            }
            public class DeleteAdtModelRequestModel
            {
                public DeleteAdtModelRequestModel(string id)
                {
                    Id = id;
                }
                public string Id { get; set; }
            }
            public class CreateAdtModelRequestModel
            {
                public CreateAdtModelRequestModel(string name, string id)
                {
                    Name = name;
                    Id = id;
                }
                public string Name { get; set; }
                public string Id { get; set; }
            }
            public class CreateAdtRelationshipRequestModel
            {
                public CreateAdtRelationshipRequestModel(string name, string from, string to)
                {
                    Name = name;
                    From = from;
                    To = to;
                }
                public string Name { get; set; }
                public string From { get; set; }
                public string To { get; set; }
            }
        }
        public class ResponseModel
        {
            public HttpStatusCode HttpStatusCode { get; set; }
            public string? Message { get; set; }
            public double Duration { get; set; }
            public object? Exception { get; set; }
        }
    }
}
