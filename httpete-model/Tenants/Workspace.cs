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
                                Url = "/default/hello-world",
                                Headers = Constants.DEFAULT_HEADERS,
                                Body = Constants.DEFAULT_BODY,
                                Documentation = new Document {
                                    Title = "README <3",
                                    Text = "# Welcome\nWelcome to HttPete!\nBrowse around to find a default Workspace we have created for you.\n" +
                                    "Feel free to edit anything or downright delete the workspace. You can always start fresh by clicking the \"Add New\", button " +
                                    "in the Workspaces dropdown in the top navigation.\n\nEach Workspace is comprised of Collections, which can have many Endpoints.\n" +
                                    "Each Endpoint has a Document, just like this one, with endpoint specific information, which you can import from any XML documentation file.\n" +
                                    "If you're coming over from Postman, feel free to use the import button next to the Collections in the sidebar, to get a head start with the endpoints." +
                                    "you had in Postman.\nAll of your data is stored locally on your device. If you'd like to enable backups, version control, and some additional features, " +
                                    "please create an account. Alternatively, you can also host your own version of HttPete, you can find a guide to doing so [here](https://httpete.dev/guides/self-host)." +
                                    "\n\nThank you for using HttPete, feel free to send any questions of feedback to [hello@httpete.dev](mailto:hello@httpete.dev)."
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