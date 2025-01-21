using Abp.Domain.Entities;

namespace HttPete.Model.Tenants
{
    public class Document : Entity, IEntity
    {
        public int OrganizationId { get; set; }

        public int WorkspaceId { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public int AuthorId { get; set; }

        public int LastEditById { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastEdited { get; set; }

        public IEnumerable<Document> Children { get; set; } = [];

        public Document() { }
        public Document(User user, int endpointId, int orgId, int workspaceId)
        {
            AuthorId = user.Id;
            Created = DateTime.UtcNow;
            EndpointId = endpointId;
            LastEditById = user.Id;
            LastEdited = DateTime.UtcNow;
            Title = "My first document";
            WorkspaceId = workspaceId;
            OrganizationId = orgId;
            Text = "# Introduction\nThis is my first document!";
        }

        public int? EndpointId { get; set; }
    }
}