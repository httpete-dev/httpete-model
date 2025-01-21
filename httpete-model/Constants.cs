namespace HttPete.Model
{
    public static class Constants
    {

        public static readonly string DEFAULT_ENDPOINT_URL = "/default/hello-world";
        public static readonly string DEFAULT_ENDPOINT_HEADERS = "{\n\"Accept\": \"application/json\"\n}";
        public static readonly string DEFAULT_ENDPOINT_BODY = "{\n\"Message\": \"Hello!\"\n}";
        public static readonly string DEFAULT_DOCUMENT_TEXT = "# Welcome\nWelcome to HttPete!\nBrowse around to find a default Workspace we have created for you.\n" +
                                    "Feel free to edit anything or downright delete the workspace. You can always start fresh by clicking the \"Add New\", button " +
                                    "in the Workspaces dropdown in the top navigation.\n\nEach Workspace is comprised of Collections, which can have many Endpoints.\n" +
                                    "Each Endpoint has a Document, just like this one, with endpoint specific information, which you can import from any XML documentation file.\n" +
                                    "If you're coming over from Postman, feel free to use the import button next to the Collections in the sidebar, to get a head start with the endpoints." +
                                    "you had in Postman.\nAll of your data is stored locally on your device. If you'd like to enable backups, version control, and some additional features, " +
                                    "please create an account. Alternatively, you can also host your own version of HttPete, you can find a guide to doing so [here](https://httpete.dev/guides/self-host)." +
                                    "\n\nThank you for using HttPete, feel free to send any questions of feedback to [hello@httpete.dev](mailto:hello@httpete.dev).";
    }
}
