using Abp.Domain.Entities;

namespace HttPete.Model.Tenants
{
    public class BaseUrl : Entity, IEntity
    {        
        public int WorkspaceId { get; set; }

        /// <summary>
        /// HTTP/HTTPS
        /// </summary>
        public string Protocol { get; set; } = "https";

        /// <summary>
        /// The url itself: www.example.com
        /// </summary>
        public string Value { get; set; } = "httpete.dev";
    }
}