using Abp.Domain.Entities;

namespace HttPete.Model.Tenants
{
    public class Collection : Entity, IEntity
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Icon { get; set; }

        public int OrganizationId { get; set; }

        public int WorkspaceId { get; set; }

        public IEnumerable<Endpoint>? Endpoints { get; set; }

        public Collection(string userName, int orgId, int workspaceId)
        {
            OrganizationId = orgId;
            Description = "My first collection.";
            WorkspaceId = workspaceId;
            Name = userName + "\'s Collection";
        }

        public Collection()
        {

        }
    }
}