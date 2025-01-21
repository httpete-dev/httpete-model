using Abp.Domain.Entities;

namespace HttPete.Model.Tenants
{
    public class Workspace : Entity, IEntity
    {
        public string Title { get; set; } = "Default Workspace";

        public string Description { get; set; } = "My first workspace.";

        public int OrganizationId { get; set; }

        public IEnumerable<Collection>? Collections { get; set; }

        public Workspace(string userName, int orgId)
        {
            Title = userName + "\'s Workspace";
            Description = "My first workspace.";
            OrganizationId = orgId;
        }
        public Workspace()
        {

        }

        public static Workspace Default => new()
        {
            Title = "Default Workspace",
            Collections =
                [
                    new Collection
                    {
                        Name = "Default Collection",
                        Description = "This is the default collection.",
                        Icon = "Globe",
                        Endpoints =
                        [
                            new Endpoint
                            {
                                Url = Constants.DEFAULT_ENDPOINT_URL,
                                Headers = Constants.DEFAULT_ENDPOINT_HEADERS,
                                Body = Constants.DEFAULT_ENDPOINT_BODY,
                                Documentation = new Document {
                                    Title = "README <3",
                                    Text = Constants.DEFAULT_DOCUMENT_TEXT
                                },
                                Method = "GET",
                                BaseUrl = new BaseUrl
                                {
                                    Protocol = "https",
                                    Value = "https://httpete.dev"
                                }
                            },
                        ],
                    }
                ],
            Description = "This is the default workspace."
        };
    }
}