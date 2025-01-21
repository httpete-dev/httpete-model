using Abp.Domain.Entities;

namespace HttPete.Model.Tenants
{

    public class Endpoint : Entity, IEntity
    {
        public string Url { get; set; }

        public string Headers { get; set; }

        public string Method { get; set; }

        public BaseUrl BaseUrl { get; set; }

        public int BaseUrlId { get; set; }

        public string Body { get; set; }

        public int CollectionId { get; set; }

        public int WorkspaceId { get; set; }

        public int OrganizationId { get; set; }

        public Document Documentation { get; set; }

        public Endpoint() { }

        /// <summary>
        /// Default Endpoint definition, used for new accounts.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="collectionId"></param>
        public Endpoint(int organizationId, int workspaceId, int collectionId)
        {
            Url = "/example/get-example";
            Method = MethodType.POST.ToString();
            Headers = Constants.DEFAULT_HEADERS;
            Body = Constants.DEFAULT_BODY;
            CollectionId = collectionId;
            OrganizationId = organizationId;
            WorkspaceId = workspaceId;
        }
    }
}